using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Support
    {
        public string CheckWinner(char[,] board)
        {
            // Check rows and columns
            for (int i = 0; i < 3; i++)
            {
                // Check rows
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != ' ')
                {
                    return board[i, 0].ToString();
                }

                // Check columns
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != ' ')
                {
                    return board[0, i].ToString();
                }
            }

            // Check diagonals
            if ((board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] ||
                 board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0]) && board[1, 1] != ' ')
            {
                return board[1, 1].ToString();
            }

            // Check for draw or ongoing game
            bool isDraw = true;
            foreach (char spot in board)
            {
                if (spot == ' ')
                {
                    isDraw = false;
                    break;
                }
            }

            return isDraw ? "Draw" : "None";
        }
    }
}
