using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS_Day1
{
    class Rectangle
    {
        // attributes
        int length, width;

        // constructor
        public Rectangle()
        {
            Console.WriteLine("Constructor is called");
            length = 1;
            width = 1;
        }
        public Rectangle(int l, int w)
        {
            Console.WriteLine("Overloaded Constructor is called");
            length = l;
            width = w;
        }

        // methods
        public int GetLength()
        {
            return length;
        }
        public void SetLength(int l)
        {
            if (l > 0)
                length = l;
            else
                Console.WriteLine("Length cannot be negative");
        }
        public int GetWidth()
        {
            return width;
        }
        public void SetWidth(int l)
        {
            if (l > 0)
                width = l;
            else
                Console.WriteLine("Width cannot be negative");
        }
        public int Area
        {
            get
            {
                return Length * Width;
            }
        }
        public int GetPerimeter()
        {
            return 2 * (Length + Width);
        }

        // properties
        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
        public static void Main()
        {
            Rectangle r = new Rectangle();
            r.SetLength(5);
            r.SetWidth(7);

            Rectangle r2 = new Rectangle(3, 8);
            Console.WriteLine(r.Area);
            Console.WriteLine(r2.Area);
        }
    }

}
