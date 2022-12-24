namespace Controller
{
    public partial class Moves
    {
        public static void Do()
        {
            string[,] Map2 = new string[Share.Size+1, Share.Size+1];
            for(int y = 0; y < Share.Size+1; ++y)
            {
                for(int x = 0; x < Share.Size+1; ++x)
                {
                    int neighbors = Moves.Calculate(x, y);
                    if (Share.Map[y,x] == " " && neighbors == 3) Map2[y,x] = "o";
                    else if (Share.Map[y,x] == "o" && (neighbors == 3 || neighbors == 2)) Map2[y,x] = "o";
                    else Map2[y,x] = " ";
                }
            }
            Share.Map = Map2;
        }
    }


}