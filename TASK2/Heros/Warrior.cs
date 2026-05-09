using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK2.Heros
{
    class Warrior : IHero
    {
        public string Name => "Воїн";
        public int Attack => 20;
        public int Defense => 15;
        public int Mana => 0;
        public string GetStats() =>
            $"{Name}: Атака={Attack}, Захист={Defense}, Мана={Mana}";
    }
}
