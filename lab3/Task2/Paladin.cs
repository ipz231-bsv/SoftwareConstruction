using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Paladin : ICharacter
    {
        public string GetDescription() => "Paladin";
        public int GetPower() => 9;
    }

}
