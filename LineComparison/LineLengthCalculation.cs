using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class LineLengthCalculation
    {
        public static void Comparing_Two_Lines_Length()
        {
            Console.WriteLine("Enter the values of x1");
            double x1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the values of y1");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the values of x2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the values of y2");
            double y2 = Convert.ToDouble(Console.ReadLine());
           
            Console.WriteLine("Enter the values of x3");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the values of y3");
            double y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the values of x4");
            double x4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the values of y4");
            double y4 = Convert.ToDouble(Console.ReadLine());

            double lengthOfLine1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine($"Length of The First Line is" + lengthOfLine1);

            double lengthOfLine2 = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
            Console.WriteLine($"Length of The Second Line is" + lengthOfLine2);

            if (lengthOfLine1==lengthOfLine2)
            {
                Console.WriteLine("Length Of Line1 And Length of Line2 are Equal");
            }
            else
            {
                Console.WriteLine("Length of Line1 is not Equal to Length of Line2");
            }
        }
    }
}
