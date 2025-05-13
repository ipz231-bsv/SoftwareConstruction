using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public abstract class InventoryDecorator : ICharacter
    {
        protected ICharacter character;

        public InventoryDecorator(ICharacter character)
        {
            this.character = character;
        }

        public virtual string GetDescription() => character.GetDescription();
        public virtual int GetPower() => character.GetPower();
    }

}
