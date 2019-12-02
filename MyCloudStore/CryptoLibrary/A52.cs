using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CryptoLibrary
{
    public class A52 : CryptoAlgo
    {
        protected bool[] R1 = new bool[19];
        protected bool[] R2 = new bool[22];
        protected bool[] R3 = new bool[23];
        protected bool[] R4 = new bool[17];

        protected bool[] keyStream = new bool[228];

        void ShiftRightRegisterR1()
        {
            bool last = R1[R1.Length - 1];
            for(var i =R1.Length-1; i> 0; i--)
            {
                R1[i] = R1[i - 1];
            }
            R1[0] = R1[17] ^ R1[16] ^ R1[13];
        
        }
        void ShiftRightRegisterR2()
        {
            bool last = R2[R2.Length - 1];
            for (var i = R2.Length - 1; i > 0; i--)
            {
                R2[i] = R2[i - 1];
            }
            R2[0] = R2[21] ^ R2[20];
        }
        void ShiftRightRegisterR3()
        {
            bool last = R3[R3.Length - 1];
            for (var i = R3.Length - 1; i > 0; i--)
            {
                R3[i] = R3[i - 1];
            }
            R3[0] = R3[22] ^ R3[21] ^R3[20];
        }
        void ShiftRightRegisterR4()
        {
            bool last = R4[R4.Length - 1];
            for (var i = R4.Length - 1; i > 0; i--)
            {
                R4[i] = R4[i - 1];
            }
            R4[0] = R4[16] ^ R4[11];
        }

        public void setKey(bool[] Kc,bool[] f)
        {
            if(Kc.Length<64 || f.Length< 24)
            {
                throw new CryptoAlgoErrors(ERROR.NotCompatibleKey);
            }

            for (var i = 0; i < R1.Length; i++)
                R1[i] = false;

            for (var i = 0; i < R2.Length; i++)
                R2[i] = false;

            for (var i = 0; i < R3.Length; i++)
                R3[i] = false;

            for (var i = 0; i < R4.Length; i++)
                R4[i] = false;


            for(var i = 0; i < 64; i++)
            {
                ShiftRightRegisterR1();
                ShiftRightRegisterR2();
                ShiftRightRegisterR3();
                ShiftRightRegisterR4();

                R1[0] = R1[0] ^ Kc[i];
                R2[0] = R2[0] ^ Kc[i];
                R3[0] = R3[0] ^ Kc[i];
                R4[0] = R4[0] ^ Kc[i];

            }

            for(var i=0; i<24; i++)
            {
                R1[0] = R1[0] ^ f[i];
                R2[0] = R2[0] ^ f[i];
                R3[0] = R3[0] ^ f[i];
                R4[0] = R4[0] ^ f[i];
            }

            R1[15] = true;
            R2[16] = true;
            R3[18] = true;
            R4[10] = true;
        }
        bool maj(bool a , bool b, bool c)
        {
            return (a && b) ^ (b && c) ^ (c&&a);
            //return (R4[3] && R4[7]) || (R4[3] && R4[7]) || (R4[10] && R4[7]);
        }

        void tactRegisters()
        {
            bool majority = maj(R4[3],R4[7],R4[10]);

            if (R4[10] == majority)
            {
                ShiftRightRegisterR1();
            }
            
            if (R4[3] == majority)
            {
                ShiftRightRegisterR2();
            }

            if (R4[7] == majority)
            {
                ShiftRightRegisterR3();
            }
            ShiftRightRegisterR4();
        }

        void generateKeyStream()
        {
            for(var i = 0; i < 99; i++)
            {
                this.tactRegisters();
            }
            for (var i = 0; i < 228; i++)
            {
                this.tactRegisters();
                keyStream[i] = maj(R1[12], R1[14], R1[15]) ^ maj(R2[9], R2[13], R2[16]) ^ maj(R3[13], R3[16], R3[18]);
            }
        }

        public void encrypt(byte[] plainText ,out byte[] cryptedText)
        {
            BitArray plain = new BitArray(plainText);

            BitArray keys = new BitArray(plain.Length);

            //Generisanje keystream-a

            var brojRundi = plain.Length / 114;
            var i = 0;
            while (i * 114 < keys.Length) 
            {
                this.generateKeyStream();
                for (var j = 0; j < 114; j++)
                {
                    if (i * 114 + j >= keys.Length)
                        break;

                    keys.Set(i * 114 + j, this.keyStream[j]);
                }
                i++;
            }

            plain.Xor(keys);
            cryptedText = new byte[plainText.Length];
            plain.CopyTo(cryptedText, 0);

        }

        public void setKey(byte[] key)
        {
            bool[] keystream = BitByteManipulation.FromByteToBoolArray(key);

            bool[] k = new bool[64];
            bool[] f = new bool[24];

            for (int i = 0; i < 64; i++)
                k[i] = keystream[i];

            for (int i = 0; i < 24; i++)
                f[i] = keystream[i + 64];

            this.setKey(k, f);
        }

        public void encrypth(byte[] plainText, out byte[] encryptedText)
        {
            this.encrypt(plainText,out encryptedText);
        }

        public void decrypth(byte[] encryptedText, out byte[] decryptedText)
        {
            this.encrypt(encryptedText, out decryptedText);
        }
    }

    
}
