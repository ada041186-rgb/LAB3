using TASK2.Heros;
using TASK2.Artifacts;
using TASK2.Clothing;
using TASK2.Weapons;
using System.Text;


namespace TASK2
{
    internal class Program
    {

        static void Print(IHero hero)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(hero.GetStats());
            Console.ResetColor();
        }

        static void Main()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("--- Воїн ---");
            IHero warrior = new Warrior();
            Print(warrior);

            warrior = new IronSword(warrior);
            Print(warrior);

            warrior = new ChainArmor(warrior);
            Print(warrior);

            warrior = new AmuletOfStrength(warrior);
            Print(warrior);

            Console.WriteLine("\n--- Маг ---");
            IHero mage = new Mage();
            Print(mage);

            mage = new MagicStaff(mage);
            Print(mage);

            mage = new MageRobe(mage);
            Print(mage);

            mage = new ManaCrystal(mage);
            Print(mage);

            Console.WriteLine("\n--- Паладін ---");
            IHero paladin = new Paladin();
            Print(paladin);

            paladin = new IronSword(paladin);
            paladin = new ChainArmor(paladin);
            paladin = new ManaCrystal(paladin);
            paladin = new AmuletOfStrength(paladin);
            Print(paladin);
        }
    }
}
