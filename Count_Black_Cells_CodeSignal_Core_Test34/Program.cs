using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Black_Cells_CodeSignal_Core_Test34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Number 2");
            int input2 = int.Parse(Console.ReadLine());

            int res = countBlackCells(input,input2);
            Console.WriteLine(res);
        }

        static int gcd(int a, int b)
        {
            if (a > b)
                return gcd(a - b, b);
            else if (a < b)
                return gcd(a, b - a);
            else
                return a;
        }

        static int countBlackCells(int n, int m)
        {
            return m + n + gcd(m, n) - 2;
        }
    }
}
