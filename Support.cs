using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Support
{
    public void PrintBoard(string[] board)
    {
        int size = 3;
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                // board array
                int index = row * size + col;
                string value = string.IsNullOrEmpty(board[index]) ? (index + 1).ToString() : board[index];

                // Print the value 
                Console.Write(value);
                if (col < size - 1)
                {
                    Console.Write(" | ");
                }
            }

            // Row separator
            if (row < size - 1)
            {
                Console.WriteLine("\n---------");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
        public string CheckWinner(string[] board)
    {
        // Define all winning combinations
        int[,] winningCombinations = new int[,]
        {
            {0, 1, 2}, // Row 1
            {3, 4, 5}, // Row 2
            {6, 7, 8}, // Row 3
            {0, 3, 6}, // Column 1
            {1, 4, 7}, // Column 2
            {2, 5, 8}, // Column 3
            {0, 4, 8}, // Diagonal 1
            {2, 4, 6}  // Diagonal 2
        };

        // Iterate through all winning combinations
        for (int i = 0; i < winningCombinations.GetLength(0); i++)
        {
            // Check if all positions in a combination are occupied by the same player and are not empty
            if (!string.IsNullOrEmpty(board[winningCombinations[i, 0]]) &&
                board[winningCombinations[i, 0]] == board[winningCombinations[i, 1]] &&
                board[winningCombinations[i, 1]] == board[winningCombinations[i, 2]])
            {
                // Return the winner based on the value in the winning position
                return board[winningCombinations[i, 0]] == "1" ? "Player 2 Wins" : "Player 1 Wins";
            }
        }

        // Check for draw or ongoing game
        bool isDraw = true;
        for (int i = 0; i < board.Length; i++)
        {
            if (string.IsNullOrEmpty(board[i])) // Check if any position is still empty
            {
                isDraw = false;
                break;
            }
        }

        return isDraw ? "Draw" : "None";
    }
}
