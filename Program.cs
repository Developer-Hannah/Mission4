
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
string winner;
bool turnTaken = true;
Board board = new Board();

//string A1 = grid[0][0];
//string B1 = grid[0][1];
//string C1 = grid[0][2];
//string A2 = grid[1][0];
//string B2 = grid[1][1];
//string C2 = grid[1][2];
//string A3 = grid[2][0];
//string B3 = grid[2][1];
//string C3 = grid[2][2];

// Welcome the user
Console.WriteLine("Welcome to the game!");

// Give user guideance
Console.WriteLine("Please enter your selection by typing the column letter followed by the row number (I.E: A1) ");

Console.WriteLine("   A, B, C");
Console.WriteLine("1: -, -, -");
Console.WriteLine("2: -, -, -");
Console.WriteLine("3: -, -, -");

for (int iCount = 0; iCount < 9; iCount++)
{
    // Ask each player in turn for their choice 
    Console.WriteLine("Player 1 please take your turn");
    p1guess = Console.ReadLine().ToUpper();
    turnTaken = true;
    while(turnTaken == true)
    {
        if (p1guess == "A1" && grid[0][0] == "-")
        {
            grid[0][0] = "x";
            turnTaken = false;
        }
        else if (p1guess == "B1" && grid[1][0] == "-")
        {
            grid[1][0] = "x";
            turnTaken = false;
        }
        else if (p1guess == "C1" && grid[2][0] == "-")
        {
            grid[2][0] = "x";
            turnTaken = false;
        }
        else if (p1guess == "A2" && grid[0][1] == "-")
        {
            grid[0][1] = "x";
            turnTaken = false;
        }
        else if (p1guess == "B2" && grid[1][1] == "-")
        {
            grid[1][1] = "x";
            turnTaken = false;
        }
        else if (p1guess == "C2" && grid[2][1] == "-")
        {
            grid[2][1] = "x";
            turnTaken = false;
        }
        else if (p1guess == "A3" && grid[0][2] == "-")
        {
            grid[0][2] = "x";
            turnTaken = false;
        }
        else if (p1guess == "B3" && grid[1][2] == "-")
        {
            grid[1][2] = "x";
            turnTaken = false;
        }
        else if (p1guess == "C3" && grid[2][2] == "-")
        {
            grid[2][2] = "x";
            turnTaken = false;
        }
        else
            Console.WriteLine("That spot is taken");
    }
    

    board.printBoard(grid);

    iCount++;

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

    

    if(iCount < 9)
    {
        Console.WriteLine("Player 2 please take your turn");
        p1guess = Console.ReadLine().ToUpper();
        turnTaken = true;

        while (turnTaken == true)
        {
            if (p1guess == "A1" && grid[0][0] == "-")
            {
                grid[0][0] = "o";
                turnTaken = false;
            }
            else if (p1guess == "B1" && grid[1][0] == "-")
            {
                grid[1][0] = "o";
                turnTaken = false;
            }
            else if (p1guess == "C1" && grid[2][0] == "-")
            {
                grid[2][0] = "o";
                turnTaken = false;
            }
            else if (p1guess == "A2" && grid[0][1] == "-")
            {
                grid[0][1] = "o";
                turnTaken = false;
            }
            else if (p1guess == "B2" && grid[1][1] == "-")
            {
                grid[1][1] = "o";
                turnTaken = false;
            }
            else if (p1guess == "C2" && grid[2][1] == "-")
            {
                grid[2][1] = "o";
                turnTaken = false;
            }
            else if (p1guess == "A3" && grid[0][2] == "-")
            {
                grid[0][2] = "o";
                turnTaken = false;
            }
            else if (p1guess == "B3" && grid[1][2] == "-")
            {
                grid[1][2] = "o";
                turnTaken = false;
            }
            else if (p1guess == "C3" && grid[2][2] == "-")
            {
                grid[2][2] = "o";
                turnTaken = false;
            }
            else
                Console.WriteLine("That spot is taken");

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


