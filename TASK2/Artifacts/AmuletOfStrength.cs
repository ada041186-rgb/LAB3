using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TASK2.Artifacts
{
    class AmuletOfStrength : InventoryDecorator
    {
        public AmuletOfStrength(IHero hero) : base(hero) { }

        public override string ItemName => "Амулет сили";
        public override int Attack => _hero.Attack + 8;
        public override int Defense => _hero.Defense + 5;

        public override string GetStats() =>
            $"{_hero.Name} + [{ItemName}]: Атака={Attack}, Захист={Defense}, Мана={Mana}";
    }
}
