using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingExercise14
{
    public class Util
    {
        internal static string GetPlainText()
        {
            Console.Write("Enter your plain text message: ");
            string txt = Console.ReadLine();
            return txt;
        }

        internal static string GetSingleKey()
        {
            Console.Write("Enter your single key as an alpha character: ");
            string txt = Console.ReadLine();
            //int inttxt = int.Parse(txt);
            //if (inttxt <= 64 || inttxt >= 123)
            /* LATER PLACE TRY CATCH OR SOME FORM OF EXCEPTION HANDLING HERE TO 
 CATCH THE CASE OF A VALUE HIGHER OR LOWER THAN A Letter value*/
            //try
            //{

            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            return txt;
        }

        internal static string GetMultKey()
        {
            Console.Write("Enter your multi key: ");
            string txt = Console.ReadLine();
            return txt;
        }

        public static int[] Clean(string plain_text)
        {
            plain_text = plain_text.ToUpper();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < plain_text.Length; i++)
            {
                if (plain_text[i] >= 65 && 90 >= plain_text[i])
                    sb.Append(plain_text[i]);
            }
            plain_text = sb.ToString();
            int[] holder = new int[plain_text.Length];
            for (int i = 0; i < plain_text.Length; i++)
            {
                holder[i] = plain_text[i];
            }
            return holder;
        }

        public static string SingleEnc(int[] clean_text, int[] clean_skey)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < clean_text.Length; i++)
            {
                int j = clean_text[i] - 64;
                int k = clean_skey[0] - 64;
                if (j + k > 26)
                {
                    int mod = 26 % k;
                    j = j - mod;
                    j += 64;
                    char m = Convert.ToChar(j);
                    sb.Append(m);
                }
                else
                {
                    j = j + k;
                    j += 64;
                    char m = Convert.ToChar(j);
                    sb.Append(m);
                }
            }
            return sb.ToString();
        }

        internal static string MultiEnc(int[] clean_text, int[] clean_mkey)
        {
            StringBuilder sb = new StringBuilder();
            int h = 0;
            for (int i = 0; i < clean_text.Length; i++)
            {
                int j = clean_text[i] - 64;
                int k = clean_mkey[h % clean_mkey.Length] - 64;
                if (j + k > 26)
                {
                    int mod = 26 % k;
                    j = j - mod;
                    j += 64;
                    char m = Convert.ToChar(j);
                    sb.Append(m);
                }
                else
                {
                    j = j + k;
                    j += 64;
                    char m = Convert.ToChar(j);
                    sb.Append(m);
                }
               h++;
            }
            return sb.ToString();
        }

        internal static string ContiEnc(int[] clean_text, int[] clean_mkey)
        {
            StringBuilder sb = new StringBuilder();
            int h = 0;
            int l = 0;
            for (int i = 0; i < clean_text.Length; i++)
            {
                int j = clean_text[i] - 64;
                if (h < clean_mkey.Length)
                {
                    int k = clean_mkey[h % clean_mkey.Length] - 64;
                    if (j + k > 26)
                    {
                        int mod = 26 % k;
                        j = j - mod;
                        j += 64;
                        char m = Convert.ToChar(j);
                        sb.Append(m);
                    }
                    else
                    {
                        j = j + k;
                        j += 64;
                        char m = Convert.ToChar(j);
                        sb.Append(m);
                    }
                }
                else
                {
                    int k = clean_text[l % clean_text.Length] - 64;
                    if (j + k > 26)
                    {
                        int mod = 26 % k;
                        j = j - mod;
                        j += 64;
                        char m = Convert.ToChar(j);
                        sb.Append(m);
                    }
                    else
                    {
                        j = j + k;
                        j += 64;
                        char m = Convert.ToChar(j);
                        sb.Append(m);
                    }
                    l++;
                }
                h++;
               
            }
            return sb.ToString();
        }

        internal static string SingleDec(string enc_single, int[] clean_skey)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < enc_single.Length; i++)
            {
                int j = enc_single[i] - 64;
                int k = clean_skey[0] - 64;
                {
                    j = j - k;
                    j += 64;
                    char m = Convert.ToChar(j);
                    sb.Append(m);
                }
            }
            return sb.ToString();
        }

        internal static string MultiDec(string enc_multi, int[] clean_mkey)
        {
            StringBuilder sb = new StringBuilder();
            int h = 0;
            for (int i = 0; i < enc_multi.Length; i++)
            {
                int j = enc_multi[i] - 64;
                int k = clean_mkey[h % clean_mkey.Length] - 64;
                //if (j + k > 26)
                //{
                //    int mod = 26 % k;
                //    j = j + mod;
                //    j += 64;
                //    char m = Convert.ToChar(j);
                //    sb.Append(m);
                //}
                //else
                {
                    j = j - k;
                    j += 64;
                    char m = Convert.ToChar(j);
                    sb.Append(m);
                }
                h++;
            }
            return sb.ToString();
        }

        internal static string ContiDec(string enc_conti, int[] clean_mkey)
        {
            StringBuilder sb = new StringBuilder();
            int h = 0;
            int l = 0;
            for (int i = 0; i < enc_conti.Length; i++)
            {
                int j = enc_conti[i] - 64;
                if (h < clean_mkey.Length)
                {
                    int k = clean_mkey[h % clean_mkey.Length] - 64;
                    //if (j + k > 26)
                    //{
                    //    int mod = 26 % k;
                    //    j = j + mod;
                    //    j += 64;
                    //    char m = Convert.ToChar(j);
                    //    sb.Append(m);
                    //}
                    //else
                    {
                        j = j - k;
                        j += 64;
                        char m = Convert.ToChar(j);
                        sb.Append(m);
                    }
                }
                else
                {
                    int k = enc_conti[l % enc_conti.Length] - 64;
                    //if (j + k > 26)
                    //{
                    //    int mod = 26 % k;
                    //    j = j + mod;
                    //    j += 64;
                    //    char m = Convert.ToChar(j);
                    //    sb.Append(m);
                    //}
                    //else
                    {
                        j = j + k;
                        j += 64;
                        char m = Convert.ToChar(j);
                        sb.Append(m);
                    }
                    l++;
                }
                h++;

            }
            return sb.ToString();
        }
    }
}
