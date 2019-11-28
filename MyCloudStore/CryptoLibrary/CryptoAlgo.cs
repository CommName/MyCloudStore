using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoLibrary
{
    public interface CryptoAlgo
    {
        void setKey(byte[] key);
        void encrypth(byte[] plainText, out byte[] encryptedText);
        void decrypth(byte[] encryptedText, out byte[] decryptedText);

    }
}
