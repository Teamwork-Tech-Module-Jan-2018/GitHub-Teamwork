// CONFIRMED FROM cheater993
using System;

namespace p09
{
    class LongerLine
    {
        static void Main(string[] args)
        {
            //Reading coordinates of four points in a 2D plane that form two differenct lines (x1, y1)(x2, y2) and (x3, y3)(x4, y4)
            //first line
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            //second line
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());


            double longestLine = FindLongestLine(x1, y1, x2, y2, x3, y3, x4, y4); //calls a method which returns the longer line of the two

            if (longestLine == 1) //first line is longer
            {
                string line = FindClosestPoint(x1, y1, x2, y2);

                if (line == "first")
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else //second line is longer
            {
                string secondLine = FindClosestPoint(x3, y3, x4, y4);

                if (secondLine == "first")
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }
        //checks which point is closer to the center of the coordinate system, if they are equal returns the first one
        static string FindClosestPoint(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(x1 * x1 + y1 * y1);
            double distance1 = Math.Sqrt(x2 * x2 + y2 * y2);

            if (distance >= distance1)
            {
                return "second";
            }
            else
            {
                return "first";
            }
        }

        //calls methods that use the Pythagorean theorem to find the length of each line
        static double FindLongestLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {

            if (FindFirstLine(x1, y1, x2, y2) > FindSecondLine(x3, y3, x4, y4)) 
            {
                return 1; 
            }
            else
            {
                return 0;
            }
        }
        //returns the length of the second line
        static double FindSecondLine(double x3, double y3, double x4, double y4)
        {
            x3 = Math.Abs(x3);
            y3 = Math.Abs(y3);
            x4 = Math.Abs(x4);
            y4 = Math.Abs(y4);
            double line = Math.Sqrt((x3 + x4) * (x3 + x4) + (y3 + y4) * (y3 + y4));//pythagorean theorem

            return line;
        }
        //returns the length of the first line
        static double FindFirstLine(double x1, double y1, double x2, double y2)
        {
            x1 = Math.Abs(x1);
            y1 = Math.Abs(y1);
            x2 = Math.Abs(x2);
            y2 = Math.Abs(y2);
            double line = Math.Sqrt((x1 + x2) * (x1 + x2) + (y1 + y2) * (y1 + y2));//pythagorean theorem

            return line;
        }
    }
}
