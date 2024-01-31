using System.Data;
using TicTacToe;

//Instatiate other class
Support support = new Support();

//Declare variables
bool gameOver = false;
string[] board = new string[9];

//support.PrintBoard();
//support.CheckWinner();

//Welcome to game
System.Console.WriteLine("Welcome to the Game!");

//Print board key
System.Console.WriteLine("1 | 2 | 3");
System.Console.WriteLine("----------");
System.Console.WriteLine("4 | 5 | 6");
System.Console.WriteLine("----------");
System.Console.WriteLine("7 | 8 | 9");

//Play game loop
do
{
    //Player one turn
    Console.WriteLine("Player 1 Turn");
    string player1 = Console.ReadLine();

    //Check for valid input
    while (board[int.Parse(player1) - 1] == "X" || board[int.Parse(player1) - 1] == "O")
    {
        Console.WriteLine("Spot is already taken. Please enter a new value: ");
        player1 = Console.ReadLine();

    };
   
    //Place marker and show updated board
    board[(int.Parse(player1) - 1)] = "X";
    //Support.PrintBoard(board)
    //Support.CheckWinner(board)

    //Player 2 turn
    Console.WriteLine("Player 2 Turn");
    string player2 = Console.ReadLine();

    //Check valid input
    while (board[int.Parse(player2) - 1] == "X" || board[int.Parse(player2) - 1] == "O")
    {
        Console.WriteLine("Spot is already taken. Please enter a new value:");
        player2 = Console.ReadLine();
    };

    //Place marker and show updated board
    board[(int.Parse(player2) - 1)] = "O";
    //Support.PrintBoard(board)
    //Support.CheckWinner(board)

} while (!gameOver);
