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
                    //result = bin2dec(input);
                    Console.WriteLine($"Decimal conversion is {result}");
                    //result = bin2oct(input);
                    Console.WriteLine($"Octal conversion is {result}");
                    (input, converter) = PrintUI();
                }
                else if(converter == 8)
                {
                    result = oct2bin(input);
                    Console.WriteLine($"Binary conversion is {result}");
                    //result = oct2dec(input);
                    Console.WriteLine($"Decimal conversion is {result}");
                    (input, converter) = PrintUI();
                }
                else
                    Console.WriteLine("Error in base to  convert converter");
            }


        }

        private static int oct2bin(int input)
        {
            Stack<int> mystack = new Stack<int>();
            StringBuilder sb = new StringBuilder();
            //input = dec2oct(input);
            string strinput = input.ToString();
            int m; 

            foreach(char i in strinput)
            {
                {
                    //Console.WriteLine(i);
                    strinput = i.ToString();
                    input = int.Parse(strinput);
                    Console.WriteLine(input);
                    do
                    {
                        int bin = input % 2;
                        //mystack.Push(bin);
                        sb.Append(bin.ToString());
                        input = input / 2;
                    }
                    while(input != 0);
                }
                ////////////////foreach(int bin in mystack)
                ////////////////{
                ////////////////    sb.Append(bin.ToString());
                ////////////////}
                ////////////////strinput = sb.ToString();
                ////////////////Console.WriteLine(strinput);
                ////////////////input = int.Parse(strinput);
                ////////////////return input;
                //if(i < 8)
                //{
                //int result = dec2bin(i);// WORKS DONT TOUCH
                    //Console.WriteLine(result);


                    //result = result - 110000;
                    //mystack.Push(result);// WORKS DONT TOUCH
                    //Console.WriteLine(result);//TEST 
                //}
                //else
                //    Console.WriteLine("Input is not a octal interger");
            }
            //Correct DONT TOUCH 
            //for(int i = mystack.Count - 1; i >= 0; i--)
            //{
            //    m = mystack.Pop();
            //    sb.Append(m.ToString());
            //    Console.WriteLine(m);
            //}
            strinput = sb.ToString();
            input = int.Parse(strinput);
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
            input = int.Parse(strinput);
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
            input = int.Parse(strinput);
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
