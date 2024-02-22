using System.Collections.Generic;

namespace GME1011Inheritance1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Hero> party = new List<Hero>();

            party.Add(new Hero(100, "Arthur"));
            party.Add(new Brute());
            party.Add(new Brute());
            party.Add(new Brute());
            party.Add(new Magician(50, "Merlin", 10));
            party.Add(new Archer(110, "Galahad", 20));

            party[0].Heal(10);
            party[1].TakeDamage(25);
            string name = party[2].GetName();
            
            foreach (Hero tempHero in party)
            {
                Console.WriteLine(tempHero.GetName() + " does " + tempHero.DealDamage() + " damage.");
            }

            int arrowStock = 0;
            int manaStock = 0;
            foreach (Hero temphero in party)
            {
                if (temphero.GetType() == typeof(Archer))
                {
                    Console.WriteLine(temphero.GetName() + " has " + ((Archer)temphero).GetArrows() + " arrows.");
                    arrowStock += ((Archer)temphero).GetArrows();
                }
                if (temphero.GetType() == typeof(Magician))
                    manaStock += ((Magician)temphero).GetMana();
            }
            Console.WriteLine("Arrows: " + arrowStock);
            Console.WriteLine("Mana: " + manaStock);

            foreach (Hero temphero in party)
            {
                Console.WriteLine(temphero);
            }




















        }
    }
}
