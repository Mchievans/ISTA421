using System;
using System.Collections.Generic;
using System.Text;


namespace ProgrammingExercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            int converter = 0;
            (input, converter) = PrintUI();

            int result = 0;
            while(converter != -1)
            {
                if(converter == 10)
                {
                    result = dec2bin(input);
                    Console.WriteLine($"Binary conversion is {result}");
                    result = dec2oct(input);
                    Console.WriteLine($"Octal conversion is {result}");
                    (input, converter) = PrintUI();
                }
                else if(converter == 2)
                {
                    result = bin2dec(input);
                    Console.WriteLine($"Decimal conversion is {result}");
                    result = bin2oct(input);                    //Does not work
                    Console.WriteLine($"Octal conversion is {result}");
                    (input, converter) = PrintUI();
                }
                else if(converter == 8)
                {
                    result = oct2bin(input);
                    Console.WriteLine($"Binary conversion is {result}");
                    result = oct2dec(input);
                    Console.WriteLine($"Decimal conversion is {result}");
                    (input, converter) = PrintUI();
                }
                else
                    Console.WriteLine("Error in base to  convert converter");
            }


        }
        /// <summary>
        /// This works correctly 
        /// This inputs a string and reverses the string using an array 
        /// it takes the element of the index and uses it as the 
        /// power of bases 8 then adds that each iteration over.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static int oct2dec(int input)
        {
            string strinput = input.ToString();
            int len = strinput.Length;
            char[] reverseStrinput = new char[len];
            int aggregate = 0;
            for(int i = 0, j = len - 1;i < len;i++, j--)
            {
                reverseStrinput[j] = strinput[i];
                int m = reverseStrinput[j] - '0';
                input = (int)Math.Pow(8,j);
                aggregate += input * m;
                //Console.WriteLine(m);

            }
            return aggregate;
        }

        private static int bin2oct(int input)
        {
            Stack<int> mystack = new Stack<int>();
            StringBuilder sb = new StringBuilder();
            while(input != 0)
            {
                int bin = input % 1000;
                //mystack.Push(bin);
                input = input / 1000;
                int digit = bin2dec(bin);
                //Console.WriteLine(digit);
                mystack.Push(digit);
            }
            foreach(int bin in mystack)
            {
                sb.Append(bin.ToString());
            }
            string strinput = sb.ToString();
            input = int.Parse(strinput,System.Globalization.NumberStyles.AllowLeadingWhite);
            return input;
        }



        /// <summary>
        ///  This method input binary into a string creates a char array
        ///  it uses the char array to reverse the binary string
        ///  then uses a if statement to find the 
        ///   correct place values for each char
        //  and use aggreagte to add the place value as the power of base 2.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>aggregate</returns>
        private static int bin2dec(int input)
        {
            string strinput = input.ToString();
            int len = strinput.Length;               
            int aggregate = 0;
            for(int i = 0;i < len;i++)
            {
                char check = strinput[i];
                input = (int)Math.Pow(2,i);
                if(check == '1')
                {
                    aggregate += input;
                }
                else
                { 
                    continue;
                }
            }
            return aggregate;
        }

        private static int oct2bin(int input)
        {
            Queue<int> myQueue = new Queue<int>();
            StringBuilder sb = new StringBuilder();
            string strinput = input.ToString();
            foreach(char L in strinput)
            {
                string L1 = L.ToString();
                int input2 = int.Parse(L1,System.Globalization.NumberStyles.AllowLeadingWhite);
                while(input2 != 0)
                {
                    int bin = input2 % 2;
                    myQueue.Enqueue(bin);
                    input2 = input2 / 2;
                }
            }
            foreach(int bin in myQueue)
            {
                sb.Append(bin.ToString());
            }
            string strinput2 = sb.ToString();
            input = int.Parse(strinput2,System.Globalization.NumberStyles.AllowLeadingWhite);
            return input;
        }

        /// <summary>
        /// This method converts a decimal to binary
        /// by uisng a stack to store the intergers
        /// removing them converter a stack
        /// converting them to a string
        /// and appending them in a string builder
        /// then converting them back to a interger. 
        /// </summary>
        /// <param name="input"></param>
        /// <returns>input</returns>
        private static int dec2oct(int input)
        {
            Stack<int> mystack = new Stack<int>();
            StringBuilder sb = new StringBuilder();
            while(input != 0)
            {
                int bin = input % 8;
                mystack.Push(bin);
                input = input / 8;
            }
            foreach(int bin in mystack)
            {
                sb.Append(bin.ToString());
            }
            string strinput = sb.ToString();
            input = int.Parse(strinput,System.Globalization.NumberStyles.AllowLeadingWhite);
            return input;
        }

        /// <summary>
        /// This method converts a decimal to binary
        /// by uisng a stack to store the intergers
        /// removing them converter a stack
        /// converting them to a string
        /// and appending them in a string builder
        /// then converting them back to a interger. 
        /// </summary>
        /// <param name="input"></param>
        /// <returns>input</returns>
        private static int dec2bin(int input)
        {
            Stack<int> mystack = new Stack<int>();
            StringBuilder sb = new StringBuilder();
            while(input != 0)
            {
                int bin = input % 2;
                mystack.Push(bin);
                input = input / 2;
            }
            foreach(int bin in mystack)
            {
                sb.Append(bin.ToString());
            }
            string strinput = sb.ToString();
            input = int.Parse(strinput, System.Globalization.NumberStyles.AllowLeadingWhite);
            return input;
        }

        /// <summary>
        /// This method prints a user Interface.
        /// </summary>
        /// <returns>input, converter</returns>
        private static (int input, int converter) PrintUI()
        {
            Console.WriteLine("Please enter an interger to be converted or enter -1 in next prompt to exit.");
            string IntInput = Console.ReadLine();
            int input = int.Parse(IntInput);

            Console.WriteLine("Please select a type to convert converter: binary(2), octal(8), decimal(10)");
            Console.WriteLine("Enter -1 to exit");
            string Strinput = Console.ReadLine();
            int converter = int.Parse(Strinput);

            if(converter == -1)
            {
                Console.WriteLine("Bye!");
            }
            else
            {
                Console.WriteLine($"Number: {input}, base: {converter}");
            }
            return (input, converter);
        }
    }
}
