using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4
{
    internal class Board
    {
        public void printBoard(string[,] boardLayout)
        {
            Console.WriteLine("\tA\t" + "B\t" + "C");
            for (int i = 0; i < boardLayout.GetLength(0); i++)
            {
                Console.Write((i + 1) + ":\t");
                for (int j = 0; j < boardLayout.GetLength(1); j++)
                {
                    Console.Write(boardLayout[j, i]+"\t");
                }

                Console.WriteLine();
            }
        }
    }
}
