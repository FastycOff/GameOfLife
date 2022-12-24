using System;

using System.Threading;

namespace GameOfLife
{
    public class GameOfLife
    {
        static void Main(string[] args)
        {
            int Gen = 0;
            Controller.Arrays.Fill();
            while (true)
            {
                Controller.Moves.Do(); // просчитывание ходов
                Controller.Arrays.Print(); // Вывод всех точек
                Gen++;
                Console.WriteLine("Generation:" + Gen);
                Thread.Sleep(25);
            }
        }
    }
}
