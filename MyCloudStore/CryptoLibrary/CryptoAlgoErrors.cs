using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoLibrary
{
    public enum ERROR
    {
        NotCompatibleKey
    }
    public class CryptoAlgoErrors : SystemException
    {
        public ERROR code;

        public CryptoAlgoErrors(ERROR er)
        {
            this.code = er;
        }
    }
}
