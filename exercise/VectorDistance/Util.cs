using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ex_11_william
{
    public class Util
    {
        public static double CalculateVector(TwoDPoint first, TwoDPoint second)
        {
            if(second.xCord > first.xCord)
            {
                int temp = first.xCord;
                first.xCord = second.xCord;
                second.xCord = temp;
            }
            int width = first.xCord - second.xCord;
            if (second.yCord > first.yCord)
            {
                int temp = first.yCord;
                first.yCord = second.yCord;
                second.yCord = temp;
            }
            int height = first.yCord - second.yCord;
            double result = Math.Sqrt(Math.Pow(width,2) + Math.Pow(height,2));
            return result;
        }
        public static double CalculateVector(ThreeDPoint first, ThreeDPoint second)
        {
            if (second.xCord > first.xCord)
            {
                int temp = first.xCord;
                first.xCord = second.xCord;
                second.xCord = temp;
            }
            int width = first.xCord - second.xCord;
            if (second.yCord > first.yCord)
            {
                int temp = first.yCord;
                first.yCord = second.yCord;
                second.yCord = temp;
            }
            int height = first.yCord - second.yCord;
            if (second.zCord > first.zCord)
            {
                int temp = first.zCord;
                first.zCord = second.zCord;
                second.zCord = temp;
            }
            int depth = first.zCord - second.zCord;
            double result = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2) + Math.Pow(depth, 2));
            return result;
        }
        public static double CompareVector(TwoDPoint[] Points)
        {
            double result = 0;
            int x = 1;
            for (int i = 0; i < Points.Length; i++)
            {
                for (int j = x; j < Points.Length; j++)
                {
                    
                    double tempResult = CalculateVector(Points[i], Points[j]);
                    if (i == 0 & j == 1)
                    {
                        result = tempResult;
                        Console.WriteLine($"The closest points are array element {i} -- {Points[i].xCord}, {Points[i].yCord}" +
                            $" array element {j} -- {Points[j].xCord}, {Points[j].yCord}" +
                            $" having a distance of {result}");
                    }
                    else if (tempResult < result)
                    {
                        result = tempResult;
                        Console.WriteLine($"The closest points are array element {i} -- {Points[i].xCord}, {Points[i].yCord}" +
                            $" array element {j} -- {Points[j].xCord}, {Points[j].yCord}" +
                            $" having a distance of {result}");
                    }
                }
                x++;
            }
            return result;
        }
        public static double CompareVector(ThreeDPoint[] Points)
        {
            //List<int> duplicates = new List<int>();
            Console.WriteLine("The closest points are:");
            double result = 0;
            int x = 1;
            //int duplicate = 0;
            for (int i = 0; i < Points.Length; i++)
            {
                for (int j = x; j < Points.Length ; j++)
                {

                    double tempResult = CalculateVector(Points[i], Points[j]);
                    if (i == 0 & j == 1)
                    {
                        result = tempResult;
                        Console.WriteLine(
                            $"array element {i} -- [{Points[i].xCord}, {Points[i].yCord}, {Points[i].zCord}]" +
                            $"\narray element {j} -- [{Points[j].xCord}, {Points[j].yCord}, {Points[j].zCord}]" +
                            $"\nhaving a distance of {result}");
                        Console.WriteLine("======================================================================");
                    }
                    else if (tempResult < result)
                    {
                        result = tempResult;
                        Console.WriteLine(
                            $"array element {i} -- [{Points[i].xCord}, {Points[i].yCord}, {Points[i].zCord}]" +
                            $"\narray element {j} -- [{Points[j].xCord}, {Points[j].yCord}, {Points[j].zCord}]" +
                            $"\nhaving a distance of {result}");
                        Console.WriteLine("======================================================================");
                    }
                    //else if (tempResult == result)
                    //{
                    //    duplicate++;
                    //    duplicates.Add(j);
                    //};

                }
                x++;
            }
            //duplicates.Sort();
            //foreach (var item in duplicates)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine($"there are {duplicate} duplicates.");

            return result;
        }
    }
}
