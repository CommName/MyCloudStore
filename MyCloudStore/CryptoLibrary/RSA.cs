using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Security.Cryptography;

namespace CryptoLibrary
{
    public class RSA : CryptoAlgo
    {

        public RSA()
        {

        }

        public static bool isPrime(int number)
        {
            int sqrNumber =(int)Math.Sqrt(number);

            for(var i = 2;i < sqrNumber; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        public int n { get; set; }
        public int e { get; set; }
        public int d { get; set; }

        static int __gcd(int a, int b)
        {
            // Everything divides 0 
            if (a == 0 || b == 0)
                return 0;

            // base case 
            if (a == b)
                return a;

            // a is greater 
            if (a > b)
                return __gcd(a - b, b);

            return __gcd(a, b - a);
        }

        static int modInverse(int a, int m)
        {
            a = a % m;
            for (int x = 1; x < m; x++)
                if ((a * x) % m == 1)
                    return x;
            return 1;
        }

        public void genereateKey(int p, int q)
        {
            if (!isPrime(p) || !isPrime(q))
            {
                throw new Exception("P and Q have to be prime numbers");
            }
            n = p * q;

            int fn = (p - 1) * (q - 1);

            Random gen = new Random();

            e = gen.Next(1,fn);

            while ((__gcd(e,fn)==1) && (e<fn))
            {
                e++;
            }
            if(e>= fn)
            {
                throw new Exception("Unable to generate public key");
            }

            d = modInverse(e, fn);
        }

        public BigInteger Encrypth(BigInteger m)
        {
            return BigInteger.ModPow(m, e, n);
        }

        public byte Decrypth(BigInteger m)
        {
            byte[] ret =  BigInteger.ModPow(m, d, n).ToByteArray();
            return ret[0];
        }


        public void Encrypth(byte[] intput, out byte[] output)
        {
            var length = intput.Length;

            var result = new BigInteger[length];

            for (var i = 0; i < length; i++)
            {
                byte[] broj = new byte[1];
                broj[0] = intput[i];
                result[i] = Encrypth(new BigInteger(broj));
            }

            var sb = new StringBuilder();
            for (var i = 0; i < result.Length; i++)
            {
                sb.Append(result[i].ToString());
                if (i != result.Length - 1)
                    sb.Append(" ");
            }

            output = Encoding.ASCII.GetBytes(sb.ToString());
        }

        public void Decrypth(byte[] input, out byte[] output)
        {
            var stringOutput = Encoding.ASCII.GetString(input).Split(' ');

            BigInteger[] bigIntegersArray = new BigInteger[stringOutput.Length];
            
            for(int i =0; i< stringOutput.Length; i++)
            {
                bigIntegersArray[i] = BigInteger.Parse(stringOutput[i]);
            }
            
            output = new byte[bigIntegersArray.Length];

            for (var i = 0; i < bigIntegersArray.Length; i++)
            {
                output[i] = Decrypth(bigIntegersArray[i]);
            }

        }

        public void setKey(byte[] key)
        {
            throw new NotImplementedException();
        }

        public void encrypth(byte[] plainText, out byte[] encryptedText)
        {
            this.Encrypth(plainText, out encryptedText);
        }

        public void decrypth(byte[] encryptedText, out byte[] decryptedText)
        {
            this.Decrypth(encryptedText, out decryptedText);
        }

        public CryptoAlgo getCopy()
        {
            throw new NotImplementedException();
        }
    }
}
