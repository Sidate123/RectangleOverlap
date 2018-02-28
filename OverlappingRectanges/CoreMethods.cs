using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverlappingRectanges
{
    public class CoreMethods
    {
        
        //Splits the input provided as a string and returns a Point object with co-ordinates
        public static Point GetPointfromString(string csvInput)
        {
            string[] pointArray = csvInput.Split(',');
            Point res = new Point();
             res.XCoordinate = Convert.ToDouble(pointArray[0]);
            res.YCoordinate = Convert.ToDouble(pointArray[1]);
            return res;
        }
        //Checks a pair of rectangles to see if they overlap or not and returns a bool value
        public static bool CheckOverlap(Rectangle rect1,Rectangle rect2)
        {
            if (rect2.PointL.XCoordinate > rect1.PointR.XCoordinate || rect2.PointL.XCoordinate > rect1.PointR.XCoordinate)
                return false;
            if (rect2.PointR.YCoordinate > rect1.PointL.YCoordinate || rect1.PointR.YCoordinate > rect2.PointL.YCoordinate)
                return false;

            return true;

        }
        //Validates whether the given co-ordinates are of a rectangle and returns a bool value
        public static bool CheckIfRectangle(Rectangle r)
        {
            if (r.PointL.XCoordinate == r.PointN.XCoordinate && r.PointM.XCoordinate == r.PointR.XCoordinate)
                return true;
            else
                return false;
        }
    }
}
