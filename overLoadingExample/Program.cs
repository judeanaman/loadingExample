using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overLoadingExample
{
    class muc
    {
        // adding three integer values.

    public int Add(int a, int b, int c)
    {
        int sum = a + b + c;

        return sum;
    }
 
    // adding three double values.
    public double Multiplication(double a, double b, double c)
    {
        double sum = a * b * c;

        return sum;
    }
        static void Main(string[] args)
        {
            // Creating Object
            muc ob = new muc();

            int sum2 = ob.Add(1, 2, 3);

            Console.WriteLine("sum of the three " + "integer value : " + sum2);

            double sum3 = ob.Multiplication(4.0, 2.0, 5.0);

            Console.WriteLine("sum of the three "  + "double value : " + sum3);

        }
    }
}
