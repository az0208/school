using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ggfez123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 5, 9, 12, 15, 18, 21 };
            Console.WriteLine(IsArithmetic2(arr, 5));
        }
        public static bool IsArithmetic2(int[] arr, int i)
        {
            if (IsArithemetic(arr, i) == -1)
            {
                return false;
            }
            return true;
        }
        public static int IsArithemetic(int[] arr, int i)
        {
            if (i == arr.Length - 2)
            {
                return arr[i + 1] - arr[i];
            }
            if (arr[i+1] -  arr[i] == IsArithemetic(arr, i + 1))
            {
                return arr[i + 1] - arr[i];
            }
            return -1;
        }

    }
}
