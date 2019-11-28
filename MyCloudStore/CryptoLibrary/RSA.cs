using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CryptoLibrary
{
    class RSA
    {
        public uint n { get; set; }
        protected BigInteger e;
        public uint d { get; set; }


        public RSA(uint p, uint q)
        {
            this.generateKeys(p, q);
        }

        void generateKeys(uint p, uint q)
        {
            this.n = p * q;
            uint fi = (p - 1) * (q - 1);

        }

        void setPrivateKey(uint key)
        {
            this.e = key;
        }


        // 341,550,071,728,321
        // a = 2, 3, 5, 7, 11, 13, and 17.
        public static bool miller_rabin_test(uint n, uint k)
        {
            if (n == 2 || n == 3)
            {
                return true;
            }
            if (n < 3 || (n % 2 == 0))
                return false;

            //trazimo r
            uint r = 0;
            uint d = n - 1;

            while(d%2 == 0)
            {
                d /= 2;
                r++;
            }


            return true;
        }
    }
}
