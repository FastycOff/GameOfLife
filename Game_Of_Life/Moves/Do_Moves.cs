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
                    int neighbors = Moves.Calculate(arr, x, y);
                    if (arr[y,x] == " " && neighbors == 3) Map2[y,x] = "o";
                    else if (arr[y,x] == "o" && (neighbors == 3 || neighbors == 2)) Map2[y,x] = "o";
                    else Map2[y,x] = " ";
                }
            }
            return Map2;
        }
    }


}