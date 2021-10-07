using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TaskTest
{
    /// <summary>
    /// Create сlass Greatest Common Divisor(GCD)
    /// </summary>
    public class GCD
    {
        /// <summary>
        /// Performs GCD calculation for two numbers by Euclid method
        /// </summary>
        public int Euclide(int x, int y)
        {
            x = Math.Abs(x);
            y = Math.Abs(y);
            if (x == 0)
            {
                return y;
            }
            else
            {
                while (y != 0)
                {
                    if (x > y)
                    {
                        x -= y;
                    }
                    else
                    {
                        y -= x;
                    }
                }
                return x;
            }
        }
        /// <summary>
        /// Editing GCD calculation for two numbers and out param (execution time) by Euclid method
        /// </summary>
        public int Euclide(int x, int y, out double t)
        {
            Stopwatch st = Stopwatch.StartNew();
            x = Math.Abs(x);
            y = Math.Abs(y);
            if (x == 0)
            {
                st.Stop();
                t = st.Elapsed.TotalMilliseconds;
                return y;
            }
            else
            {
                while (y != 0)
                {
                    if (x > y)
                    {
                        x -= y;
                    }
                    else
                    {
                        y -= x;
                    }
                }
                st.Stop();
                t = st.Elapsed.TotalMilliseconds;
                return x;
            }
        }
        /// <summary>
        /// Performs GCD calculation for three numbers by Euclid method
        /// </summary>
        public int Euclide(int x, int y, int z)
        {
            return Euclide(Euclide(Math.Abs(x), Math.Abs(y)), Math.Abs(z));
        }
        /// <summary>
        /// Performs GCD calculation for four numbers by Euclid method
        /// </summary>
        public int Euclide(int x, int y, int z, int m)
        {
            return Euclide(Euclide(Math.Abs(x), Math.Abs(y), Math.Abs(z)), Math.Abs(m));
        }
        /// <summary>
        /// Performs GCD calculation for five numbers by Euclid method
        /// </summary>
        public int Euclide(int x, int y, int z, int m, int n)
        {
            return Euclide(Euclide(Math.Abs(x), Math.Abs(y), Math.Abs(z), Math.Abs(m)), Math.Abs(n));
        }
        /// <summary>
        /// Performs GCD calculation for two numbers and out param (execution time) by Stein method
        /// </summary>
        public int Stein(int x, int y, out double t)
        {
            Stopwatch st = Stopwatch.StartNew();
            x = Math.Abs(x);
            y = Math.Abs(y);
            int k = 1;
            if (y == 0)
            {
                st.Stop();
                t = st.Elapsed.TotalMilliseconds;
                return x;
            }
            while (x != 0 && y != 0)
            {
                while (x % 2 == 0 && y % 2 == 0)
                {
                    x /= 2;
                    y /= 2;
                    k *= 2;
                }
                while (x % 2 == 0)
                    x /= 2;
                while (y % 2 == 0)
                    y /= 2;
                if (x >= y)
                    x -= y;
                else
                    y -= x;
            }
            st.Stop();
            t = st.Elapsed.TotalMilliseconds;
            return y * k;
        }
        /// <summary>
        /// Performs method for preparing the creation of a histogram
        /// </summary>
        public double[] TimesForGrafics(int x, int y)
        {
            double[] times = new double[2];
            double t;
            Euclide(x, y, out t);
            times[0] = t;
            Stein(x, y, out t);
            times[1] = t;
            Console.WriteLine("Euclide: " + times[0] + " Stein: " + times[1]);
            return times;
        }
    }
}
