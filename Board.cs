using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  Board - Supporting class for TicTacToe
 *  Provides functionality for printing the TicTacToe board and for checking for a winner
 *  This class authored by Joseph Fuge and Cameron Klepacz
 *  Section 4 Group 4
 */

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
            // Check columns for winning
            for (int i = 0; i < boardLayout.Length; i++)
            {
                if (checkRowCol(boardLayout[i], "o")) {
                    return "o";
                } else if (checkRowCol(boardLayout[i], "x"))
                {
                    return "x";
                }
            }

            // Check rows for winning
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

            // Check for winning across the top-left to bottom-right diagonal
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

            // Check for winning across the top-right to bottom-left diagonal
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

            // If noone won yet, return -
            return "-";
        }
        
        // Check to see if all strings in array match the passed in string (which should be "o" or "x")
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
