using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK2.Weapons
{
    class IronSword : InventoryDecorator
    {
        public IronSword(IHero hero) : base(hero) { }

        public override string ItemName => "Залізний меч";
        public override int Attack => _hero.Attack + 10;

        public override string GetStats() =>
            $"{_hero.Name} + [{ItemName}]: Атака={Attack}, Захист={Defense}, Мана={Mana}";
    }
}
