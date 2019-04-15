using System;
using System.Collections;

namespace ProgammingExercise16
{
    class Program
    {
        struct Data
        {
           public static int[] heightX = new int[]
           {66, 71, 70,72 };

            public static int[] weightY = new int[]
            {165, 185, 190, 210};
 
        }
        static void Main(string[] args)
        {
            int n = 4;
            double alpha = Utility.Alpha(Data.weightY, Data.heightX, n);
            Console.WriteLine($"The value of alpha is: {alpha}");
            double beta = Utility.Bravo(Data.weightY, Data.heightX, n);
            Console.WriteLine($"The value of beta is: {beta}");

            alpha = Utility.Alpha(Data.heightX, Data.weightY, n);
            //Console.WriteLine($"The value of alpha is: {alpha}");
            beta = Utility.Bravo(Data.heightX, Data.weightY, n);
            //Console.WriteLine($"The value of beta is: {beta}");

            Console.WriteLine("Input your height in inches to recieve your estmated weight:");
            double inputHeight = double.Parse(Console.ReadLine());
            double outputweight = alpha + (beta * inputHeight);
            Console.WriteLine($"Your estimated weight is: {(int)outputweight} lbs");
            
        }
    }
}
