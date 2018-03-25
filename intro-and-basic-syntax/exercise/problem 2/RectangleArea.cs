//CONFIRMED FROM cheater993
using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {


            //input rectangle's width
            double width = double.Parse(Console.ReadLine());
            //input recangle's height
            double height = double.Parse(Console.ReadLine());
            //Calculate area and print it
            Console.WriteLine("{0:F2}", width * height);
        }
    }
}
