using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RANDOM_NUMBER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                //Console.writeline(random.Next());
                SimpleMethod(random);
            }

            Console.ReadLine();
        }

        private static void SimpleMethod(Random random)
        {
            Console.WriteLine(random.Next());

        }
    }
}
