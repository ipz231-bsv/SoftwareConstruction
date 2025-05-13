using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== RPG Characters ==");

            ICharacter mage = new Mage();
            mage = new Weapon(mage);         // додали зброю
            mage = new Armor(mage);          // додали броню
            mage = new Artifact(mage);       // додали артефакт

            Console.WriteLine($"Character: {mage.GetDescription()}");
            Console.WriteLine($"Total Power: {mage.GetPower()}");

            ICharacter warrior = new Warrior();
            warrior = new Armor(warrior);
            warrior = new Weapon(warrior);

            Console.WriteLine($"\nCharacter: {warrior.GetDescription()}");
            Console.WriteLine($"Total Power: {warrior.GetPower()}");
            Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
            Console.ReadKey();

        }
    }
}
