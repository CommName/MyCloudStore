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
            throw new NotImplementedException();
        }
    }
}
