using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS_Day1
{
    class Coin
    {
        Random random;
        int face;
        public Coin()
        {
            System.Threading.Thread.Sleep(432);
            random = new Random();
        }

        void Flip()
        {
            face = random.Next(2);
        }

        int GetFace()
        {
            return face;
        }

        static void Main(string[] args)
        {
            Coin c = new Coin();
            c.Flip();
            Console.WriteLine(c.face);
            Console.WriteLine(c.GetFace());
            Console.WriteLine(c.GetFace());
            Console.WriteLine(c.GetFace());
            Coin d = new Coin();
            d.Flip();
            Console.WriteLine(d.GetFace());
            Console.WriteLine(d.GetFace());
            Console.WriteLine(d.GetFace());
            Console.WriteLine(d.GetFace());
        }
    }

}
