using System;
namespace Othello_Visual
{

	public enum CounterColour { None, Black, White };

	public class CreateBoard
	{

		public CounterColour[,] Board { get; private set; } // 2D array declaration to represent the board itself.
		public CounterColour CurrentP { get; private set; } // initialise field to be specific to the move of the current player.
		public bool GameOver { get; private set; } // bool field which will determine whether to end the game or not.

		public CreateBoard() // public constructor
		{
			Board = new CounterColour[8, 8]; // setting a new instance of the Counter which will act as the board for the game.
			CurrentP = CounterColour.Black; // according to Mattel, black always moves first. Therefore, I should set the first move to black.
			InitialiseBoard(); // once the board array has been declared a value and the beginning player has been declared a colour, it's time to call the method to set the board's appearance in terms of colours and the positions they will sit in on the board.
			GameOver = false;
		}

		public bool ValidMove(int row, int col) // check if the current move to be made is legal. Takes in the two parameters row and col in order to gather the co-ordinates to the current position
		{
			if (row < 0 || row >= 8 || col < 0 || col >= 8 || Board[row, col] != CounterColour.None) // ensure that there are no border/boundary issues with the next move. Board[row, col] != CounterColour.None is a very important
            {																					     // condition as it checks to see if there is a counter already at the position that the current counter wants to move into.
				return false;
			}

			for (int tmr = -1; tmr <= 1; tmr++) // these values are to check the positions that are one row above and one column to the left of the counter's current position. Refers to delta row and delta columns
			{                                   // we do this to determine whether there's at least one valid capture to be made around a potential move.
				for (int tmc = -1; tmc <= 1; tmc++)
				{
					if (tmr == 0 && tmc == 0)
					{
						continue; // skip current position as it means that no capture has been found and so the next iteration should take place.
					}

					int checkRow = row + tmr; // these new variables are to store the positions adjacent of the current counter positions stored at row and col.
					int checkCol = col + tmc; // this allows the code to examine if the move is valid, as well as to determine if there are any opponent pieces to capture.
					bool opponentFound = false; // new variable that will be set to true whenever an opponent has been found to the specific position the counter is moving to.


					while (checkRow >= 0 && checkRow < 8 && checkCol >= 0 && checkCol < 8)
					{
						if (Board[checkRow, checkCol] == CounterColour.None)
						{
							break; // if there is nothing at the position then the move is not valid, meaning we should break out of the loop
						}
						if (Board[checkRow, checkCol] == CurrentP) // try to set this to && with the other if statement below once working.
						{
							if (opponentFound) // if we have found at least one of the opponent's pieces as well as the current player's, then the move is valid.
							{
								return true;
							}
							else
							{
								break; // if the opponent's piece wasn't found before the current player's own, the move is not valid.
							}
						}
						else
						{
							opponentFound = true; // at least one opponent piece has been found in this direction. 
						}
					}
				}
			}

            return false; // if no direction led to the capture of the opponent's piece, the move is not valid.
        }

		public void InitialiseBoard()
		{
			for (int row = 0; row < 8; row++)
			{
				for (int col = 0; col < 8; col++)
				{
					Board[row, col] = CounterColour.None; // initialise the board with the starting positions and set all positions to be empty
				}
			}

			Board[3, 3] = Board[4, 4] = CounterColour.White; // setting up the starting counters for both black and white
			Board[3, 4] = Board[4, 3] = CounterColour.Black;
		}

		public void Move(int row, int col) // this function handles the actual move. It is very similar to the ValidMove function, acting only if the move actually is valid.
		{
			if (ValidMove(row, col))
			{
				Board[row, col] = CurrentP; // place the piece of the current player on the board if valid

				for (int tmr = -1; tmr <= 1; tmr++)
				{
					for (int tmc = -1; tmc <= 1; tmc++)
					{
						if (tmr == 0 && tmc == 0)
						{
							continue; // skip whatever position it is currently at.
						}

						int checkRow = row + tmr;
						int checkCol = col + tmc;

						while (checkRow >= 0 && checkRow < 8 && checkCol >= 0 && checkCol < 8 && Board[checkRow, checkCol] != CurrentP)
						{
							if (Board[checkRow, checkCol] == CurrentP)
							{
								break; // if the piece being moved encounters the current player's own piece, stop swapping them.
							}

							checkRow += tmr; // move to the next position in this direction specified by tmr and tmc
							checkCol += tmc; 
						}
					}
				}

				CurrentP = (CurrentP == CounterColour.Black) ? CounterColour.White : CounterColour.Black; // switch to the other player's turn. Ternary operator states that if the current player is equal to black then set it to white else set it to black.
			}
		}
	}
}

/* ---- KEY ----
 * tmr = TIMES MOVED in ROW
 * tmc = TIMES MOVED in COLUMN
*/


// improvement, declaration of a place on the board without a counter. None sounds like it could
// annote to the reference null, which means that no object has been referred to.

// improvement, change placement of methods such as InitialiseBoard, to make it easier for other developers to read and interpret without having to scroll far down