using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonComputation
{
    public class LineComparison
    {
        public static void Check()
        {

            Console.WriteLine("Enter value of x1 : ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter value of x2 : ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter value of y1 : ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter value of y2 : ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter value of x3 : ");
            double x3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter value of x4 : ");
            double x4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter value of y3 : ");
            double y3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter value of y4 : ");
            double y4 = Convert.ToDouble(Console.ReadLine());

            var distance1 = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            Console.WriteLine(distance1);

            var distance2 = Math.Sqrt((Math.Pow(x3 - x4, 2) + Math.Pow(y3 - y4, 2)));
            Console.WriteLine(distance2);

            if (distance1 > distance2)
            {
                Console.WriteLine("The Line1 Is Greater Than Line2");
            }
            else if (distance1 < distance2)
            {
                Console.WriteLine("The Line1 Is Smaller Than Line2");
            }
            else 
            {
                Console.WriteLine("Both The Lines Are Equal");
            }
        }
    }
}
