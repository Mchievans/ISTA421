using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProgrammingExercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Password Cracker: Please enter a (1-4 characters) password");

            string stringalpha = Console.ReadLine();
            Stopwatch timex = new Stopwatch();

            //timex.Start();
            //int[] randarray = GenRandomArray(stringalpha);
            //string password = CheckArray(randarray, stringalpha);
            //timex.Stop();
            //double time = timex.Elapsed.TotalSeconds;
            //Console.WriteLine(password + " Time ellapsed:" + time);
            //Console.WriteLine();


            Console.WriteLine();
            timex.Start();
            List<int> randlist = GenRandomList(stringalpha);
            string password2 = CheckList(randlist, stringalpha);
            timex.Stop();
            double time2 = timex.Elapsed.TotalSeconds;
            Console.WriteLine(password2 + " Time ellapsed:" + time2);
            Console.WriteLine();


            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;

            Action<object> action = (object obj) =>
            {
                timex.Start();
                List<int> randlistcopy = GenRandomList(stringalpha);
                string password3 = CheckList(randlistcopy, stringalpha);              
                timex.Stop();
                double time3 = timex.Elapsed.TotalSeconds;
                Console.WriteLine(password3 + " Time ellapsed:" + time3);
            };

            bool check = true;
            while (true == check)
            {
                Task t1 = Task.Factory.StartNew(action, "alpha", token);
                Task t2 = Task.Factory.StartNew(action, "beta", token);

                try
                {
                    t1.Wait();
                    Console.WriteLine();
                    t2.Wait();
                    Console.WriteLine();

                    bool completed1 = t1.IsCompleted;
                    bool completed2 = t2.IsCompleted;

                    if (completed1 == true || completed2 == true )
                    {
                        Console.WriteLine("Timed out before task completed.");
                        cancellationTokenSource.Cancel();
                        check = false;
                    }
                }
                catch (AggregateException)
                {
                    Console.WriteLine("Exception in task.");
                }
            }
        }

        private static string CheckList(List<int> randList, string stringalpha)
        {
            int increment = 0;
            int len = stringalpha.Length;
            StringBuilder sb = new StringBuilder();
            string password;
            List<int> stringlist = new List<int>();
            char[] stringarr = stringalpha.ToArray();
            foreach (var item in stringarr)
            {
                stringlist.Add(item);
            }          

            do
            {
                bool equal = stringlist.SequenceEqual(randList);
                if (equal == true)
                {
                    break;
                }
                else
                {
                    randList = GenRandomList(stringalpha);                    
                }
            }
            while (increment != len);

            foreach (var item in randList)
            {
                sb.Append((char)item);
            }
            password = sb.ToString();
            return password;
        }


        private static List<int> GenRandomList(string stringalpha)
        {
            Random rand = new Random();
            List<int> randlist = new List<int>();
            int len = stringalpha.Length;            
            for (int i = 0; i < len; i++)
            {
                randlist.Add(rand.Next(33, 126));
            }
            return randlist;
        }

        private static string CheckArray(int[] randarray, string stringalpha)
        {
            int increment = 0;
            int len = stringalpha.Length;
            StringBuilder sb = new StringBuilder();
            string password;       

            while (increment != len)
            {
                for (int i = 0, j = i; i < len; i++, j++)
                {
                    if ((int)stringalpha[i] == randarray[j])
                    {
                        increment++;
                    }
                    else
                    {
                        randarray = GenRandomArray(stringalpha);
                        break;
                    }

                }
            }

            for (int i = 0; i < len; i++)
            {
                sb.Append(Convert.ToChar(randarray[i]));
            }
            return password = sb.ToString();
        }

        private static int[] GenRandomArray(string stringalpha)
        {
            Random rand = new Random();
            int len = stringalpha.Length;
            int[] a = new int[len];
            for (int i = 0; i < len; i++)
            {
                a[i] = rand.Next(33, 126);
            }
            return a;
        }
    }
}
