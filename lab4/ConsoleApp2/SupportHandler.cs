using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class SupportHandler
    {
        protected SupportHandler nextHandler;

        public void SetNext(SupportHandler next)
        {
            nextHandler = next;
        }

        public abstract void HandleRequest(string request);


    }

}
