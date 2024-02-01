using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4
{
    internal class Board
    {
        public void printBoard(string[][] boardLayout)
        {
            Console.WriteLine("\tA\t" + "B\t" + "C");
            for (int i = 0; i < boardLayout.Length; i++)
            {
                Console.Write((i + 1) + ":\t");
                for (int j = 0; j < boardLayout[i].Length; j++)
                {
                    Console.Write(boardLayout[j][i]+"\t");
                }

                Console.WriteLine();
            }
        }

        public string checkWinner(string[][] boardLayout)
        {
            for (int i = 0; i < boardLayout.Length; i++)
            {
                if (checkRowCol(boardLayout[i], "o")) {
                    return "o";
                } else if (checkRowCol(boardLayout[i], "x"))
                {
                    return "x";
                }
            }

            for (int i = 0; i < boardLayout[0].Length; i++)
            {
                string[] row = [boardLayout[0][i], boardLayout[1][i], boardLayout[2][i]];
                if (checkRowCol(row, "o"))
                {
                    return "o";
                } else if (checkRowCol(row, "x")) {
                    return "x";
                }
            }

            string[] diagonal1 = new string[3];

            for (int i = 0; i < boardLayout[0].Length; i++)
            {
                diagonal1[i] = boardLayout[i][i]; 
            }


            if (checkRowCol(diagonal1, "o"))
            {
                return "o";
            }
            else if (checkRowCol(diagonal1, "x"))
            {
                return "x";
            }

            string[] diagonal2 = new string[3];

            for (int i = 2; i < boardLayout[0].Length; i--)
            {
                diagonal2[i] = boardLayout[i][i];
            }


            if (checkRowCol(diagonal2, "o"))
            {
                return "o";
            }
            else if (checkRowCol(diagonal2, "x"))
            {
                return "x";
            }
            return "-";
        }

        private bool checkRowCol(string[] column, string token)
        {
            for (int i = 0; i < column.Length; i++)
            {
                if (column[i] != token)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
