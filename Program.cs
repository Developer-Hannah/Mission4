


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
bool guessValidation = false;
Board board = new Board();
string winner = board.checkWinner(grid);
string[] acceptableInputs = { "A1", "B1", "C1", "A2", "B2", "C2", "A3", "B3", "C3" };

// Welcome the user
Console.WriteLine("Welcome to the game! Player 1 is Xs and player 2 is Os");

// Give user guideance
Console.WriteLine("Please enter your selection by typing the column letter followed by the row number (I.E: A1) ");

board.printBoard(grid);

// ensure that the number of turns does not go beyound 9
for (int iCount = 0; iCount < 9; iCount++)
{
    // Ask each player in turn for their choice 
    if (iCount == 0 || iCount == 2 || iCount == 4 || iCount == 6 || iCount == 8)
    {
        Console.WriteLine("Player 1 please take your turn");
        p1guess = Console.ReadLine().ToUpper();
        guessValidation = false;

        // make sure player 1's user input is valid
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

        // assign an x to game board in correllation with player 1's input
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
            // display message and redo player 1's turn if they choose a position on game board that has already been chosen
            Console.WriteLine("That spot is taken");
            iCount--;
        }

        // call the printBoard function to print the game board with updated position placements
        board.printBoard(grid);

        // call the winner function to check for winner and end game if applicable
        winner = board.checkWinner(grid);
        if (winner != "-")
        {
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

            // make sure player 2's user input is valid
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

            // assign an o to game board in correllation with player 2's input
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
                // display message and redo player 1's turn if they choose a position on game board that has already been chosen
                Console.WriteLine("That spot is taken");
                iCount--;
            }

            // call the winner function to check for winner and end game if applicable
            winner = board.checkWinner(grid);
            // call the printBoard function to print the game board with updated position placements
            board.printBoard(grid);
            if (winner != "-")
            {
                iCount = 9;
            }

        }
    }

}
// call winner funchtion to check for draw
if (winner == "-")
{
    Console.WriteLine("Draw!");
}
// call winner funchtion to diplay the name of winner
else
{
    Console.WriteLine(winner);
}


// Print the final board
board.printBoard(grid);



