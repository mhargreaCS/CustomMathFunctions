using System;
using System.Numerics;

namespace CustomFunctions
{
    class ProgramDriver
    {
        static void Main(string[] args)
        {
            float x = 1237.9166637f; int y = 4;

            float newfor = Algebra.round(x, y);
            Console.WriteLine(newfor);

            Trig.cos();
;       }
    }
}