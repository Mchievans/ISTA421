using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using CsvHelper;

namespace Dietapp
{
     public class Util
    {
        public static string[] GetFile()
        {
            string[] lines = File.ReadAllLines(@"..\..\..\..\diet.csv");
            return lines; 
        }

        public static void PrintFile(List<string> file)
        {
            foreach(string word in file)
            {
                Console.WriteLine(word);
            }
        }

        public static List<food> Parsedata(List<string> cleandiet)
        {
            List<food> foodlist = new List<food>();
            foreach(string s in cleandiet)
            {
                
                Console.WriteLine(s);   
            }
            return foodlist;
        }

        public static List<string> CleanData(string[] file)
        {
            Regex skipone = new Regex(@"^Food");
            Regex skipcomma = new Regex(@",,");
            Regex replacedollarsym = new Regex(@",\$");       
            List<string> cleandata = new List<string>();
            for(int i = 0;i < file.Length;i++)
            {
                if(skipone.IsMatch(file[i]))
                    continue;
                else if(skipcomma.IsMatch(file[i]))
                    continue; 
                cleandata.Add(file[i]);
            }
            return cleandata;
        }
    }
}
