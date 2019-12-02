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
    public partial class A52Settings : UserControl, CryptoFactory
    {
        public A52Settings()
        {
            InitializeComponent();
        }

        public CryptoAlgo getCryptoAlgo()
        {
            A52 ret = new A52();
            if (this.manSet.Checked)
            {
                ret.setKey(BitByteManipulation.FromByteToBoolArray(Encoding.ASCII.GetBytes(this.KcTextBox.Text)), BitByteManipulation.FromByteToBoolArray(Encoding.ASCII.GetBytes(this.fTextBox.Text)));
            }
            else
            {
                ret.setKey(Encoding.ASCII.GetBytes(this.keyTextBox.Text));
            }

            return ret;
        }
    }
}
