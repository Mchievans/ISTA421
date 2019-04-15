using System;
using System.Collections;

namespace ProgammingExercise16
{
    class Utility
    {
        public static int SigmaX(int[] heightX)
        {
            int a = 0;
            for (int i = 0; i < heightX.Length; i++)
            {
                a += heightX[i];
            }
            return a;
        }

        public static int SigmaY(int[] weightY)
        {
            int a = 0;
            for (int i = 0; i < weightY.Length; i++)
            {
                a += weightY[i];
            }
            return a;
        }

        public static int SigmaXY(int[] heightX, int[] weightY)
        {
            int a = 0;
            for (int i = 0; i < heightX.Length; i++)
            {
                a += heightX[i] * weightY[i];
            }
            return a;
        }

        public static int ALLSigmaX_Sq(int[] heightX)
        {
            int a = 0;
            for (int i = 0; i < heightX.Length; i++)
            {
                a += (int)Math.Pow(heightX[i], 2);
            }
            return a;
        }
        public static double Alpha(int[] heightX, int[] weightY, int n)
        {
            double a = 0;
            double topLeft = SigmaY(weightY) * ALLSigmaX_Sq(heightX);
            double topRight = SigmaX(heightX) * SigmaXY(heightX, weightY);
            double bottomLeft = n * ALLSigmaX_Sq(heightX);
            double bottomRight = Math.Pow(SigmaX(heightX), 2);

            return a = (topLeft - topRight) / (bottomLeft - bottomRight);
        }

        public static double Bravo (int[] heightX, int[] weightY, int n)
        {
            double b = 0;
            double topLeft = n * SigmaXY(heightX, weightY);
            double topRight = SigmaX(heightX) * SigmaY(weightY);
            double bottomLeft = n * ALLSigmaX_Sq(heightX);
            double bottomRight = Math.Pow(SigmaX(heightX), 2);

            return b = (topLeft - topRight) / (bottomLeft - bottomRight);
        }
    }
}
