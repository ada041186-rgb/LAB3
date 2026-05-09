using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK2.Clothing
{
    class MageRobe : InventoryDecorator
    {
        public MageRobe(IHero hero) : base(hero) { }

        public override string ItemName => "Мантія мага";
        public override int Defense => _hero.Defense + 8;
        public override int Mana => _hero.Mana + 15;

        public override string GetStats() =>
            $"{_hero.Name} + [{ItemName}]: Атака={Attack}, Захист={Defense}, Мана={Mana}";
    }
}
