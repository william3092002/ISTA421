using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_11_william
{
    class Program
    {
        //public static Random rdn = new Random();
        static void Main(string[] args)
        {
            TwoDemsion();
            ThreeDemension();
            //ThreeDPoint[] points = new ThreeDPoint[]
            //{ new ThreeDPoint(24,2,3),
            //    new ThreeDPoint(24,2,4),
            //    new ThreeDPoint(22,12,1),
            //    new ThreeDPoint(5,6,55),
            //    new ThreeDPoint(1,3,4),
            //    new ThreeDPoint(1,3,3),
            //    new ThreeDPoint(5,45,123)};
            //Util.CompareVector(points);
        }
        public static void TwoDemsion()
        {
            TwoDPoint[] Points = new TwoDPoint[100];
            Random rdn = new Random();
            for (int i = 0; i < Points.Length; i++)
                Points[i] = new TwoDPoint(rdn.Next(1, 101), rdn.Next(1, 101));
            Util.CompareVector(Points);
        }
        public static void ThreeDemension()
        {
            ThreeDPoint[] Points = new ThreeDPoint[1000];
            Random rdn = new Random();

            //Parallel.For(0, Points.Length - 1, i => Points[i] = new ThreeDPoint(rdn.Next(1, 1001), rdn.Next(1, 1001), rdn.Next(1, 1001)));

            for (int i = 0; i < Points.Length; i++)
            {
                Points[i] = new ThreeDPoint(rdn.Next(1, 1001), rdn.Next(1, 1001), rdn.Next(1, 1001));
            }
            Util.CompareVector(Points);

        }

    }
}
