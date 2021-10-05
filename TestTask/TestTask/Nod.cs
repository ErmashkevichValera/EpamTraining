using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TestTask
{
    class Nod
    {
        public static int Euclide(int x, int y)
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
        // Editing Euclide algoritm
        public static int Euclide(int x, int y, out double t)
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
        public static int Euclide(int x, int y, int z)
        {
            return Euclide(Euclide(Math.Abs(x), Math.Abs(y)), Math.Abs(z));
        }
        public static int Euclide(int x, int y, int z, int m)
        {
            return Euclide(Euclide(Math.Abs(x), Math.Abs(y), Math.Abs(z)), Math.Abs(m));
        }
        public static int Euclide(int x, int y, int z, int m, int n)
        {
            return Euclide(Euclide(Math.Abs(x), Math.Abs(y), Math.Abs(z), Math.Abs(m)), Math.Abs(n));
        }
        public static int Stein(int x, int y, out double t)
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
        public static double[] TimesForGrafics(int x, int y)
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
