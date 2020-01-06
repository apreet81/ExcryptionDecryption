using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcryptionDecryption.Helper;

namespace ExcryptionDecryption
{
    class Program
    {
        static void Main(string[] args)
        {
            //CryptoGraphy cryptoGraphy = new CryptoGraphy();
            Console.WriteLine("Enter Text...");
            string text = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Text after Encrytion");
            string encryptedText = string.Empty;
            encryptedText = CryptoGraphy.Encrypt(text);
            Console.WriteLine(encryptedText);
            string decryptedText = CryptoGraphy.Decrypt(encryptedText);
            Console.WriteLine("Text After Decryption..");
            Console.WriteLine(decryptedText);
            Console.Read();
        }
    }
}
