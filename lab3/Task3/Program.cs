using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n== Drawing Shapes ==");

            Shape redRectangle = new Rectangle(new Red());
            redRectangle.Draw();

            Shape greenCircle = new Circle(new Green());
            greenCircle.Draw();

            Shape greenRectangle = new Rectangle(new Green());
            greenRectangle.Draw();

            Console.ReadKey(); 
        }
    }
}
