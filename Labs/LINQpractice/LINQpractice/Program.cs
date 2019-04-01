using System;
using System.Linq;

namespace LINQpractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print out top # values
            int[] array1 = new int[] { 5,13,4,21,2,6,9,50 };
            Console.WriteLine("Enter # of top values to display:");
            string n = Console.ReadLine();
            int topValues = int.Parse(n);
            var queue = from a in array1
                        orderby a descending
                        select a;

            Console.WriteLine($"The top {topValues} values are:");

            foreach(int i in queue.Take(topValues))
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //Print out only upper case letters
            string name = "My name is MALACHI EVANS";
            string[] splitter = name.Split(' ');
            //foreach(string letter in splitter)
            //{
            //    Console.WriteLine($"{letter}");
              
            //}
            var query = from word in splitter
                        where string.Equals(word,word.ToUpper())
                        select word;
            foreach(var m in query)
            {
                Console.WriteLine($"{m}");
            }

            //var capitals = from l in name
            //               where l > 64 && l < 91
            //               select l;
            //foreach(char s in capitals)
            //    Console.Write($"{s} ");


            //Given arrbitrary string count and report number of charcters used by type. 
            Console.WriteLine("Enter a character  the character entered will be deleted from the string.");
              string roosevelt =("It is not the critic who counts " +
                  "not the man who points out how the strong man stumbles, or where the doer of deeds could have done them better." +
                  "The credit belongs to the man who is actually in the arena, whose face is marred by dust " +
                  "and sweat and blood who strives valiantly who errs, who comes short again and again," +
                  " because there is no effort without error and shortcoming but who does actually strive to do" +
                  " the deeds who knows great enthusiasms, the great devotions" +
                  " who spends himself in a worthy cause who at the best knows in the end " +
                  "the triumph of high achievement, and who at the worst," +
                  " if he fails, at least fails while daring greatly, " +
                  "so that his place shall never be with those cold " +
                  "and timid souls who neither know victory nor defeat.");
            //char[] arrayvelt = roosevelt.ToArray();
            string character = Console.ReadLine();
            char letter = character[0];
            //characterChar= character.ToCharArray
            var deletequerry = from words in roosevelt
                               where (char.Equals(words,letter) != true)
                               select words;
            foreach(var words in deletequerry)
            {
                Console.Write(words);
            }
        }
    }
}
