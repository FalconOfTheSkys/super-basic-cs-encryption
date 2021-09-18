using System;

namespace Encryption
{
    class Program
    {
        static void Main(string[] args)
        {

            debug();
        }
        
        static void debug()
        {
            Console.WriteLine("Enter text to encrypt:");
            string msg = Console.ReadLine();
            encrypt(msg);
            Console.WriteLine();
            Console.WriteLine("Enter the message above to decrypt it:");
            string encmsg = Console.ReadLine();
            decrypt(encmsg);
            Console.ReadKey();
        }

        static void encrypt(string msg)
        {
            char[] msgchars = msg.ToCharArray();

            for(int i = 0; i < msgchars.Length; i++)
            {
                msgchars[i]++;
                Console.Write(msgchars[i]);
            }
        }

        static void decrypt(string encmsg)
        {
            char[] msgchars = encmsg.ToCharArray();

            for(int i = 0; i<msgchars.Length; i++)
            {
                msgchars[i]--;
                Console.Write(msgchars[i]);
            }
        }
    }
}
