using System;
using System.Linq;

namespace ProgrammingExercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Print all even numbers
            int[] n1 = new int[] { 0,1,2,3,4,5,6,7,8,9,10 };
            var query = from n in n1
                        where (n % 2) == 0
                        select n;
            Console.WriteLine("These are even numbers ");
            foreach(int n in query)
            {
                Console.Write(n);
            }
            Console.WriteLine();

            //2.Print the postive numbers in a list greater than 0 and less than 12.
            int[] n2 = new int[] { 1,3,-2,-4,-7,-3,-8,12,19,6,9,10,14 };
            var query2 = from n in n2
                         where (n > 0) && (n < 12)
                         select n;
            Console.WriteLine("These are numbers greater than 0 and less than 12 ");
            foreach(int n in query2)
            {
                Console.Write(n);
            }
            Console.WriteLine();

            //3. Print the squares over 20
            var arr1 = new[] { 3,9,2,8,6,5 };

            var query3 = from n in arr1
                         where (n * n >= 25)
                         select n;

            foreach(int n in query3)
            {
                int i = n * n;
                Console.Write($"number = + {n}, SqrNo =  + {i}");
                Console.WriteLine();
            }
            Console.WriteLine();

            //4. Print the amount of times a digit appears in the list
            int[] arr2 = new int[] { 5,9,1,2,3,7,5,6,7,3,7,6,8,5,4,9,6,2 };
            var query4 = from numbs in arr2
                         group numbs by numbs into enumbs
                         //orderby enumbs.Key
                         select enumbs;
            foreach(var numbs in query4)
            {
                Console.WriteLine($"Number {numbs.Key} appears {numbs.Count()} times.");
            }
            Console.WriteLine();

            //5.Count the number of seperate characters in a string
            string m = "Hello, I am a string. How do you like me?";
            var query5 = from letters in m
                         group letters by letters into lettergroup
                         //orderby enumbs.Key
                         select lettergroup;
            foreach(var letter in query5)
            {
                Console.WriteLine($"Character {letter.Key} : {letter.Count()} times");
            }
            Console.WriteLine();

            //6. Print the days of the week
            string[] dayWeek = { "Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday" };
            var query6 = from days in dayWeek
                         select days;
            foreach(var days in query6)
            {
                Console.WriteLine(days);
            }
            Console.WriteLine();

            //7. Display Digit, Frequency, and digit * frequency
            int[] numbers = new int[] { 5,1,9,2,3,7,4,5,6,8,7,6,3,4,5,2 };
            var query7 = from n in numbers
                         group n by n into numbergroup
                         select numbergroup;
            Console.WriteLine("Number | Frequency | Number*Frequency");
            foreach(var n in query7)
            {
                Console.WriteLine($"{n.Key}           {n.Count()}        {n.Key * n.Count()}");
            }

            //8. Beginning and Ending Characters
            string[] cities = new string[] { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH",
                "NEW DELI", "AMSTERDAM", "ABU DHABI", "PARIS"};
            var query8 = from place in cities
                         select place;

            Console.WriteLine("Input starting character for the string:");
            char start = Convert.ToChar(Console.ReadLine().ToUpper());
            Console.WriteLine("Input ending character for the string:");
            char end = Convert.ToChar(Console.ReadLine().ToUpper());
            Console.Write("The cities are ");
            foreach(var place in query8)
            {
                Console.Write($"{place},");            
            }
            Console.WriteLine();
            foreach(var place in query8)
            {
                if(place.StartsWith(start) && place.EndsWith(end))
                {
                    Console.WriteLine($"The city starting with { start}" +
                    $"and ending with {end} is : {place}");
                }
            }

            //9. Create a list and print larger Values
            


        }
    }
}
