using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{    public partial class Arrays
    {
        public static void Print(string[,] arr)
        {
            Console.Clear();
            for (int y = 0; y < Share.Size+1; ++y)
            {
                for (int x = 0; x < Share.Size+1; ++x)
                {
                    Console.Write(arr[y, x]);
                }
                Console.Write("\n");
            }
        }
    }
}
