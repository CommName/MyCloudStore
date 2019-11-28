using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CryptoLibrary
{
    class TigerHash
    {
        static public void TigerHashAlgo(BitArray message)
        {
            UInt64 h0 = 0x0123456789ABCDEF;
            UInt64 h1 = 0xFEDCBA9876543210;
            UInt64 h2 = 0xF096A5B4C3D2E187;

            if(message.Length  % 512 != 0)
            {

                var pom = new bool[message.Length + (512 - message.Length % 512)];
                message.CopyTo(pom, 0);
                UInt64 i = (uint)message.Length;
                pom[i++] = true;
                while(i % 512 != 448)
                {
                    pom[i++] = false;
                }
                UInt64 duzina = (uint) message.Length;
                while(i%512 != 0)
                {
                    for (UInt64 j = 7; j >= 0; j--)
                    {
                        pom[i + j] = (duzina & 1) == 1;
                        duzina >>= 1;

                    }
                    i += 8;
                }
                message = new BitArray(pom);
            }

            for(UInt64 chunk = 0; chunk < (uint)message.Length; chunk += 512)
            {
                UInt64 a = h0;
                UInt64 b = h1;
                UInt64 c = h2;

                for(int i = 0; i <= 3; i++)
                {
                    for (int j = 0; j <= 7; j++) {
                        c ^= message[chunk + j * 64];
                    }
                }

                h0 += a;
                h1 += b;
                h2 += c;

            }
        }
    }
}
