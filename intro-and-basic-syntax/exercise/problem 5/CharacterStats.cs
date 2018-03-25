using System;

namespace ConsoleApp1
{
    class CharacterStats
    {
        static void Main(string[] args)
        {
            //Read from the console name(string), current health(cast it to int), max health(cast to int),
            //current energy(cast it to int) and max energy(cast to int) 
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());
            //Create new strings with specified parameters
            string healthBarCurrentHealth = new string('|', currentHealth);
            string healthBarMissingHealth = new string('.', maxHealth - currentHealth);
            string energyBarCurrentEnergy = new string('|', currentEnergy);
            string energyBarMissingEnergy = new string('.', maxEnergy - currentEnergy);


            //Print the output on the console
            Console.WriteLine($"Name: {name}");

            //health bar
            Console.Write("Health: " + "|");
            Console.Write($"{healthBarCurrentHealth}{healthBarMissingHealth}");
            Console.WriteLine("|");

            //energy bar
            Console.Write("Energy: " + "|");
            Console.Write($"{energyBarCurrentEnergy}{energyBarMissingEnergy}");
            Console.WriteLine("|");
        }
    }
}
