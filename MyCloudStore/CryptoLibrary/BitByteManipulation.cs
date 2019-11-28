using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoLibrary
{
    public class BitByteManipulation
    {
        public static bool[] FromByteToBoolArray(byte[] array)
        {
            bool[] ret = new bool[array.Length * 8];

            for (int j = 0; j < array.Length; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    ret[j * 8 + i] = (array[j] & (1 << i)) == 0 ? false : true;
                }
            }
            return ret;

        }
    }
}
