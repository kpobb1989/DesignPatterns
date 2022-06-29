using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src.Strategy
{
    internal class ElectroFightBehavior : IFightBehavior
    {
        public void Fight()
        {
            Console.WriteLine("Electro splash");
        }
    }
}
