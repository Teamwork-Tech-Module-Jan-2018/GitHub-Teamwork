using System;

namespace ConsoleApp1
{
    class CharacterStats
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            string healthBarCurrentHealth = new string('|', currentHealth);
            string healthBarLessenedHealth = new string('.', maxHealth - currentHealth);
            string energyBarCurrentEnergy = new string('|', currentEnergy);
            string energyBarLessenedEnergy = new string('.', maxEnergy - currentEnergy);



            Console.WriteLine($"Name: {name}");

            //health bar
            Console.Write("Health: " + "|");
            Console.Write($"{healthBarCurrentHealth}{healthBarLessenedHealth}");
            Console.WriteLine("|");

            //energy bar
            Console.Write("Energy: " + "|");
            Console.Write($"{energyBarCurrentEnergy}{energyBarLessenedEnergy}");
            Console.WriteLine("|");
        }
    }
}
