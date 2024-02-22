using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GME1011Inheritance1
{
    internal class Magician : Hero
    {
        //1. subclasses inherit superclass attributes
        //2. sublcasses MAY introduce their own attributes


        //3. subclasses inherit superclass methods (or behaviours)
        //4. subclasses MAY introduce their own behaviours
        //5. subclasses MAY override superclass behaviours

        private int _mana;

        public Magician() : base(50, "anonymous magician") 
        { _mana = 5; }

        public Magician(int health, string name, int mana) : base(health, name)
        {
            _mana = mana;
        }

        public int GetMana() { return _mana; }
        public override int DealDamage() { Console.WriteLine("How magical!!"); _mana--; return _rng.Next(20,36); }


        public override string ToString()
        {
            return "Magician[" + base.ToString() + ", " + _mana + "]";
        }
    }
}
