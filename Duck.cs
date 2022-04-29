using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Ducks
{
    enum KindOfDuck
    {
        Mallard,
        Muscovy,
        Loon
    }

    class Duck : IComparable<Duck>
    {
        public int Size { get; set; }

        public KindOfDuck Kind { get; set; }

        public int CompareTo(Duck duckToCompare)
        {
            if (this.Size > duckToCompare.Size)
            {
                return 1;
            }
            if (this.Size < duckToCompare.Size)
            {
                return -1;
            }
            return 0;
        }
    }
}
