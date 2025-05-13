using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            var div = new LightElementNode("div", DisplayType.Block, ClosingType.Pair);
            div.CssClasses.Add("container");

            var p = new LightElementNode("p", DisplayType.Block, ClosingType.Pair);
            p.CssClasses.Add("text");

            var text = new LightTextNode("Привіт із LightHTML!");
            p.AddChild(text);

            div.AddChild(p);

            Console.WriteLine("InnerHTML:");
            Console.WriteLine(div.InnerHTML);

            Console.WriteLine("\nOuterHTML:");
            Console.WriteLine(div.OuterHTML);

            Console.ReadLine(); 
        }
    }

}
