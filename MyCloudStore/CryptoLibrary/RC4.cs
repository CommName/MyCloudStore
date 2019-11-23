﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoLibrary
{
    public class RC4
    {
        
        protected  byte[] S;
        protected uint i;
        protected uint j;
        public RC4()
        {
            S = new byte[256];
            i = 0;
            j = 0;
        }

        public void inistaliazeKey(byte[] key)
        {
            for(i = 0; i < 256; i++)
            {
                S[i] = i;
            }

            j = 0;
            for(i = 0; i < 256; i++)
            {
                j = (byte) ((j+ S[i] + key[i % key.Length]) % 256);
                this.swap(i, j);
            }
            i = 0;
            j = 0;
        }

        protected byte getNextKeystreamBit()
        {
            this.i = (this.i + 1) % 256;
            this.j = (this.j + this.S[i]) % 256;
            this.swap(i, j);
            return S[(S[i] + S[j]) % 256];
        }

        public void cipher(byte[] plainText, out byte[] cryptoText)
        {
            cryptoText = new byte[plainText.Length];
            for(int index = 0; index < plainText.Length; index++)
            {
                cryptoText[index] = (byte) (plainText[index] ^ this.getNextKeystreamBit());
            }
        }

        protected void swap(uint i , uint j)
        {
            byte pom = S[i];
            S[i] = S[j];
            S[j] = pom;
        }
    }
}