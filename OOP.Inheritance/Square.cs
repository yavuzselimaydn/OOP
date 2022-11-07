using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    internal class Square : Rectangle
    {
        public Square()
        {

        }
        public Square(int x, int y) : base(x,y)
        {

        }
        new public void Calculate()
        {
            Console.WriteLine("Calculeted by Square...");
        }
    }
}
