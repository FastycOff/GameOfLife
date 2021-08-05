using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GameOfLife
{
    
    class GameOfLife
    {
        static void Main(string[] args)
        {
            int Gen = 0;
            string[,] map = new string[Share.Params.Size+1, Share.Params.Size+1];
            ArrayFill.Array.Fill(map);
            //uncomment and delete random in "ArrayFill to see glaider"
            //map[4, 6] = "o"; 
            //map[5, 7] = "o"; 
            //map[6, 5] = "o"; 
            //map[6,6] = "o"; 
            //map[6, 7] = "o";
            while (true)
            {
                MovesCheck.Move.Check(map);
                map = Move.Do.Move(map, MovesCheck.Move.toadd, MovesCheck.Move.todel);
                Console.Clear();
                ArrayPrint.Array.Print(map);
                Console.WriteLine($"Generation: {++Gen}");
                Thread.Sleep(150);
            }
        }
    }
}
