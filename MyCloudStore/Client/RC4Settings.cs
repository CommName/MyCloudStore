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
    public partial class RC4Settings : UserControl, CryptoFactory
    {
        public RC4Settings()
        {
            InitializeComponent();
        }

        public CryptoAlgo getCryptoAlgo()
        {
            RC4 algo = new RC4();
            byte[] key = Encoding.ASCII.GetBytes(this.keyTextBox.Text);
            algo.setKey(key);
            return algo;
        }
    }
}
