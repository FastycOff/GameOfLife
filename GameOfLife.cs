using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GameOfLife
{
    public class GameOfLife
    {
        static void Main(string[] args)
        {
            int Gen = 0;
            string[,] Map = new string[Share.Params.Size+1, Share.Params.Size+1];
            Controller.Arrays.Fill(Map);
            //uncomment and delete random in "ArrayFill to see glaider"
            // Map[4, 6] = "o"; 
            // Map[5, 7] = "o"; 
            // Map[6, 5] = "o"; 
            // Map[6,6] = "o"; 
            // Map[6, 7] = "o";
            while (true)
            {
                Controller.Moves.Check(Map); // просчитывание ходов
                Map = Controller.Moves.Do(Map, Controller.Moves.toadd, Controller.Moves.todel); // Выполнение ходов и сохранение в массив map

                Controller.Arrays.Print(Map); // Вывод всех точек
                Gen++;
                Console.WriteLine("Generation:" + Gen);
                Thread.Sleep(250);
            }
        }
    }
}
