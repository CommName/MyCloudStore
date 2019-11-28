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

            CryptoLibrary.CryptoAlgo algoritam = new CryptoLibrary.A52();

            algoritam.setKey(Encoding.ASCII.GetBytes("ABCDEFGH123"));

            algoritam.encrypth(input,out output);

            algoritam.setKey(Encoding.ASCII.GetBytes("ABCDEFGH123"));
            algoritam.decrypth(output, out plainText);


            this.textBox2.Text = Encoding.ASCII.GetString(plainText);
        }

        
    }
}
