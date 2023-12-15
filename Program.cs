using System;

namespace CustomFunctions
{
    class newMath
    {
        public static int power(int x)
        {
            int y = 10;
            for (int i = 0; i < x; i++)
            {
                y *= 10;
            }
            return y;
        }
        public static float round(float value, int decPoints) // Work-in-progress
        {
            float floatConvert = value * (newMath.power(decPoints));
            int newInt = Convert.ToInt32(floatConvert); 
            string rounding = Convert.ToString(newInt);
            char[] newNum = new char[decPoints + (rounding.Length - decPoints) + 1];

            for (int i = 0; i < decPoints; i++)
            {
                newNum[i] = rounding[i];
            }

            newNum[rounding.Length - decPoints - 1] = '.';

            for (int i = 0; i < newNum.Length; i++)
            {
                Console.WriteLine(newNum[i]);
            }
            string newNum2 = Convert.ToString(newNum);
            float newRounded = Convert.ToSingle(newNum2);
            float finalRounded = newRounded;
            
            return newRounded;
        }
    }
    class ProgramDriver
    {
        static void Main(string[] args)
        {
            float x = 7.9182637f; int y = 4;

            float newfor = newMath.round(x, y);
            Console.WriteLine(newfor);
;       }
    }
}