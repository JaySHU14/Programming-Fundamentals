namespace Othello_Visual
{
	public partial class OthelloVisual : Form
	{
		private CreateBoard board;
		private bool gameOver = false;
		private Button[,] buttons;

		public OthelloVisual() // constructor initialising visual objects
		{
			// InitialiseComponent();
			board = new CreateBoard();
			ConfigureBoard();
		}

		private void ConfigureBoard()
		{
			buttons = new Button[8, 8]; // create new buttons to represent every value on the board

			for (int row = 0; row < 8; row++)
			{
				for (int col = 0; col < 8; col++)
				{
					buttons[row, col] = new Button()
					{
						Size = new System.Drawing.Size(50, 50), //manipulating size of buttons (width, height)
						Location = new System.Drawing.Point(row, col), // manipulating actual button location to the position of the specific row and column
						Tag = new Tuple<int, int>(row, col),
						Enabled = false,
					};

					buttons[row, col].Click += OnButtonClick;
					Controls.Add(buttons[row, col]);
				}
			}

			ValidMoves(); // update the valid moves every time the board has been run
		}

		private void OnButtonClick(object sender, EventArgs e)
		{
			var button = (Button)sender;
			var Position = (Tuple<int, int>)button.Tag;
			int row = Position.Item1;
			int col = Position.Item2;

			if (board.ValidMove(row, col))
			{
				board.Move(row, col);
				UpdateBoard();
				ValidMoves(); // update valid moves

				if (board.GameOver)
				{
					// CounterColour winner = board.DeclareWinner();
					// string finalResult = winner == CounterColour.None ? "It's a draw!" : $"{winner} is the winner!";
					// MessageBox.Show(finalResult, "Game Over.");
				}
			}
		}

		private void UpdateBoard()
		{
			for (int row = 0; row <= 8; row++)
			{
				for (int col = 0; col <= 8; col++)
				{
					buttons[row, col].Text = FindText(board.Board[row, col]);
				}
			}
		}

		private string FindText(CounterColour counter)
		{
			return counter == CounterColour.Black ? "B" : counter == CounterColour.White ? "W": string.Empty;
		}

		private void ValidMoves() // handles the updating of a move if it is valid. 
		{
			for (int row = 0; row < 8; row++)
			{
				for (int col = 0; col <= 8; col++)
				{
					buttons[row, col].Enabled = board.ValidMove(row, col);
				}
			}
		}

		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			Application.Run(new OthelloVisual());
		}

	}
}
