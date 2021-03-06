﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Client.ServiceReference1;
using System.Threading;
using System.Linq;
namespace Client
{
    public partial class FileManagerDialog : UserControl
    {
        ICloudService proxy;
        string username;
        byte[] password;
        public FileManagerDialog()
        {
            InitializeComponent();
            this.cryptoComboBox.Items.Add("RC4");
            this.cryptoComboBox.Items.Add("A52");
            this.cryptoComboBox.Items.Add("CTR");
            this.cryptoComboBox.Items.Add("RSA");
            this.cryptoComboBox.SelectedIndex = 0;
            setForRC4();
        }

        public FileManagerDialog(string username, byte[] password, ICloudService proxy, List<String> fileNames)
            : this()
        {
            this.proxy = proxy;
            this.username = username;
            this.password = password;
            this.file_list.Items.Clear();
            this.updateFileList(fileNames);
        }

        private void updateFileList(List<String> fileNames)
        {
            this.file_list.Items.Clear();
            foreach (string file in fileNames)
            {
                this.file_list.Items.Add(file);
            }
        }

        private void updateFileList()
        {
            this.updateFileList(proxy.getYourFileNames(username, password));
        }

        private enum AlgorithmIndex { 
            RC4=0,
            A52=1,
            CTR=2,
            RSA =3
        }

        protected CryptoFactory cryptoFactory;

        protected void setForRC4()
        {
            this.cryptoBox.Controls.Clear();
            var view = new RC4Settings();
            cryptoFactory = view;
            this.cryptoBox.Controls.Add(view);
        }
        protected void setForRSA()
        {
            this.cryptoBox.Controls.Clear();
            var view = new RSASettings();
            cryptoFactory = view;
            this.cryptoBox.Controls.Add(view);
        }

        protected void setForA52()
        {
            this.cryptoBox.Controls.Clear();
            var view = new A52Settings();
            cryptoFactory = view;
            this.cryptoBox.Controls.Add(view);

        }

        protected void setForCTR()
        {
            this.cryptoBox.Controls.Clear();
            var view = new CTRSettings();
            cryptoFactory = view;
            this.cryptoBox.Controls.Add(view);

        }


        private void uploadButton_Click(object sender, EventArgs e)
        {
            try
            {
                CryptoLibrary.CryptoAlgo block = this.cryptoFactory.getCryptoAlgo();

                if (this.OFD.ShowDialog() == DialogResult.OK)
                {
                    byte[] input = File.ReadAllBytes(this.OFD.FileName);
                    byte[] hash = CryptoLibrary.TigerHash.TigerHashAlgo(input);
                    byte[] output;
                    Thread uploadfileThread = new Thread(() =>
                    {
                        SetText("Encrypting " + this.OFD.FileName);
                        block.encrypth(input, out output);
                        RemvoeText("Encrypting " + this.OFD.FileName);
                        SetText("Uploading " + this.OFD.FileName);
                        this.proxy.createNewFile(this.username, this.password, this.OFD.SafeFileName, hash);
                        uint chunkSize = this.proxy.getChunkSize();

                        for (int i = 0; i < output.Length; i += (int)chunkSize * 1024)
                        {
                            var upperIndex = output.Length - i > chunkSize * 1024 ? (int)chunkSize * 1024 : output.Length - i;
                            byte[] send = new byte[upperIndex];
                            for (var j = 0; j < upperIndex; j++)
                            {
                                send[j] = output[i + j];
                            }
                            this.proxy.uploadData(username, password, this.OFD.SafeFileName, send);
                        }
                        RemvoeText("Uploading " + this.OFD.FileName);
                        this.updateFileList();
                    });

                    uploadfileThread.Start();
                    
                }
            }
            catch (CryptoLibrary.CryptoAlgoErrors err)
            {
                if (err.code == CryptoLibrary.ERROR.NotCompatibleKey)
                {
                    MessageBox.Show("Key is to short");
                }
            }

        }
        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            if (this.statusListBox.InvokeRequired)
            {
                SetTextCallback D = new SetTextCallback(SetText);
                this.Invoke(D, new object[] { text });

            }
            else
            {
                    this.statusListBox.Items.Add(text);
            }
        }
        delegate void RemoveTextCallBack(string text);
        private void RemvoeText(string text)
        {
            if (this.statusListBox.InvokeRequired)
            {
                RemoveTextCallBack D = new RemoveTextCallBack(RemvoeText);
                this.Invoke(D, new object[] { text });

            }
            else
            {
                this.statusListBox.Items.Remove(text);
            }
        }
        private void download_button_Click(object sender, EventArgs e)
        {
            if (this.SFD.ShowDialog() == DialogResult.OK)
            {
                string saveFile = this.SFD.FileName;
                string file = this.file_list.SelectedItem.ToString();
                Thread downloadFileThread = new Thread(() =>
            {
                try
                {
                    CryptoLibrary.CryptoAlgo block = this.cryptoFactory.getCryptoAlgo();
                    byte[] input = new byte[0];
                    //Skidanje sa servera
                    SetText("Downloading " + file);
                    bool done = false;
                    uint offset = 0;
                    uint chunksize = proxy.getChunkSize();
                    while (!done)
                    {
                        downloadFileRequest downloadFileRequest = new downloadFileRequest(username, password, file, offset);
                        downloadFileResponse downloadFileResponse = new downloadFileResponse();
                        downloadFileResponse = proxy.downloadFile(downloadFileRequest);
                        done = downloadFileResponse.downloadFileResult;
                        offset += 1;
                        int asd = input.Length;
                        Array.Resize(ref input, input.Length + downloadFileResponse.data.Length);
                        downloadFileResponse.data.CopyTo(input, asd);
                    }

                    byte[] output;
                    RemvoeText("Downloading " + file);
                    SetText("Decrypthing " + file);
                    block.decrypth(input, out output);
                    RemvoeText("Decrypthing " + file);

                    SetText("Checking hash " + file);
                    byte[] hashFile = CryptoLibrary.TigerHash.TigerHashAlgo(output);
                    byte[] originalHash = proxy.getFileHash(username, password, file);
                    
                    RemvoeText("Checking hash " + file);
                    if (!originalHash.SequenceEqual(hashFile))
                    {
                        MessageBox.Show("Error decoding file!");
                        return;
                    }

                    SetText(" Saving file " + file);
                    using (FileStream stream = new FileStream(saveFile, FileMode.Create))
                    {
                        using (BinaryWriter sw = new BinaryWriter(stream))
                        {
                            sw.Write(output);
                        }
                    }
                    RemvoeText(" Saving file " + file);

                }
                catch (CryptoLibrary.CryptoAlgoErrors err)
                {
                    if (err.code == CryptoLibrary.ERROR.NotCompatibleKey)
                    {
                        MessageBox.Show("Key is to short");
                    }
                }
            });
                downloadFileThread.Start();
            }
        }

        private void cryptoComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cryptoComboBox.SelectedIndex == (int)AlgorithmIndex.RC4)
            {
                setForRC4();
            }
            if (cryptoComboBox.SelectedIndex == (int)AlgorithmIndex.A52)
            {
                setForA52();
            }
            if (cryptoComboBox.SelectedIndex == (int)AlgorithmIndex.CTR)
            {
                setForCTR();
            }
            if (cryptoComboBox.SelectedIndex == (int)AlgorithmIndex.RSA)
            {
                setForRSA();
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            string filename = this.file_list.SelectedItem.ToString();
            this.proxy.deleteFile(username, password, filename);
            this.updateFileList();
        }
    }
}
