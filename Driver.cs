using System.Data;
using TicTacToe;

Support support = new Support();


bool gameOver = false;

//support.PrintBoard();
//support.CheckWinner();

System.Console.WriteLine("Welcome to the Game!");
string[] board = new string[9];
//Print board key
System.Console.WriteLine("1 | 2 | 3");
System.Console.WriteLine("----------");
System.Console.WriteLine("4 | 5 | 6");
System.Console.WriteLine("----------");
System.Console.WriteLine("7 | 8 | 9");


do
{
    Console.WriteLine("Player 1 Turn");
    string player1 = Console.ReadLine();
    while (board[int.Parse(player1) - 1] == "X" || board[int.Parse(player1) - 1] == "O")
    {
        Console.WriteLine("Spot is already taken. Please enter a new value: ");
        player1 = Console.ReadLine();

    };
   
 
    board[(int.Parse(player1) - 1)] = "X";
    board.ToList().ForEach(x => Console.WriteLine(x));

    Console.WriteLine("Player 2 Turn");
    string player2 = Console.ReadLine();
    while (board[int.Parse(player2) - 1] == "X" || board[int.Parse(player2) - 1] == "O")
    {
        Console.WriteLine("Spot is already taken. Please enter a new value:");
        player2 = Console.ReadLine();
    };


    board[(int.Parse(player2) - 1)] = "O";
    board.ToList().ForEach(x => Console.WriteLine(x));

    //PrintBoard()
    //CheckWinner()







    //update board array
    // 
} while (!gameOver);
