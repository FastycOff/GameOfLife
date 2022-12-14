using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public partial class Arrays
    {
        public static string[,] Fill(string[,] arr)
        {
            var rand = new Random();
            for (int y = 0; y < Share.Params.Size+1; ++y)
            {
                for (int x = 0; x < Share.Params.Size+1; ++x)
                {
                    arr[y, x] = (rand.Next(1, 11) == 1) ? "o" : " ";
                }
            }
            return arr;
        }
    }
}
