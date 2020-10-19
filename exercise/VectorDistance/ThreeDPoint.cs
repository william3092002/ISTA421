using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ex_11_william
{
    public struct ThreeDPoint
    {
        public int xCord { get; set; }
        public int yCord { get; set; }
        public int zCord { get; set; }
        public ThreeDPoint(int x, int y, int z)
        {
            xCord = x;
            yCord = y;
            zCord = z;
        }
        
    }
}
