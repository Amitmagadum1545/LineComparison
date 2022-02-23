using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class LineLengthCalculation
    {
        public static double GetLineLength()
        {
            Console.WriteLine("Enter the values of x1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the values of y1");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the values of x2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the values of y2");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double lengthOfLine = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return lengthOfLine;
        }
        public static void Comparing_Two_Lines_Length()
        {
            Console.WriteLine("Enter the Coordinate Values for First line");
            double lengthOfLine1 = GetLineLength();
            Console.WriteLine($"Length of The Line 1 is" + lengthOfLine1);

            Console.WriteLine("Enter the Coordinate Values for Second line");
            double lengthOfLine2 = GetLineLength();
            Console.WriteLine($"Length of The Line 2 is" + lengthOfLine2);

            double diff = lengthOfLine1.CompareTo (lengthOfLine2);
            if (diff==0)
            {
                Console.WriteLine("Length Of Line1 And Length of Line2 are Equal");
            }
            else if (diff<0)
            {
                Console.WriteLine("Length of Line1 is Less than Length of Line2");
            }
            else if (diff>0)
            {
                Console.WriteLine("Length of Line1 is Greater than Length of Line2");
            }
        }
    }
}
