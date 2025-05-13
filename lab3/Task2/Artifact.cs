using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Artifact : InventoryDecorator
    {
        public Artifact(ICharacter character) : base(character) { }

        public override string GetDescription() => character.GetDescription() + " + Artifact";
        public override int GetPower() => character.GetPower() + 7;
    }

}
