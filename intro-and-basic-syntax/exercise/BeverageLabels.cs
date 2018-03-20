using System;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            int energyContent = int.Parse(Console.ReadLine());
            double sugarContent = double.Parse(Console.ReadLine());

            double kcal = volume * energyContent / 100;
            double sugars = volume * sugarContent / 100;

            Console.WriteLine($"{volume}ml {productName}:");
            Console.WriteLine($"{kcal}kcal, {sugars}g sugars");
        }
    }
}
