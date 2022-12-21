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
            else if (y == 0 & x < Share.Size)
            {
                n += (arr[y, x + 1] == "o") ? 1 : 0;
                n += (arr[y, x - 1] == "o") ? 1 : 0;
                n += (arr[y + 1, x] == "o") ? 1 : 0;
                n += (arr[y + 1, x - 1] == "o") ? 1 : 0;
                n += (arr[y + 1, x + 1] == "o") ? 1 : 0;
            }
            else if (x == 0 & y < Share.Size)
            {
                n += (arr[y - 1, x] == "o") ? 1 : 0;
                n += (arr[y + 1, x] == "o") ? 1 : 0;
                n += (arr[y, x + 1] == "o") ? 1 : 0;
                n += (arr[y + 1, x + 1] == "o") ? 1 : 0;
                n += (arr[y - 1, x + 1] == "o") ? 1 : 0;
            }
            else if (y == Share.Size & x == Share.Size)
            {
                n += (arr[y - 1, x] == "o") ? 1 : 0;
                n += (arr[y, x - 1] == "o") ? 1 : 0;
                n += (arr[y - 1, x - 1] == "o") ? 1 : 0;

            }
            else if (x == Share.Size & y == 0)
            {
                n += (arr[y, x - 1] == "o") ? 1 : 0;
                n += (arr[y + 1, x] == "o") ? 1 : 0;
                n += (arr[y + 1, x-1] == "o") ? 1 : 0;
            }
            //
            else if (x == 0 & y == Share.Size)
            {
                n += (arr[y - 1, x] == "o") ? 1 : 0;
                n += (arr[y, x + 1] == "o") ? 1 : 0;
                n += (arr[y - 1, x + 1] == "o") ? 1 : 0;

            }
            //
            else if (y == Share.Size & x < Share.Size)
            {
                n += (arr[y - 1, x] == "o") ? 1 : 0;
                n += (arr[y, x - 1] == "o") ? 1 : 0;
                n += (arr[y, x + 1] == "o") ? 1 : 0;
                n += (arr[y - 1, x - 1] == "o") ? 1 : 0;
                n += (arr[y - 1, x + 1] == "o") ? 1 : 0;

            }
            else if (x == Share.Size & y < Share.Size)
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
    }
}
