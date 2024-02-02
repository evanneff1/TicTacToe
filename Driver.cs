using System.Data;

//Instatiate other class
Support Support = new Support();

//Declare variables
bool gameOver = false;
string[] board = new string[9];
bool valid = false;
string[] validValues = ["1", "2", "3", "4", "5", "6", "7", "8", "9"];

//support.PrintBoard();
//support.CheckWinner();

//Welcome to game
System.Console.WriteLine("Welcome to the Game!\n\nHere is the game board layout");

//Print board key
System.Console.WriteLine("1 | 2 | 3");
System.Console.WriteLine("----------");
System.Console.WriteLine("4 | 5 | 6");
System.Console.WriteLine("----------");
System.Console.WriteLine("7 | 8 | 9\n");

//Play game loop
do
{
    //Player one turn
    Console.WriteLine("Player 1 Turn\nPlease enter the number of the position in which you would like to place your mark");
    string player1 = Console.ReadLine();
    valid = false;

    //Check for valid input
    while (valid == false)
    {
        if (!validValues.Contains(player1))
        {
            Console.WriteLine("Invalid input. Please enter a valid number 1-9:");
            player1 = Console.ReadLine();
        }
        else if (board[int.Parse(player1) - 1] == "X" || board[int.Parse(player1) - 1] == "O")
        {
            Console.WriteLine("Spot is already taken. Please enter a new value:");
            player1 = Console.ReadLine();
        }
        else
        {
            valid = true;
        }


    };

    //Place marker and show updated board
    board[(int.Parse(player1) - 1)] = "X";
    //board.ToList().ForEach(element => Console.Write(element));
    //Support.PrintBoard(board)
    Console.WriteLine(Support.CheckWinner(board));

    //Player 2 turn
    Console.WriteLine("Player 2 Turn\nPlease enter the number of the position in which you would like to place your mark");
    string player2 = Console.ReadLine();
    valid = false;

    //Check valid input
    while (valid == false)
    {
        if (!validValues.Contains(player2))
        {
            Console.WriteLine("Invalid input. Please enter a valid number 1-9:");
            player2 = Console.ReadLine();
        }
        else if (board[int.Parse(player2) - 1] == "X" || board[int.Parse(player2) - 1] == "O")
        {
            Console.WriteLine("Spot is already taken. Please enter a new value:");
            player2 = Console.ReadLine();
        }
        else
        {
            valid = true;
        }


    };

    //Place marker and show updated board
    board[(int.Parse(player2) - 1)] = "O";
    //board.ToList().ForEach(element => Console.Write(element));
    //Support.PrintBoard(board)
    Console.WriteLine(Support.CheckWinner(board));

} while (!gameOver);
