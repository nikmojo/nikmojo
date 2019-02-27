using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHM_2002
{
    class Program
    {
        static void Main(string[] args)
        {
            task8(12, 10);
            task10(5,14);
            task12(2);
        }

        public static void task8(int x8, int y8)
        {
            double add8 = Math.Pow((1 - Math.Tan(x8)), (1/Math.Tan(x8)));
            double res8 = add8 + Math.Cos(x8 - y8);
            Console.WriteLine("Exercise 8 has result: " + res8);
            Console.ReadKey();
        }

        public static void task10(int x10,int y10)
        {
            if (x10==1)
            {
                Console.WriteLine("devision by 0");
                Console.ReadKey();
            }
            else
            {
                double add10 = Math.Pow(((x10 + 1) / (x10 - 1)),x10);
                double res10 = add10 + 18 * x10 * y10 * y10;
                Console.WriteLine("Exercise 10 has result: " + res10);
                Console.ReadKey();
            }
        }

        public static void task12(int x12)
        {
            if ((x12==2) || (x12 == 8))
            {
                Console.WriteLine("devision by 0");
                Console.ReadKey();
            }
            else
            {
                double res12 = (x12 * x12 - 7 * x12 + 10) / x12 * x12 - 8 * x12 + 12;
                Console.WriteLine("Exercise 12 has result: " + res12);
                Console.ReadKey();
            }
        }


    }
}
