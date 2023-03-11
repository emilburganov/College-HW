using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice__18
{
    internal class Cone
    {
        private int r;
        private int H;

        public Cone(int r, int H)
        {
            this.r = r;
            this.H = H;
        }

        public double CobeBase()
        {
            return Math.PI * (Math.Pow(this.r, 2));
        }

        public double LateralSurfaceArea()
        {
            return Math.PI * this.r + Math.Sqrt(Math.Pow(this.r, 2) + Math.Pow(this.H, 2));
        }

        public double TotalSurfaceArea()
        {
            return CobeBase() + LateralSurfaceArea();
        }
    }
}
