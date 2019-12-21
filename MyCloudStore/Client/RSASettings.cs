using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptoLibrary;

namespace Client
{
    public partial class RSASettings : UserControl, CryptoFactory
    {
        public RSASettings()
        {
            InitializeComponent();
        }

        public CryptoAlgo getCryptoAlgo()
        {
            RSA rsa = new RSA();
            if (radioButton1.Checked)
            {
                rsa.genereateKey((int)this.p.Value, (int)this.q.Value);
                this.e.Value = rsa.e;
                this.d.Value = rsa.d;
                this.n.Value = rsa.n;
            }
            else
            {
                rsa.e = (int)this.e.Value;
                rsa.d = (int)this.d.Value;
                rsa.n = (int)this.n.Value;
            }

            return rsa;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                p.Enabled = true;
                q.Enabled = true;
                this.e.Enabled = false;
                this.d.Enabled = false;
                this.n.Enabled = false;
            }
            else
            {
                p.Enabled = false;
                q.Enabled = false;
                this.e.Enabled = true;
                this.d.Enabled = true;
                this.n.Enabled = true;
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (!radioButton2.Checked)
            {
                p.Enabled = true;
                q.Enabled = true;
                this.e.Enabled = false;
                this.d.Enabled = false;
                this.n.Enabled = false;
            }
            else
            {
                p.Enabled = false;
                q.Enabled = false;
                this.e.Enabled = true;
                this.d.Enabled = true;
                this.n.Enabled = true;
            }
        }


    }
}
