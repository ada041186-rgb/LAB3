using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK2.Clothing
{
    class ChainArmor : InventoryDecorator
    {
        public ChainArmor(IHero hero) : base(hero) { }

        public override string ItemName => "Кольчуга";
        public override int Defense => _hero.Defense + 12;

        public override string GetStats() =>
            $"{_hero.Name} + [{ItemName}]: Атака={Attack}, Захист={Defense}, Мана={Mana}";
    }
}
