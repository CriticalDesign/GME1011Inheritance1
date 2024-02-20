using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GME1011Inheritance1
{
    internal class Hero
    {
        private int _health;
        private string _name;
        protected Random _rng;

        public Hero()
        {
            _health = 100;
            _name = "anonymous hero";
            _rng = new Random();
        }

        public Hero(int health, string name)
        {
            _health = health;
            _name = name;
            _rng = new Random();
        }

        public int GetHealth() { return _health; }
        public string GetName() { return _name; }

        public void TakeDamage(int damage) { _health -= damage; }

        public virtual int DealDamage() { return _rng.Next(5,15); }
    }
}
