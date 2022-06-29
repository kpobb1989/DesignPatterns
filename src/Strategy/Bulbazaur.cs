using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src.Strategy
{
    internal class Bulbazaur : Pokemon
    {
        public Bulbazaur() : base(new PoisonFightBehavior())
        {
        }
    }
}
