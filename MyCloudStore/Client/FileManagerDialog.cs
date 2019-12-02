using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Client
{
    public partial class FileManagerDialog : UserControl
    {
        public FileManagerDialog()
        {
            InitializeComponent();
            this.cryptoComboBox.Items.Add("RC4");
            this.cryptoComboBox.Items.Add("A52");
            this.cryptoComboBox.Items.Add("CTR");
            this.cryptoComboBox.SelectedIndex = 0;
            setForRC4();
        }
        private enum AlgorithmIndex { 
            RC4=0,
            A52=1,
            CTR=2
        }

        protected CryptoFactory cryptoFactory;

        protected void setForRC4()
        {
            this.cryptoBox.Controls.Clear();
            var view = new RC4Settings();
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
                
                this.OFD.ShowDialog();
                byte[] input = File.ReadAllBytes(this.OFD.FileName);
                byte[] output;
                block.encrypth(input, out output);

                this.SFD.ShowDialog();
                using (FileStream stream = new FileStream(this.SFD.FileName, FileMode.Create))
                {
                    using (BinaryWriter sw = new BinaryWriter(stream))
                    {
                        sw.Write(output);
                    }
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

        private void download_button_Click(object sender, EventArgs e)
        {
            try
            {
                CryptoLibrary.CryptoAlgo block = this.cryptoFactory.getCryptoAlgo();

                this.OFD.ShowDialog();
                byte[] input = File.ReadAllBytes(this.OFD.FileName);
                byte[] output;
                block.encrypth(input, out output);

                this.SFD.ShowDialog();
                using (FileStream stream = new FileStream(this.SFD.FileName, FileMode.Create))
                {
                    using (BinaryWriter sw = new BinaryWriter(stream))
                    {
                        sw.Write(output);
                    }
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
        }
    }
}
