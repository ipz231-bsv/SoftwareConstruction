using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Aircraft
    {
        public string Name { get; set; }

        public Aircraft(string name)
        {
            this.Name = name;
        }

        public void RequestLanding(CommandCentre commandCentre)
        {
            commandCentre.RequestLanding(this);
        }
    }
}
