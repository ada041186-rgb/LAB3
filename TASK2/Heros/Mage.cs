using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK2.Heros
{
    class Mage : IHero
    {
        public string Name => "Маг";
        public int Attack => 25;
        public int Defense => 5;
        public int Mana => 50;
        public string GetStats() =>
            $"{Name}: Атака={Attack}, Захист={Defense}, Мана={Mana}";
    }
}
