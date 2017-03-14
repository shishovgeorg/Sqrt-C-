using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koren
{
    class Koren
    {
        static float Square(float x)
        {
            float sqrt = x * x;
            return sqrt;
        }

        static float Avg(float y, float x)
        {
            float avg1 = (y + x) / 2;
            return avg1;
        }

        static float Improve(float y, float x)
        {
            float z = x / y;
            float imp = Avg(y, z);
            return imp;
        }

        static float Abc(float x)
        {
            if (x < 0)
                return -x;
            else
                return x;
        }

        static bool Check(float y, float x)
    {
        if ((Abc(Square(y) - x) < 0.000001))
             return true;
        else
            return false;
    }

        static void Iter(float y, float x)
        {
            if (Check(y, x))
            {
                Console.WriteLine(y);
                Console.ReadKey();
            }
            else
                Iter(Improve(y, x), x);
        }
         static void Main(string[] args)
        {
            Iter(1, 64);
        }
    }
}
