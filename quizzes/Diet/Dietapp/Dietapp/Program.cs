using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dietapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is diet app.");
            string[] file = Util.GetFile();
            List<string> cleandiet = Util.CleanData(file);
            //Util.PrintFile(cleandiet);
            List<food>foodsList = Util.Parsedata(cleandiet);
            
             
        }
    }
}
