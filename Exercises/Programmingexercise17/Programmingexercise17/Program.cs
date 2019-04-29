using System;
using System.Collections.Generic;
using System.Text;

namespace Programmingexercise17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reading CSV with embeded commas");
            List<string> myList = new List<string>();
            string input1 = "\"a,b\",c";
            myList.Add(input1);
            string input2 = "\"Obama, Barack\",\"August 4, 1961\",\"Washington, D.C\"";
            myList.Add(input2);
            string input3 = "\"Ft.Benning, Georgia\",32.3632N,84.9493W," +
                "\"Ft.Stewart, Georgia\",31.8691N,81.6090W," +
                "\"Ft.Gordon, Georgia\", 33.4302N, 82.1267W";
            myList.Add(input3);

            foreach (string s in myList)
            {
                Console.WriteLine($"Current input is {s}");
                List<string> output = getCSV(s);
                int len = output.Count;
                Console.WriteLine($"This line has {len} fields. They are:");
                foreach (string s1 in output)
                {
                    Console.WriteLine(s1);
                }
                Console.WriteLine();
            }
        }

        private static List<string> getCSV(string s)
        {
            List<string> theList = new List<string>();
            StringBuilder sb = new StringBuilder();
            char comma = ',';
            char paren = '"';
            int holder = 0;
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == paren || s[i] != paren)
                {
                    for (int j = i; j < s.Length; j++)
                    {
                        //if (s[j] == paren)
                        //{
                        //    continue;
                        //}
                        if (s[j] == paren && count < 1)
                        {
                            count++;
                            continue;
                            //sb.Append(s[j]);
                        }
                        else if (s[j] != paren)
                            sb.Append(s[j]);
                        else if (s[j] == paren && count == 1)
                        {
                            theList.Add(sb.ToString());
                            sb.Clear();
                            holder = j+2;
                            break;
                        }
                    }
                }
                i = holder;
            }
            return theList;
        }
    }
}
