using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] input = Encoding.ASCII.GetBytes(this.textBox1.Text);

            
            byte[] output;

            byte[] plainText;

            CryptoLibrary.TigerHash algoritam = new CryptoLibrary.TigerHash();
            
            output =CryptoLibrary.TigerHash.TigerHashAlgo(input);



            this.textBox2.Text = Encoding.ASCII.GetString(output);
        }

        bool[] FromByteToBoolArray(byte[] array)
        {
            bool[] ret = new bool[array.Length * 8];

            for(int j = 0; j < array.Length; j++)
            {
                for(int i =0; i < 8; i++)
                {
                    ret[j * 8 + i] = (array[j] & (1 << i)) == 0 ? false : true;
                }
            }
            return ret;

        }
    }
}
