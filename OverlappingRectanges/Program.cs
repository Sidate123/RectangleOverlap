using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverlappingRectanges
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Enter the number of rectangles to be checked for collision");
            int numberOfRectangles = Convert.ToInt32(Console.ReadLine());
            Rectangle[] rect = new Rectangle[numberOfRectangles];
            
            for (int i = 0; i < rect.Length; i++)
            {
                rect[i] = new Rectangle();
                INPUT:
                Console.WriteLine("Enter co-ordinates for Rect:{0}",i+1 );
                rect[i].PointL = CoreMethods.GetPointfromString(Console.ReadLine());
                rect[i].PointM = CoreMethods.GetPointfromString(Console.ReadLine());
                rect[i].PointR = CoreMethods.GetPointfromString(Console.ReadLine());
                rect[i].PointN = CoreMethods.GetPointfromString(Console.ReadLine());
                

                if(CoreMethods.CheckIfRectangle(rect[i]))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Invalid co-ordinates for a rectangle. Please enter correctly again");
                    goto INPUT;
                }
                
            }
            
            //Checks for overlapping rectangles for unique pairs
            for (int i = 0; i < rect.Length; i++)
            {
                
                for (int j = i+1; j <= rect.Length; j++)
                {

                    if (CoreMethods.CheckOverlap(rect[i], rect[j]))
                    {
                        Console.WriteLine("The rectangles {0} and {1} overlap",i+1,j+1);

                    }
                    else
                        Console.WriteLine("The rectangles don't overlap");
                }
            }


            


            Console.ReadKey();


            //User to enter L1,R1 of each rectangle

            //Use this list to get unique pairs

            //Loop through unique sets to check for overlapping

            //Publish Results
            
        }
        
    }
}
