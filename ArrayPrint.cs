using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrint
{
    class ArrayPrint
    {
        static void Main(string[] args)
        {
        }
    }
    public class Array
    {
        public static void Print(string[,] arr)
        {
            for (int y = 0; y < Share.Params.Size+1; ++y)
            {
                for (int x = 0; x < Share.Params.Size+1; ++x)
                {
                    Console.Write(arr[y, x]);
                }
                Console.Write("\n");
            }
        }
    }
}
