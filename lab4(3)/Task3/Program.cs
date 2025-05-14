using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var div = new LightElementNode("div", DisplayType.Block, ClosingType.Pair);
            div.CssClasses.Add("container");

            var p = new LightElementNode("p", DisplayType.Block, ClosingType.Pair);
            p.CssClasses.Add("text");

            var text = new LightTextNode("Привіт із LightHTML!");
            p.AddChild(text);

            div.AddChild(p);

            div.AddEventListener("click", () => Console.WriteLine("Div clicked!"));
            p.AddEventListener("mouseover", () => Console.WriteLine("Paragraph hovered!"));

            Console.WriteLine("InnerHTML:");
            Console.WriteLine(div.InnerHTML);

            Console.WriteLine("\nOuterHTML:");
            Console.WriteLine(div.OuterHTML);

            Console.WriteLine("\nВведіть 'click' для спрацювання події click на div або 'mouseover' для спрацювання події на p:");
            string input = Console.ReadLine();

            if (input == "click")
            {
                div.TriggerEvent("click");
            }
            else if (input == "mouseover")
            {
                p.TriggerEvent("mouseover");
            }

            Console.ReadLine();
        }
    }
}
