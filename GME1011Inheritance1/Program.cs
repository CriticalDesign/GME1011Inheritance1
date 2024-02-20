namespace GME1011Inheritance1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero hero1 = new Hero(126, "Apple");

            Console.WriteLine("Name:" + hero1.GetName());
            Console.WriteLine("Health:" + hero1.GetHealth());

            hero1.TakeDamage(26);
            Console.WriteLine("Health:" + hero1.GetHealth());
            Console.WriteLine("Hero does " + hero1.DealDamage() + " damage.");

            Console.WriteLine("---------------------");


            Magician hero2 = new Magician();

            Console.WriteLine("Name:" + hero2.GetName());
            Console.WriteLine("Health:" + hero2.GetHealth());

            hero2.TakeDamage(26);
            Console.WriteLine("Health:" + hero2.GetHealth());
            Console.WriteLine("Magician does " + hero2.DealDamage() + " damage.");
            Console.WriteLine("Magician has " + hero2.GetMana() + " mana.");


            Console.WriteLine("---------------------");


            Archer hero3 = new Archer(80, "Archer", 15);

            Console.WriteLine("Name:" + hero3.GetName());
            Console.WriteLine("Health:" + hero3.GetHealth());

            hero3.TakeDamage(26);
            Console.WriteLine("Health:" + hero3.GetHealth());
            Console.WriteLine("Archer does " + hero3.DealDamage() + " damage.");
            Console.WriteLine("Archer has " + hero3.GetArrows() + " arrows.");





        }
    }
}
