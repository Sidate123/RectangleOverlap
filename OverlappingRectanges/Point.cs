using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverlappingRectanges
{
    public class Point: ICo_ordinate
    {
        private double _x;
        private double _y;

        public double XCoordinate
        {
          get {return _x; }
          set {_x = value; }
        }
        public double YCoordinate
        {
          get {return _y; }
          set {_y = value; }
        }

      
    }
}
