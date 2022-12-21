namespace Controller
{
    public partial class Moves
    {
        public static string[,] Do(string[,] arr)
        {
            string[,] Map2 = new string[Share.Size+1, Share.Size+1];
            for(int y = 0; y < Share.Size+1; ++y)
            {
                for(int x = 0; x < Share.Size+1; ++x)
                {
                    switch (Moves.Precalculate(arr, x, y))
                    {
                        case 2: Map2[y,x] = arr[y,x]; break;
                        case 3: Map2[y,x] = "o"; break;
                        default: Map2[y,x] = " "; break;
                    }
                }
            }
            return Map2;
        }
    }


}