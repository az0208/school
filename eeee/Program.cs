using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eeee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[6] { 12, 34, 56, 62, 45, 62 };
            Console.WriteLine(Mistery2(a, 1, 4));
        }
        public static int Mistery1(int num, int i)
        {
            if (num == 0)
                return 0;
            int digit = num % 10;

            if (digit % 2 == 0)
                return digit * i + Mistery1(num / 10, i);

            return Mistery1(num / 10, i);
        }
        public static int Mistery2(int[] arr, int s, int e)
        {
            if (s == e)
                return Mistery1(arr[s], s);

            int fVal = Mistery1(arr[s], s);
            int rVal = Mistery2(arr, s + 1, e);

            if (fVal > rVal)
                return fVal;
            return rVal;
        }


    }
}
