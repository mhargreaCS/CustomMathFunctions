using Microsoft.VisualBasic;
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
        public static float round(float value, int decPoints) 
        {
            string valueString = value.ToString();
            int decimalLoc = 0;
            foreach (char item in valueString)
            {
                if (item == '.')
                {
                    decimalLoc++;
                    break;
                }
                else
                {
                    decimalLoc++;
                }
            }

            int newLength = decimalLoc + decPoints;
            char[] placeholder = new char[newLength];
            char[] valueStringArr = valueString.ToCharArray();
            for (int i = 0; i <= newLength - 1; i++)
            {
                placeholder[i] = valueStringArr[i];
            }

            int index = Convert.ToInt32(placeholder[placeholder.Length - 2]);
            if (placeholder[placeholder.Length - 1] == '1' || placeholder[placeholder.Length - 1] == '2' || placeholder[placeholder.Length - 1] == '3' || placeholder[placeholder.Length - 1] == '4')
            {
                placeholder[placeholder.Length - 1] = '0';
            }
            else 
            {
                index++;
                placeholder[placeholder.Length - 2] = Convert.ToChar(index);
                placeholder[placeholder.Length - 1] = ' ';
            }

            string finalValueString = "";
            for (int x = 0; x < placeholder.Length; x++)
            {
                finalValueString = String.Concat(finalValueString, placeholder[x]);
            }
            float finalRound = float.Parse(finalValueString);

            return finalRound;
        }
    }
    class ProgramDriver
    {
        static void Main(string[] args)
        {
            float x = 1237.9166637f; int y = 4;

            float newfor = newMath.round(x, y);
            Console.WriteLine(newfor);
;       }
    }
}