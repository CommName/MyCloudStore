using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.ServiceReference1;
using CryptoLibrary;
using System.ServiceModel;

namespace Client
{
    public partial class Login : UserControl
    {
        public Delegate login;
        public delegate string passwordHash (string s);
        public CloudServiceClient proxy;

        public passwordHash PasswordHash;

        public string Username
        {
            get { return this.username_text_box.Text; }
            set { this.username_text_box.Text = value; }
        }

        public string Password
        {
            get { return this.password_text_box.Text; }
            set { this.password_text_box.Text = value; }
        }


        public Login(CloudServiceClient proxy)
        {
            InitializeComponent();
            this.PasswordHash = noHash;
            this.proxy = proxy;
        }

        public static string noHash(string s)
        {
            return s;
        }
        
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            login.DynamicInvoke(this.username_text_box.Text, PasswordHash(this.password_text_box.Text));
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {

            this.proxy.RegisterUser(this.username_text_box.Text, TigerHash.TigerHashAlgo(Encoding.ASCII.GetBytes(this.password_text_box.Text)));
            }
            catch(FaultException<ErrorMessages> er)
            {
                MessageBox.Show(er.Detail.Message);
            }
        }
    }
}
