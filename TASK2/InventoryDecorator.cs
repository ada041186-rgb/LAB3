using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK2
{
    abstract class InventoryDecorator : IHero
    {
        protected readonly IHero _hero;

        protected InventoryDecorator(IHero hero) => _hero = hero;

        public virtual string Name => _hero.Name;
        public virtual int Attack => _hero.Attack;
        public virtual int Defense => _hero.Defense;
        public virtual int Mana => _hero.Mana;

        public abstract string ItemName { get; }
        public abstract string GetStats();
    }
}
