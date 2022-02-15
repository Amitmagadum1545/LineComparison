using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class LineLengthCalculation
    {
        public static void Length_Calculation()
        {
            Console.WriteLine("Enter the values of x1");
            double x1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the values of y1");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the values of x2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the values of y2");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double lengthOfLine = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine($"Length of The Line is" + lengthOfLine);
        }
    }
}
