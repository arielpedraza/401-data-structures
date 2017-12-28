using System;

namespace KataChessKnight
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int ChessKnight(string cell)
        {
            //coding and coding..

            int moves = 0;
            int alpha = 0;
            if (cell[0] == 'a') alpha = 1;
            if (cell[0] == 'b') alpha = 2;
            if (cell[0] == 'c') alpha = 3;
            if (cell[0] == 'd') alpha = 4;
            if (cell[0] == 'e') alpha = 5;
            if (cell[0] == 'f') alpha = 6;
            if (cell[0] == 'g') alpha = 7;
            if (cell[0] == 'h') alpha = 8;
            int num = Int32.Parse(cell[1].ToString());
            int[] cell1 = { -2, -2, -1, -1, 1, 1, 2, 2 };
            int[] cell2 = { 1, -1, 2, -2, 2, -2, 1, -1 };

            for (int i = 0; i < 8; i++)
            {
                if (alpha + cell1[i] >= 1 && alpha + cell1[i] <= 8)
                {
                    if (num + cell2[i] >= 1 && num + cell2[i] <= 8)
                    {
                        moves++;
                    }
                }
            }

            return moves;
        }
    }
}
