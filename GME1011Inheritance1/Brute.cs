using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GME1011Inheritance1
{
    internal class Brute : Hero
    {
        private int _strength;

        public Brute() : base(200, "anonymous brute")
        {
            _strength = 10;
        }

        public int GetStrength() { return _strength; }

        public override int DealDamage()
        {
            return _rng.Next(3, 6) * _strength;
        }


    }
}
