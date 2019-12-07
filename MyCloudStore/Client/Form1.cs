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


        private void loginFun(string username, string password)
        {
            byte[] hashPassword = CryptoLibrary.TigerHash.TigerHashAlgo(Encoding.ASCII.GetBytes(password));
            try
            {
                List<string> fileNames = proxy.getYourFileNames(username, hashPassword);
                this.Controls.Clear();
                var fmd = new FileManagerDialog(username, hashPassword, proxy, fileNames);
                this.Width = 540;
                this.Height = 370;
                fmd.Anchor = AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Right;
                this.Controls.Add(fmd);
            }
            catch(FaultException<ErrorMessages> e)
            {
                MessageBox.Show(e.Detail.Message);
                proxy.RegisterUser(username, hashPassword);
                this.loginFun(username, password);
            }
        }
    }
}
