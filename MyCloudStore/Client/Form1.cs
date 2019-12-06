using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Client.ServiceReference1;
using System.ServiceModel;

namespace Client
{
    public partial class Form1 : Form
    {

        Login login;
        CloudServiceClient proxy;
        public Form1()
        {
            proxy = new CloudServiceClient();
            this.loginEvent += new loginDelegate(loginFun);
            InitializeComponent();
            this.setLoginView();
        }

        public delegate void loginDelegate(string username, string password);
        private event loginDelegate loginEvent;


        private void setLoginView()
        {
            this.Controls.Clear();

            login = new Login();
            this.Width = 240;
            this.Height = 180;
            login.Anchor = AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top  | AnchorStyles.Right;
            login.login = this.loginEvent;
            this.Controls.Add(login);

        }

        private void  dbTest(string username, string password)
        {
            var povratna = proxy.getYourFileNames(username, password);

            login.Username = povratna.First();
        }

        private void loginFun(string username, string password)
        {
            try
            {
                List<string> fileNames = proxy.getYourFileNames(username, password);
                this.Controls.Clear();
                var fmd = new FileManagerDialog();
                this.Width = 540;
                this.Height = 370;
                fmd.Anchor = AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Right;
                this.Controls.Add(fmd);
            }
            catch(FaultException<ErrorMessages> e)
            {
                MessageBox.Show(e.Detail.Message);
                proxy.RegisterUser(username, password);
                this.loginFun(username, password);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.OFD.ShowDialog();
            byte[] input = File.ReadAllBytes(this.OFD.FileName);



            byte[] output;

            byte[] plainText;

            CryptoLibrary.CryptoAlgo algoritam = new CryptoLibrary.A52();

            algoritam.setKey(Encoding.ASCII.GetBytes("ABCDEFGH123"));

            CryptoLibrary.CryptoAlgo block = new CryptoLibrary.CTR(Encoding.ASCII.GetBytes("ABCDEFGH"), algoritam);

            block.encrypth(input, out output);
            this.SFD.ShowDialog();
            using (FileStream stream = new FileStream(this.SFD.FileName, FileMode.Create)) {
                using (BinaryWriter sw = new BinaryWriter(stream))
                {
                    sw.Write(output);
                }
            }
            //block.decrypth(output, out plainText);


            //this.textBox2.Text = Encoding.ASCII.GetString(plainText);
        }

        
    }
}
