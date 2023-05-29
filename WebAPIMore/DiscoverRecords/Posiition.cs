using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverRecords
{
    internal class PositionC
    {
        public PositionC(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }

    internal struct PositionS 
    {
        public PositionS(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }
    }

    internal record PositionR(int X, int Y);

    //internal record class PositionRC(int X, int Y);

    internal record class PositionRC
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    // internal record struct PositionRS(int X, int Y);
    internal record struct PositionRS
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
