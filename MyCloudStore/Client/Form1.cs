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
namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.loginEvent += new loginDelegate(loginFun);
            InitializeComponent();
            this.setLoginView();
        }

        public delegate void loginDelegate(string username, string password);
        private event loginDelegate loginEvent;


        private void setLoginView()
        {
            this.Controls.Clear();

            var login = new Login();
            this.Width = 240;
            this.Height = 180;
            login.Anchor = AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top  | AnchorStyles.Right;
            login.login = this.loginEvent;
            this.Controls.Add(login);

        }

        private void loginFun(string username, string password)
        {
            this.Controls.Clear();
            var fmd = new FileManagerDialog();
            this.Width = 300;
            this.Height = 370;
            fmd.Anchor = AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Right;
            this.Controls.Add(fmd);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.OFD.ShowDialog();
            byte[] input = File.ReadAllBytes(this.OFD.FileName);



            byte[] output;

            byte[] plainText;

            CryptoLibrary.CryptoAlgo algoritam = new CryptoLibrary.A52();

            algoritam.setKey(Encoding.ASCII.GetBytes("ABCDEFGH123"));

            CryptoLibrary.CryptoAlgo block = new CryptoLibrary.CTR(Encoding.ASCII.GetBytes("ABCDEFGH"), algoritam, Encoding.ASCII.GetBytes("ABCDEFGH123"));

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
