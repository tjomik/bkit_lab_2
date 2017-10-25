using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle a = new Rectangle(2, 5);
            a.Print();
            Square b = new Square(5);
            b.Print();
            Circle c = new Circle(2);
            c.Print();
            Console.ReadLine();
        }
    }
}
