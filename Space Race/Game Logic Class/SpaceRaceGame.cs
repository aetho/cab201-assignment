using Object_Classes;
using System.ComponentModel;
using System.Drawing;


namespace Game_Logic_Class {
	public static class SpaceRaceGame {

		// Minimum and maximum number of players.
		public const int MIN_PLAYERS = 2;
		public const int MAX_PLAYERS = 6;

		private static int numberOfPlayers = 6;  // default value 
		public static int NumberOfPlayers {
			get {
				return numberOfPlayers;
			}
			set {
				numberOfPlayers = value;
			}
		}

		/// <summary>
		/// The number of players chosen through the GUI
		/// </summary>
		private static int numberOfGUIPlayers = 0;
		public static int NumberOfGUIPlayers {
			get {
				return numberOfGUIPlayers;
			}
			set {
				numberOfGUIPlayers = value;
			}
		}

		public static string[] names = { "One", "Two", "Three", "Four", "Five", "Six" };  // default values

		// Only used in Part B - GUI Implementation, the colours of each player's token
		private static Brush[] playerTokenColours = new Brush[MAX_PLAYERS] { Brushes.Yellow, Brushes.Red,
																	   Brushes.Orange, Brushes.White,
																	  Brushes.Green, Brushes.DarkViolet};
		/// <summary>
		/// A BindingList is like an array which grows as elements are added to it.
		/// </summary>
		private static BindingList<Player> players = new BindingList<Player>();
		public static BindingList<Player> Players {
			get {
				return players;
			}
		}

		/// <summary>
		/// The winner(s) of the current game [OC]
		/// </summary>
		private static BindingList<Player> winners = new BindingList<Player>();
		public static BindingList<Player> Winners {
			get {
				return winners;
			}
		}

		/// <summary>
		/// The loser(s) of the current game (players out of fuel) [OC]
		/// </summary>
		private static BindingList<Player> losers = new BindingList<Player>();
		public static BindingList<Player> Losers {
			get {
				return losers;
			}
		}

		/// <summary>
		/// The state of the game (playing/tie/finished) denoted by -1/0/1 [OC]
		/// </summary>
		private static int gameState = -1;
		public static int GameState {
			get {
				return gameState;
			}
		}

		/// <summary>
		/// A variable to keep track of single-stepping [OC]
		/// </summary>
		private static bool singleStep = false;
		public static bool SingleStep {
			get {
				return singleStep;
			}
			set {
				singleStep = value;
			}
		}

		/// <summary>
		/// A variable to keep track of which player's turn it is [OC]
		/// </summary>
		private static int turn = 0;
		public static int Turn {
			get {
				return turn % numberOfGUIPlayers;
			}
			set {
				turn = value;
			}
		}

		// The pair of die
		private static Die die1 = new Die(), die2 = new Die();

		/// <summary>
		/// Set up the conditions for this game as well as
		///   creating the required number of players, adding each player 
		///   to the Binding List and initialize the player's instance variables
		///   except for playerTokenColour and playerTokenImage in Console implementation.
		///   
		///     
		/// Pre:  none
		/// Post:  required number of players have been initialsed for start of a game.
		/// </summary>
		public static void SetUpPlayers() {
			players.Clear();
			for (int i = 0; i < numberOfPlayers; i++) {
				Player player = new Player(names[i]); // Create Player object and name it

				// Initialise player using properties
				player.Position = 0;
				player.Location = Board.Squares[0];
				player.RocketFuel = Player.INITIAL_FUEL_AMOUNT;
				player.HasPower = true;
				player.AtFinish = false;
				player.PlayerTokenColour = playerTokenColours[i];

				// Add player to binding list
				players.Add(player);
			}
		}
		/// <summary>
		/// Setup/Initialise the game [OC]
		/// </summary>
		public static void SetUp() {
			turn = 0;
			singleStep = false;
			// Change gameState
			gameState = -1;
			// Clear winners
			winners.Clear();
			// Clear losers
			losers.Clear();
			// Setup players
			SetUpPlayers();
		}

		/// <summary>
		/// Update winners BindingList with the winners if any exist. [OC]
		/// </summary>
		public static void UpdatePlayers() {
			// Clear winners and losers lists or else same players will
			// be added again during single-step mode
			winners.Clear();
			losers.Clear();

			for (int i = 0; i < numberOfPlayers; i++) {
				// Add to winner if player is at finish
				if (players[i].AtFinish) winners.Add(players[i]);
				// Add to loser if player has no fuel
				if (!players[i].HasPower) losers.Add(players[i]);
			}
		}

		/// <summary>
		///  Plays one round of a game
		/// </summary>
		public static void PlayOneRound() {
			// Play round if gameState is unfinished (-1)
			if (gameState == -1) {
				int numPlayers = (numberOfGUIPlayers == 0) ? numberOfPlayers : numberOfGUIPlayers;
				for (int i = 0; i < numPlayers; i++) {
					players[i].Play(die1, die2);
				}
				UpdatePlayers();
			}
			UpdateGameState();
		}

		/// <summary>
		/// Plays one turn
		/// </summary>
		public static void PlayOneTurn() {
			if (gameState == -1) {
				// If player does not have fuel play next the next turn
				if (!players[Turn].HasPower) {
					Turn++;
					PlayOneTurn();
				}
				// Else play the current turn
				else {
					players[Turn].Play(die1, die2);
					UpdatePlayers();
					UpdateGameState();
					Turn++;
				}
			}
		}

		/// <summary>
		/// Update game state [OC]
		/// </summary>
		public static void UpdateGameState() {
			if (winners.Count < 1) gameState = -1;
			if (winners.Count > 0) gameState = 1;
			if (losers.Count == numberOfGUIPlayers && losers.Count != 0) gameState = 0;
		}
	}//end SnakesAndLadders
}