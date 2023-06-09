using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class ModelaLine
    {
        public static void CartesianLine()
        {
            int x1 = 10, x2 = 30;
            int y1 = 30, y2 = 40;

            Console.WriteLine($"The length of the line from the points ({x1},{y1}) and ({x2},{y2})");
            double line = Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2);
            double result = Math.Sqrt(line);
            Console.WriteLine(result);
        }

        public static void EqualLine() 
        {
            int x1 = 10, x2 = 30;
            int y1 = 30, y2 = 40;

            int x3 = 20, y3 = 40;
            int x4 = 50, y4 = 60;

            Console.WriteLine($"The length of the line from the points ({x1},{y1}) and ({x2},{y2})");
            double line = Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2);
            double result = Math.Sqrt(line);
            Console.WriteLine(result);

            Console.WriteLine($"The length of the line from the points ({x3},{y3}) and ({x4},{y4})");
            double line2 = Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2);
            double result2 = Math.Sqrt(line2);
            Console.WriteLine(result2);

            if (result.Equals(result2))
            {
                Console.WriteLine("The two lines are Equal");
            }
            else
            {
                Console.WriteLine("The two lines are Not Equal");
            }
        }

        public static void CompareLines() 
        {
            int x1 = 10, x2 = 30;
            int y1 = 30, y2 = 40;

            int x3 = 20, y3 = 40;
            int x4 = 50, y4 = 60;

            Console.WriteLine($"The length of the line from the points ({x1},{y1}) and ({x2},{y2})");
            double line = Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2);
            double result = Math.Sqrt(line);
            Console.WriteLine(result);

            Console.WriteLine($"The length of the line from the points ({x3},{y3}) and ({x4},{y4})");
            double line2 = Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2);
            double result2 = Math.Sqrt(line2);
            Console.WriteLine(result2);

            Console.WriteLine("The Lines are "+result.CompareTo(result2));
        }
    }
}
