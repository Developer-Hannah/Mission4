
//Board class
//printBoard([[], [], []]) method

// Create an array to hold each of three lines of the grid
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Mission4;

// initialize array
string[][] grid = new string[3][];
grid[0] = new string[] { "-", "-", "-" };
grid[1] = new string[] { "-", "-", "-" };
grid[2] = new string[] { "-", "-", "-" };

// initialize other varriables
string[] possibleGuesses = new string[9];
string p1guess = "";
string p2guess = "";
string winner;
bool guessValidation = false;
Board board = new Board();
string[] acceptableInputs = { "A1", "B1", "C1", "A2", "B2", "C2", "A3", "B3", "C3" };

// Welcome the user
Console.WriteLine("Welcome to the game! Player 1 is Xs and player 2 is Os");

// Give user guideance
Console.WriteLine("Please enter your selection by typing the column letter followed by the row number (I.E: A1) ");

board.printBoard(grid);

for (int iCount = 0; iCount < 9; iCount++)
{
    // Ask each player in turn for their choice 
    

    if (iCount == 0 || iCount == 2 || iCount == 4 || iCount == 6 || iCount == 8)
    {
        Console.WriteLine("Player 1 please take your turn");
        p1guess = Console.ReadLine().ToUpper();
        guessValidation = false;

        while (guessValidation == false)
        {
            if (acceptableInputs.Contains(p1guess))
            {
                guessValidation = true;
            }
            else
            {
                Console.WriteLine("Please enter a valid input by typing the column letter followed by the row number (I.E: A1)");
                p1guess = Console.ReadLine().ToUpper();
            }


        }

        if (p1guess == "A1" && grid[0][0] == "-")
        {
            grid[0][0] = "x";
        }
        else if (p1guess == "B1" && grid[1][0] == "-")
        {
            grid[1][0] = "x";
        }
        else if (p1guess == "C1" && grid[2][0] == "-")
        {
            grid[2][0] = "x";
        }
        else if (p1guess == "A2" && grid[0][1] == "-")
        {
            grid[0][1] = "x";
        }
        else if (p1guess == "B2" && grid[1][1] == "-")
        {
            grid[1][1] = "x";
        }
        else if (p1guess == "C2" && grid[2][1] == "-")
        {
            grid[2][1] = "x";
        }
        else if (p1guess == "A3" && grid[0][2] == "-")
        {
            grid[0][2] = "x";
        }
        else if (p1guess == "B3" && grid[1][2] == "-")
        {
            grid[1][2] = "x";
        }
        else if (p1guess == "C3" && grid[2][2] == "-")
        {
            grid[2][2] = "x";
        }
        else
        {
            Console.WriteLine("That spot is taken");
            iCount--;
        }


        board.printBoard(grid);

        //grid[0][1] = "x";
        //Console.Write(B1);
        //Console.WriteLine(grid[0][1]);
        winner = board.checkWinner(grid);

        if (winner == "x")
        {
            Console.WriteLine("Player 1 wins!!");
            iCount = 9;
        }
        if (winner == "o")
        {
            Console.WriteLine("Player 2 wins!!");
            iCount = 9;
        }
    }
    else
    {
        if (iCount < 9)
        {
            Console.WriteLine("Player 2 please take your turn");
            p2guess = Console.ReadLine().ToUpper();

            guessValidation = false;

            while (guessValidation == false)
            {
                if (acceptableInputs.Contains(p2guess))
                { guessValidation = true; }
                else
                {
                    Console.WriteLine("Please enter a valid input by typing the column letter followed by the row number (I.E: A1)");
                    p2guess = Console.ReadLine().ToUpper();
                }


            }


            if (p2guess == "A1" && grid[0][0] == "-")
            {
                grid[0][0] = "o";
            }
            else if (p2guess == "B1" && grid[1][0] == "-")
            {
                grid[1][0] = "o";
            }
            else if (p2guess == "C1" && grid[2][0] == "-")
            {
                grid[2][0] = "o";
            }
            else if (p2guess == "A2" && grid[0][1] == "-")
            {
                grid[0][1] = "o";
            }
            else if (p2guess == "B2" && grid[1][1] == "-")
            {
                grid[1][1] = "o";
            }
            else if (p2guess == "C2" && grid[2][1] == "-")
            {
                grid[2][1] = "o";
            }
            else if (p2guess == "A3" && grid[0][2] == "-")
            {
                grid[0][2] = "o";
            }
            else if (p2guess == "B3" && grid[1][2] == "-")
            {
                grid[1][2] = "o";
            }
            else if (p2guess == "C3" && grid[2][2] == "-")
            {
                grid[2][2] = "o";
            }
            else
            {
                Console.WriteLine("That spot is taken");
                iCount--;
            }

            board.printBoard(grid);

            winner = board.checkWinner(grid);

            if (winner == "x")
            {
                Console.WriteLine("Player 1 wins!!");
                iCount = 9;
            }
            if (winner == "o")
            {
                Console.WriteLine("Player 2 wins!!");
                iCount = 9;
            }
        }
    }

}



// Print the board by calling the method in the supporting class
board.printBoard(grid);

//Check for a winnner by calling the method in the supporting class, and notify the players 
//when a win has occurred and which player won the game


