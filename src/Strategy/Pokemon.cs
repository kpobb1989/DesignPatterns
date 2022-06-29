using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src.Strategy
{
    internal abstract class Pokemon
    {
        private readonly IFightBehavior _fightBehavior;

        public Pokemon(IFightBehavior fightBehavior)
        {
            _fightBehavior = fightBehavior;
        }

        public void Fight()
        {
            _fightBehavior.Fight();
        }
    }
}
