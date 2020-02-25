using Game_Logic_Class;
using Object_Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI_Class {
	public partial class SpaceRaceForm : Form {
		// The numbers of rows and columns on the screen.
		const int NUM_OF_ROWS = 7;
		const int NUM_OF_COLUMNS = 8;

		// When we update what's on the screen, we show the movement of a player 
		// by removing them from their old square and adding them to their new square.
		// This enum makes it clear that we need to do both.
		enum TypeOfGuiUpdate { AddPlayer, RemovePlayer };


		public SpaceRaceForm() {
			InitializeComponent();

			Board.SetUpBoard();
			ResizeGUIGameBoard();
			SetUpGUIGameBoard();
			SetupPlayersDataGridView();
			DetermineNumberOfPlayers();
			SpaceRaceGame.SetUp();
			PrepareToPlay();
		}


		/// <summary>
		/// Handle the Exit button being clicked.
		/// Pre:  the Exit button is clicked.
		/// Post: the game is terminated immediately
		/// </summary>
		private void exitButton_Click(object sender, EventArgs e) {
			Environment.Exit(0);
		}


		/// <summary>
		/// Resizes the entire form, so that the individual squares have their correct size, 
		/// as specified by SquareControl.SQUARE_SIZE.  
		/// This method allows us to set the entire form's size to approximately correct value 
		/// when using Visual Studio's Designer, rather than having to get its size correct to the last pixel.
		/// Pre:  none.
		/// Post: the board has the correct size.
		/// </summary>
		private void ResizeGUIGameBoard() {
			const int SQUARE_SIZE = SquareControl.SQUARE_SIZE;
			int currentHeight = tableLayoutPanel.Size.Height;
			int currentWidth = tableLayoutPanel.Size.Width;
			int desiredHeight = SQUARE_SIZE * NUM_OF_ROWS;
			int desiredWidth = SQUARE_SIZE * NUM_OF_COLUMNS;
			int increaseInHeight = desiredHeight - currentHeight;
			int increaseInWidth = desiredWidth - currentWidth;
			this.Size += new Size(increaseInWidth, increaseInHeight);
			tableLayoutPanel.Size = new Size(desiredWidth, desiredHeight);

		}// ResizeGUIGameBoard


		/// <summary>
		/// Creates a SquareControl for each square and adds it to the appropriate square of the tableLayoutPanel.
		/// Pre:  none.
		/// Post: the tableLayoutPanel contains all the SquareControl objects for displaying the board.
		/// </summary>
		private void SetUpGUIGameBoard() {
			for (int squareNum = Board.START_SQUARE_NUMBER; squareNum <= Board.FINISH_SQUARE_NUMBER; squareNum++) {
				Square square = Board.Squares[squareNum];
				SquareControl squareControl = new SquareControl(square, SpaceRaceGame.Players);
				AddControlToTableLayoutPanel(squareControl, squareNum);
			}//endfor

		}// end SetupGameBoard

		private void AddControlToTableLayoutPanel(Control control, int squareNum) {
			int screenRow = 0;
			int screenCol = 0;
			MapSquareNumToScreenRowAndColumn(squareNum, out screenRow, out screenCol);
			tableLayoutPanel.Controls.Add(control, screenCol, screenRow);
		}// end Add Control


		/// <summary>
		/// For a given square number, tells you the corresponding row and column number
		/// on the TableLayoutPanel.
		/// Pre:  none.
		/// Post: returns the row and column numbers, via "out" parameters.
		/// </summary>
		/// <param name="squareNumber">The input square number.</param>
		/// <param name="rowNumber">The output row number.</param>
		/// <param name="columnNumber">The output column number.</param>
		private static void MapSquareNumToScreenRowAndColumn(int squareNum, out int screenRow, out int screenCol) {
			// (squareNum / NUM_OF_COLUMNS) gives the row from top to bottom
			// subtracting this from (NUM_OF_ROWS-1) gives the row from bottom to top
			screenRow = (NUM_OF_ROWS - 1) - (squareNum / NUM_OF_COLUMNS);

			if (screenRow % 2 == 0) {
				// number the column left-right if row is even
				screenCol = squareNum % NUM_OF_COLUMNS;
			} else {
				// number the column right-left if row is odd 
				screenCol = (NUM_OF_COLUMNS - 1) - squareNum % NUM_OF_COLUMNS;
			}

		}//end MapSquareNumToScreenRowAndColumn


		private void SetupPlayersDataGridView() {
			// Stop the playersDataGridView from using all Player columns.
			dgvPlayers.AutoGenerateColumns = false;
			// Tell the playersDataGridView what its real source of data is.
			dgvPlayers.DataSource = SpaceRaceGame.Players;

		}// end SetUpPlayersDataGridView



		/// <summary>
		/// Obtains the current "selected item" from the ComboBox
		///  and
		///  sets the NumberOfPlayers in the SpaceRaceGame class.
		///  Pre: none
		///  Post: NumberOfPlayers in SpaceRaceGame class has been updated
		/// </summary>
		private void DetermineNumberOfPlayers() {
			// Store the SelectedItem property of the ComboBox in a string
			string choice = cmbNumPlayers.SelectedItem.ToString();

			// Parse string to a number
			int numPlayers = int.Parse(choice);

			// Set the NumberOfPlayers in the SpaceRaceGame class to that number
			SpaceRaceGame.NumberOfGUIPlayers = numPlayers;

		}//end DetermineNumberOfPlayers

		/// <summary>
		/// The players' tokens are placed on the Start square
		/// </summary>
		private void PrepareToPlay() {
			DetermineNumberOfPlayers();
			UpdatePlayersGuiLocations(TypeOfGuiUpdate.RemovePlayer);
			SpaceRaceGame.SetUp();
			InitGUIControls();
			UpdatePlayersGuiLocations(TypeOfGuiUpdate.AddPlayer);
		}//end PrepareToPlay()


		/// <summary>
		/// Tells you which SquareControl object is associated with a given square number.
		/// Pre:  a valid squareNumber is specified; and
		///       the tableLayoutPanel is properly constructed.
		/// Post: the SquareControl object associated with the square number is returned.
		/// </summary>
		/// <param name="squareNumber">The square number.</param>
		/// <returns>Returns the SquareControl object associated with the square number.</returns>
		private SquareControl SquareControlAt(int squareNum) {
			int screenRow;
			int screenCol;

			MapSquareNumToScreenRowAndColumn(squareNum, out screenRow, out screenCol);
			return (SquareControl)tableLayoutPanel.GetControlFromPosition(screenCol, screenRow);
		}


		/// <summary>
		/// Tells you the current square number of a given player.
		/// Pre:  a valid playerNumber is specified.
		/// Post: the square number of the player is returned.
		/// </summary>
		/// <param name="playerNumber">The player number.</param>
		/// <returns>Returns the square number of the player.</returns>
		private int GetSquareNumberOfPlayer(int playerNumber) {
			// Code needs to be added here.
			return SpaceRaceGame.Players[playerNumber].Position;
		}//end GetSquareNumberOfPlayer


		/// <summary>
		/// When the SquareControl objects are updated (when players move to a new square),
		/// the board's TableLayoutPanel is not updated immediately.  
		/// Each time that players move, this method must be called so that the board's TableLayoutPanel 
		/// is told to refresh what it is displaying.
		/// Pre:  none.
		/// Post: the board's TableLayoutPanel shows the latest information 
		///       from the collection of SquareControl objects in the TableLayoutPanel.
		/// </summary>
		private void RefreshBoardTablePanelLayout() {
			tableLayoutPanel.Invalidate(true);
		}

		/// <summary>
		/// When the Player objects are updated (location, etc),
		/// the players DataGridView is not updated immediately.  
		/// Each time that those player objects are updated, this method must be called 
		/// so that the players DataGridView is told to refresh what it is displaying.
		/// Pre:  none.
		/// Post: the players DataGridView shows the latest information 
		///       from the collection of Player objects in the SpaceRaceGame.
		/// </summary>
		private void UpdatesPlayersDataGridView() {
			SpaceRaceGame.Players.ResetBindings();
		}

		/// <summary>
		/// At several places in the program's code, it is necessary to update the GUI board,
		/// so that player's tokens are removed from their old squares
		/// or added to their new squares. E.g. at the end of a round of play or 
		/// when the Reset button has been clicked.
		/// 
		/// Moving all players from their old to their new squares requires this method to be called twice: 
		/// once with the parameter typeOfGuiUpdate set to RemovePlayer, and once with it set to AddPlayer.
		/// In between those two calls, the players locations must be changed. 
		/// Otherwise, you won't see any change on the screen.
		/// 
		/// Pre:  the Players objects in the SpaceRaceGame have each players' current locations
		/// Post: the GUI board is updated to match 
		/// </summary>
		private void UpdatePlayersGuiLocations(TypeOfGuiUpdate typeOfGuiUpdate) {
			// Remove all players
			if (typeOfGuiUpdate == TypeOfGuiUpdate.RemovePlayer) {
			for (int i = 0; i < SpaceRaceGame.NumberOfPlayers; i++) {
					int sqNum = GetSquareNumberOfPlayer(i);
					SquareControl sqControl = SquareControlAt(sqNum);
					sqControl.ContainsPlayers[i] = false;
				}
			}

			if (typeOfGuiUpdate == TypeOfGuiUpdate.AddPlayer) {
				for (int i = 0; i < SpaceRaceGame.NumberOfGUIPlayers; i++) {
					int sqNum = GetSquareNumberOfPlayer(i);
					SquareControl sqControl = SquareControlAt(sqNum);
					sqControl.ContainsPlayers[i] = true;
				}
			}

			RefreshBoardTablePanelLayout();//must be the last line in this method. Do not put inside above loop.
		} //end UpdatePlayersGuiLocations


		// Play one round if GameState is unfinished [OC]
		private void GUIPlayOneRound() {
			if (SpaceRaceGame.GameState == -1) {
				btnRoll.Enabled = false;
				UpdatePlayersGuiLocations(TypeOfGuiUpdate.RemovePlayer);
				SpaceRaceGame.PlayOneRound();
				UpdatePlayersGuiLocations(TypeOfGuiUpdate.AddPlayer);
				UpdatesPlayersDataGridView();
				btnRoll.Enabled = true;
			}
		}

		// Play one turn if GameState is unfinished and singled step is enabled [OC]
		private void GUIPlayOneTurn() {
			if (SpaceRaceGame.GameState == -1) {
				btnRoll.Enabled = false;
				UpdatePlayersGuiLocations(TypeOfGuiUpdate.RemovePlayer);
				SpaceRaceGame.PlayOneTurn();
				UpdatePlayersGuiLocations(TypeOfGuiUpdate.AddPlayer);
				UpdatesPlayersDataGridView();
				btnRoll.Enabled = true;
			}
		}

		// Shows the tie message [OC]
		private void ShowTie() {
			MessageBox.Show("All players out of fuel - it's a tie!");
		}

		// Shows the winners message [OC]
		private void ShowWinners() {
			string msg = "The following player(s) finished the game\n\n";
			for (int i = 0; i < SpaceRaceGame.Winners.Count; i++) {
				msg += "\t" + SpaceRaceGame.Winners[i].Name + "\n";
			}
			MessageBox.Show(msg);
		}

		// Handle game states [OC]
		private void HandleGameState() {
			if (SpaceRaceGame.GameState == 0) ShowTie();
			else if (SpaceRaceGame.GameState == 1) ShowWinners();
		}

		// Updates GUI controls on 'Roll Dice' click [OC]
		private void RollGUIUpdate() {
			dgvPlayers.Enabled = false;
			cmbNumPlayers.Enabled = false;
			btnReset.Enabled = true;
			if (SpaceRaceGame.GameState != -1) btnRoll.Enabled = false;
		}

		// Updates GUI on game start or new game [OC]
		private void InitGUIControls() {
			exitButton.Enabled = true;
			dgvPlayers.Enabled = true;
			cmbNumPlayers.Enabled = true;
			btnRoll.Enabled = false;
			btnReset.Enabled = false;
			grbSingleStep.Enabled = true;
			rbtnStepNo.Checked = false;
			rbtnStepYes.Checked = false;
		}

		// Handle 'Roll Dice' click [OC]
		private void btnRoll_Click(object sender, EventArgs e) {
			if (!SpaceRaceGame.SingleStep) {
				GUIPlayOneRound();
			} else {
				GUIPlayOneTurn();
			}
			// Disable exit button during a round 
			if (SpaceRaceGame.Turn != 0) exitButton.Enabled = false;
			// Enable exit button at the start of a round
			else exitButton.Enabled = true;

			HandleGameState();
			RollGUIUpdate();
		}

		// Handle 'Game Reset' click [OC]
		private void btnReset_Click(object sender, EventArgs e) {
			PrepareToPlay();
		}

		// Handle Combobox select change [OC]
		private void cmbNumPlayers_SelectedIndexChanged(object sender, EventArgs e) {
			PrepareToPlay();
			cmbNumPlayers.Enabled = false;
		}

		// Handle 'Yes' radio button click
		private void rbtnStepYes_Click(object sender, EventArgs e) {
			grbSingleStep.Enabled = false;
			SpaceRaceGame.SingleStep = true;
			btnRoll.Enabled = true;
		}

		// Handle 'No' radio button click
		private void rbtnSingleNo_CheckedChanged(object sender, EventArgs e) {
			grbSingleStep.Enabled = false;
			SpaceRaceGame.SingleStep = false;
			btnRoll.Enabled = true;
		}
	}// end class
}
