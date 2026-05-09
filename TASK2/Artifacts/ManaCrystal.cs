using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK2.Artifacts
{
    class ManaCrystal : InventoryDecorator
    {
        public ManaCrystal(IHero hero) : base(hero) { }

        public override string ItemName => "Кристал мани";
        public override int Mana => _hero.Mana + 30;

        public override string GetStats() =>
            $"{_hero.Name} + [{ItemName}]: Атака={Attack}, Захист={Defense}, Мана={Mana}";
    }
}
