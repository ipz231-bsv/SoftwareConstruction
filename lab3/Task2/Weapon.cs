using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Weapon : InventoryDecorator
    {
        public Weapon(ICharacter character) : base(character) { }

        public override string GetDescription() => character.GetDescription() + " + Weapon";
        public override int GetPower() => character.GetPower() + 5;
    }

}
