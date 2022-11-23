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
                Console.WriteLine("ez nem is rák! mit akarsz megetetni velem?");
            else
                this.size = size;
        }

        public override int value()
        {
            return size*base.value();
        }
    }
}
