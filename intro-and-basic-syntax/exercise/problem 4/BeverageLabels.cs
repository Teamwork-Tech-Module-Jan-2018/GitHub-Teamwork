using System;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read from the console product name(string), volume(cast it to double), energy content(cast to int) and sugar content(cast to double) 
            string productName = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            int energyContent = int.Parse(Console.ReadLine());
            double sugarContent = double.Parse(Console.ReadLine());
            //Calculate energy content - product between volume and energy content divided by 100
            double kcal = volume * energyContent / 100;
            //Calculate sugars - product between volume and sugar content divided by 100
            double sugars = volume * sugarContent / 100;
            //Print on the console the energy and sugar contents in specified format
            Console.WriteLine($"{volume}ml {productName}:");
            Console.WriteLine($"{kcal}kcal, {sugars}g sugars");
        }
    }
}
