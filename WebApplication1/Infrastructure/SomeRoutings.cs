using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;

namespace Questrade.ResharperBenefits.Infrastructure
{
    public class InClassName
    {
        public InClassName(int x, int y, int z, int d)
        {
            X = x;
            Y = y;
            Z = z;
            D = d;
        }

        public int X { get; private set; }
        public int Y { get; private set; }
        public int Z { get; private set; }
        public int D { get; private set; }
    }

    public class SomeRoutings
    {
        public void IterateOver(IEnumerable<string> inputs)
        {
            if (inputs.Any(string.IsNullOrEmpty))
            {
                throw new NoNullAllowedException("Empty values detected");
            }

            TooManyParameters(new InClassName(10, 20, 30, 40));
        }

        private void TooManyParameters(InClassName inClassName)
        {
            Debug.WriteLine(string.Format("Coordinates are: {0} {1} {2} {3}", inClassName.X, inClassName.Y, inClassName.Z, inClassName.D));
        }
    }
}
