using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Armor : InventoryDecorator
    {
        public Armor(ICharacter character) : base(character) { }

        public override string GetDescription() => character.GetDescription() + " + Armor";
        public override int GetPower() => character.GetPower() + 3;
    }

}
