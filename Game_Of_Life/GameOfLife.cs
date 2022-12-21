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
            string[,] Map = new string[Share.Size+1, Share.Size+1];
            Controller.Arrays.Fill(Map);
            while (true)
            {
                Map = Controller.Moves.Do(Map); // просчитывание ходов
                Controller.Arrays.Print(Map); // Вывод всех точек
                Gen++;
                Console.WriteLine("Generation:" + Gen);
                Thread.Sleep(250);
            }
        }
    }
}
