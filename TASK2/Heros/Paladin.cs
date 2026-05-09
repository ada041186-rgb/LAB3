using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK2.Heros
{
    class Paladin : IHero
    {
        public string Name => "Паладін";
        public int Attack => 15;
        public int Defense => 20;
        public int Mana => 20;
        public string GetStats() =>
            $"{Name}: Атака={Attack}, Захист={Defense}, Мана={Mana}";
    }
}
