using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoLibrary
{
    public class CTR : CryptoAlgo
    {
        protected byte[] key;
        protected UInt64 counter;
        protected byte[] Nonce;
        protected CryptoAlgo blockCipherEncryption;


        public CTR(byte[] IV, CryptoAlgo bce, byte[] key)
        {
            this.Nonce = IV;
            this.blockCipherEncryption = bce;
            this.key = key;
        }

        protected void encrypthBlock(byte[] input, out byte[] output)
        {
            output = new byte[input.Length];
            byte[] IV = new byte[16];
            Nonce.CopyTo(IV, 0);
            BitConverter.GetBytes(counter).CopyTo(IV, 8);
            blockCipherEncryption.setKey(key);

            byte[] encKey;
            blockCipherEncryption.encrypth(IV, out encKey);

            for(int i = 0; i < input.Length; i++)
            {
                output[i] = (byte)((int)(encKey[i]) ^ (int)(input[i]));
            }
            counter++;

        }

        protected void enc_dec(byte[] intput, out byte[] output)
        {
            output = new byte[intput.Length];

            for(int i =0;i< intput.Length; i += 16)
            {

                byte[] block;
                int length;
                if (i + 16 < intput.Length)
                {
                    length = 16;
                }
                else
                {
                    length = intput.Length - i;
                }
                block = new byte[length];
                for (int j = 0; j < length; j++)
                {
                    block[j] = intput[i + j];
                }

                byte[] outblock;
                this.encrypthBlock(block, out outblock);

                for(int j =0; j< length; j++)
                {
                    output[i + j] = outblock[j];
                }

            }

        }

        public void decrypth(byte[] encryptedText, out byte[] decryptedText)
        {
            this.counter = 0;
            enc_dec(encryptedText, out decryptedText);
        }

        public void encrypth(byte[] plainText, out byte[] encryptedText)
        {
            this.counter = 0;
            enc_dec(plainText, out encryptedText);
        }

        public void setKey(byte[] key)
        {
            this.key = key;
        }
    }
}
