using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Rectangle : Shape
    {
        public Rectangle(IColor color) : base(color) { }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a {color.GetColor()} rectangle");
        }
    }

}
