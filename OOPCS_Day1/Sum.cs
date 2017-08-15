using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS_Day1
{
    class Test
    {
        public static void Main()
        {
            int total = 0;
            int i = 1;
            while (i <= 100)
            {
                if (i % 2 == 0)
                    total = total + i;
                i = i + 1;
            }
            Console.WriteLine("The sum of first 50 even integers is {0}", total);
        }
    }
}

