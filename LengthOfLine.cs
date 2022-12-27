using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonComputation
{
    public class LengthOfLine
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

            var distance1 = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            Console.WriteLine(distance1);

       }
    }
}
