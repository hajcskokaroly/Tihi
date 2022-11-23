using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tihi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Turtle tihi = new Turtle(400, 500);

            Food[] kaja = new Food[3];

            kaja[0] = new Crab(50);
            kaja[1] = new Crab(5);
            kaja[2] = new Salad();


            for (int i = 0; i < kaja.Length; i++)
                tihi.Eat(kaja[i]);


            Console.WriteLine();
            Console.WriteLine("a végső értékei a teknősnek:");
            tihi.ertek();
            Console.ReadKey();

        }
    }
}
