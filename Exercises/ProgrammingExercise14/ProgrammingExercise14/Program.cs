using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingExercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            string plain_text = Util.GetPlainText();
            string single_key = Util.GetSingleKey();
            String multi_key = Util.GetMultKey();
            Console.WriteLine();

            Console.WriteLine($"you have entered [{plain_text}] as your plain text.");
            Console.WriteLine($"you have entered [{single_key}] as your single key.");
            Console.WriteLine($"you have enetred [{multi_key}] as your multi key");
            Console.WriteLine();

            int[] clean_text = Util.Clean(plain_text);
            int[] clean_skey = Util.Clean(single_key);
            int[] clean_mkey = Util.Clean(multi_key);

            string enc_single = Util.SingleEnc(clean_text, clean_skey);
            string enc_multi = Util.MultiEnc(clean_text, clean_mkey);
            string enc_conti = Util.ContiEnc(clean_text, clean_mkey);

            Console.WriteLine($"Encryted message with single key is [{enc_single}]");
            Console.WriteLine($"Encryted message with multi key is [{enc_multi}]");
            Console.WriteLine($"Encryted message with continous key is [{enc_conti}]");
            Console.WriteLine( );


            string dec_single = Util.SingleDec(enc_single, clean_skey);
            string dec_multi = Util.MultiDec(enc_multi, clean_mkey);
            string dec_conti = Util.ContiDec(enc_multi, clean_mkey);

            Console.WriteLine($"Decryted message with single key is [{dec_single}]");
            Console.WriteLine($"Decryted message with multi key is [{dec_multi}]");
            Console.WriteLine($"Decryted message with continous key is [{dec_conti}]");

        }
    }
}
