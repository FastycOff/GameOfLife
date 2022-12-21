using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public partial class Moves
    {
        public static int Precalculate(string[,] arr, int x, int y)
        {
            int n = 0;
            if (y == 0 & x == 0)
            {
                n += (arr[y, x + 1] == "o") ? 1 : 0;
                n += (arr[y + 1, x] == "o") ? 1 : 0;
                n += (arr[y + 1, x+1] == "o") ? 1 : 0;
            }
            else if (y == 0 & x < Share.Params.Size)
            {
                n += (arr[y, x + 1] == "o") ? 1 : 0;
                n += (arr[y, x - 1] == "o") ? 1 : 0;
                n += (arr[y + 1, x] == "o") ? 1 : 0;
                n += (arr[y + 1, x - 1] == "o") ? 1 : 0;
                n += (arr[y + 1, x + 1] == "o") ? 1 : 0;
            }
            else if (x == 0 & y < Share.Params.Size)
            {
                n += (arr[y - 1, x] == "o") ? 1 : 0;
                n += (arr[y + 1, x] == "o") ? 1 : 0;
                n += (arr[y, x + 1] == "o") ? 1 : 0;
                n += (arr[y + 1, x + 1] == "o") ? 1 : 0;
                n += (arr[y - 1, x + 1] == "o") ? 1 : 0;
            }
            else if (y == Share.Params.Size & x == Share.Params.Size)
            {
                n += (arr[y - 1, x] == "o") ? 1 : 0;
                n += (arr[y, x - 1] == "o") ? 1 : 0;
                n += (arr[y - 1, x - 1] == "o") ? 1 : 0;

            }
            else if (x == Share.Params.Size & y == 0)
            {
                n += (arr[y, x - 1] == "o") ? 1 : 0;
                n += (arr[y + 1, x] == "o") ? 1 : 0;
                n += (arr[y + 1, x-1] == "o") ? 1 : 0;
            }
            //
            else if (x == 0 & y == Share.Params.Size)
            {
                n += (arr[y - 1, x] == "o") ? 1 : 0;
                n += (arr[y, x + 1] == "o") ? 1 : 0;
                n += (arr[y - 1, x + 1] == "o") ? 1 : 0;

            }
            //
            else if (y == Share.Params.Size & x < Share.Params.Size)
            {
                n += (arr[y - 1, x] == "o") ? 1 : 0;
                n += (arr[y, x - 1] == "o") ? 1 : 0;
                n += (arr[y, x + 1] == "o") ? 1 : 0;
                n += (arr[y - 1, x - 1] == "o") ? 1 : 0;
                n += (arr[y - 1, x + 1] == "o") ? 1 : 0;

            }
            else if (x == Share.Params.Size & y < Share.Params.Size)
            {
                n += (arr[y, x - 1] == "o") ? 1 : 0;
                n += (arr[y - 1, x] == "o") ? 1 : 0;
                n += (arr[y + 1, x] == "o") ? 1 : 0;
                n += (arr[y - 1, x-1] == "o") ? 1 : 0;
                n += (arr[y + 1, x-1] == "o") ? 1 : 0;
            }
            else
            {
                n += (arr[y - 1, x] == "o") ? 1 : 0;
                n += (arr[y + 1, x] == "o") ? 1 : 0;
                n += (arr[y, x + 1] == "o") ? 1 : 0;
                n += (arr[y, x - 1] == "o") ? 1 : 0;
                n += (arr[y - 1, x - 1] == "o") ? 1 : 0;
                n += (arr[y + 1, x + 1] == "o") ? 1 : 0;
                n += (arr[y - 1, x + 1] == "o") ? 1 : 0;
                n += (arr[y + 1, x - 1] == "o") ? 1 : 0;
            }
            return n;
        }
        public static int[] todel = new int[2];
        public static int[] toadd = new int[2];
        public static void Check(string[,] arr)
        {
            toadd = new int[(Share.Params.Size* Share.Params.Size +1)*2];
            todel = new int[(Share.Params.Size* Share.Params.Size +1)*2];
            int delpointer = 0, addpointer = 0;
            for(int y = 0; y < Share.Params.Size+1; ++y)
            {
                for(int x = 0; x < Share.Params.Size+1; ++x)
                {
                    switch (Moves.Precalculation(arr, x, y))
                    {
                        case 0: todel[delpointer] = y; todel[++delpointer] = x; ++delpointer; break;
                        case 1: todel[delpointer] = y; todel[++delpointer] = x; ++delpointer; break;
                        case 2: break;
                        case 3: toadd[addpointer] = y; toadd[++addpointer] = x; ++addpointer; break;
                        default: todel[delpointer] = y; todel[++delpointer] = x; ++delpointer; break;
                    }
                }
            }
        }
    }
}
