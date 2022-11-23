using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tihi
{
    internal class Crab :Food
    {
        int size;
        public Crab(int size)
        {
            if (size >10||size<1)
                Console.WriteLine("Ez nem is rák! Mit akarsz megetetni velem?");
            else
                this.size = size;
        }

        public override int Value()
        {
            return size*base.Value();
        }
    }
}
