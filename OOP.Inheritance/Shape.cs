using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    internal class Shape
    {
        public Shape()
        {

        }
        public Shape(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int Height  { get; set; }
        public int Width { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Base class drawing task...");
        }


        public void WorkwithDifferentObjects(object o)
        {
            Shape shapefromParameter = o as Shape;
            // as ile kontrol
            if (shapefromParameter != null)
            {
                shapefromParameter.Draw();
            }
            // is ile kontrol
            if (o is Shape)
            {
                
            }
        }


    }
}
