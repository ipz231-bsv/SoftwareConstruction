using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task2.ICharacter;

namespace Task2
{
    public class Mage : ICharacter
    {
        public string GetDescription() => "Mage";
        public int GetPower() => 8;
    }

}
