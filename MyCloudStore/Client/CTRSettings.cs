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
    public partial class CTRSettings : UserControl, CryptoFactory
    {
        public CTRSettings()
        {
            InitializeComponent();
            this.ckpComboBox.Items.Add("RC4");
            this.ckpComboBox.Items.Add("A52");
            this.ckpComboBox.SelectedIndex = 0;
            setForRC4();
        }
        protected CryptoFactory cryptoFactory;
        protected void setForRC4()
        {
            this.ckpBox.Controls.Clear();
            var view = new RC4Settings();
            cryptoFactory = view;
            this.ckpBox.Controls.Add(view);
        }

        protected void setForA52()
        {
            this.ckpBox.Controls.Clear();
            var view = new A52Settings();
            cryptoFactory = view;
            this.ckpBox.Controls.Add(view);

        }

        protected void setForCTR()
        {
            this.ckpBox.Controls.Clear();
            var view = new CTRSettings();
            cryptoFactory = view;
            this.ckpBox.Controls.Add(view);

        }


        public CryptoAlgo getCryptoAlgo()
        {
            CryptoAlgo ckb = this.cryptoFactory.getCryptoAlgo();
            throw new NotImplementedException();
        }
    }
}
