using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_And_Methods
{
    public abstract class AbstarctClassExample
    {
        public abstract void GetArea();
    }

    public class AbstractImplementation : AbstarctClassExample
    {
        int r = 0;
        public AbstractImplementation(int radius)
        {
            r = radius;
        }
        public override void GetArea()
        {
            Console.WriteLine("Area Of Circle is " + (3.14 * r * r));
        }
    }
}
