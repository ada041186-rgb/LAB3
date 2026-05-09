using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK2
{
    interface IHero
    {
        string Name { get; }
        int Attack { get; }
        int Defense { get; }
        int Mana { get; }
        string GetStats();
    }
}
