using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maclaurin_series
{

    static class maclaurin_series
    {

        public static double maclaurin_sin(int x, double eps)
        {

            return maclaurin_sin_helper(x, get_next(x, 1, x), eps, 2, x);
        }

       private static double get_next(double x, int elevate, double key_x)
        {
            return x * (-(key_x * key_x * FactTree(2 * elevate - 1)) / FactTree(2 * elevate + 1));
        }
        private static double maclaurin_sin_helper(double x, double x_next, double eps, int elevate, double key_x)
        {

            if (Math.Abs(x) <= eps)
                return x;
            return maclaurin_sin_helper(x + x_next, get_next(x_next, elevate, key_x), eps, ++elevate, key_x);
        }

        private static long ProdTree(int l, int r)
        {
            if (l > r)
                return 1;
            if (l == r)
                return l;
            if (r - l == 1)
                return (long)l * r;
            int m = (l + r) / 2;
            return ProdTree(l, m) * ProdTree(m + 1, r);
        }

       private static long FactTree(int n)
        {
            if (n < 0)
                return 0;
            if (n == 0)
                return 1;
            if (n == 1 || n == 2)
                return n;
            return ProdTree(2, n);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

           
        }
    }
}
