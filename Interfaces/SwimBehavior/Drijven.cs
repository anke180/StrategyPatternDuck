using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interfaces.SwimBehavior
{
    internal class Drijven : SwimBehaviour
    {
        public void Swim()
        {
            Console.WriteLine("Drijft op het water");
        }
    }
}
