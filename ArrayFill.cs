using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFill
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Array
    {
        public static string[,] Fill(string[,] arr)
        {
            var rand = new Random();
            for (int y = 0; y < Share.Params.Size+1; ++y)
            {
                for (int x = 0; x < Share.Params.Size+1; ++x)
                {
                    arr[y, x] = (rand.Next(1, 7) == 1) ? "o" : " ";
                }
            }
            return arr;
        }
    }
}
