using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public partial class Moves
    {
        public static string[,] Do(string[,] arr, int[] toadd, int[] todel)
        {
            short coord = 0;
            int y=0, x=0;
            foreach(int i in toadd)
            {
                if (coord == 0)
                {
                    y = i;
                    coord = 1;
                }
                else
                {
                    x = i;
                    coord = 0;
                    arr[y, x] = "o";
                }
            }
            coord = 0;
            foreach (int i in todel)
            {
                if (coord == 0)
                {
                    y = i;
                    coord = 1;
                }
                else
                {
                    x = i;
                    coord = 0;
                    arr[y, x] = " ";
                }
            }
            return arr;
        }
    }

}
