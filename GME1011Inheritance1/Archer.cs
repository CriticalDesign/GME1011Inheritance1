using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GME1011Inheritance1
{
    internal class Archer : Hero
    {
        //1. subclasses inherit superclass attributes
        //2. sublcasses MAY introduce their own attributes


        //3. subclasses inherit superclass methods (or behaviours)
        //4. subclasses MAY introduce their own behaviours
        //5. subclasses MAY override superclass behaviours

        private int _arrows;

        public Archer() : base(75, "anonymous archer")
        { _arrows = 10; }

        public Archer(int health, string name, int arrows) : base(health, name)
        {
            _arrows = arrows;
        }

        public int GetArrows() { return _arrows; }
        public override int DealDamage() { _arrows--; return _rng.Next(10, 16); }
    }
}
