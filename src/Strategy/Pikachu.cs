using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src.Strategy
{
    internal class Pikachu : Pokemon
    {
        public Pikachu() : base(new ElectroFightBehavior())
        {
        }
    }
}
