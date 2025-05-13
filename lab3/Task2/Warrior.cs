using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Warrior : ICharacter
    {
        public string GetDescription() => "Warrior";
        public int GetPower() => 10;
    }

}
