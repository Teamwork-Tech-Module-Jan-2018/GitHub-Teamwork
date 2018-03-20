using System;

namespace p09
{
    class LongerLine
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());


            double longestline = FindLongestLine(x1, y1, x2, y2, x3, y3, x4, y4);

            if (longestline == 1)
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
            else
            {
                string line = FindClosestPoint(x3, y3, x4, y4);

                if (line == "first")
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }

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

        static double FindSecondLine(double x3, double y3, double x4, double y4)
        {
            x3 = Math.Abs(x3);
            y3 = Math.Abs(y3);
            x4 = Math.Abs(x4);
            y4 = Math.Abs(y4);
            double line = Math.Sqrt((x3 + x4) * (x3 + x4) + (y3 + y4) * (y3 + y4));

            return line;
        }

        static double FindFirstLine(double x1, double y1, double x2, double y2)
        {
            x1 = Math.Abs(x1);
            y1 = Math.Abs(y1);
            x2 = Math.Abs(x2);
            y2 = Math.Abs(y2);
            double line = Math.Sqrt((x1 + x2) * (x1 + x2) + (y1 + y2) * (y1 + y2));

            return line;
        }
    }
}
