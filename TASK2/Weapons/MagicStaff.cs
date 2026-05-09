using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK2.Weapons
{
    class MagicStaff : InventoryDecorator
    {
        public MagicStaff(IHero hero) : base(hero) { }

        public override string ItemName => "Магічний посох";
        public override int Attack => _hero.Attack + 15;
        public override int Mana => _hero.Mana + 20;

        public override string GetStats() =>
            $"{_hero.Name} + [{ItemName}]: Атака={Attack}, Захист={Defense}, Мана={Mana}";
    }
}
