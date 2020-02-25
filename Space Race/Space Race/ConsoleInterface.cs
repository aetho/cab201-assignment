//DO NOT DELETE the two following using statements *********************************
using Game_Logic_Class;
using Object_Classes;
using System;


namespace Space_Race {
	class Console_Class {
		/// <summary>
		/// Space Race Game
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args) {
			bool replay;
			DisplayIntroductionMessage();
			do {
				// Initialise
				Board.SetUpBoard();
				SpaceRaceGame.NumberOfPlayers = GetNumPlayers();
				SpaceRaceGame.SetUp();
				// Place race
				Race();
				// Prompt replay
				GetReplay(out replay);
			} while (replay);
			PressEnter();
		}//end Main

		/// <summary>
		/// Display a welcome message to the console
		/// Pre:    none.
		/// Post:   A welcome message is displayed to the console.
		/// </summary>
		static void DisplayIntroductionMessage() {
			Console.WriteLine("\tWelcome to Space Race.\n");
		} //end DisplayIntroductionMessage

		/// <summary>
		/// Displays a prompt and waits for a keypress.
		/// Pre:  none
		/// Post: a key has been pressed.
		/// </summary>
		static void PressEnter() {
			Console.WriteLine("\n\n\n\n\tThanks for playing Space Race.\n");
			Console.Write("\n\tPress Enter to terminate program ...");
			Console.ReadLine();
		} // end PressAny

		/// <summary>
		/// Asks user for number of players
		/// </summary>
		/// <returns>The number of players the user has input</returns>
		static int GetNumPlayers() {
			int numPlayers = -1;
			bool init = true; // Flag to keep track of first prompt
			do {
				// if not initial then show error (error must have occurred if we're asking for the input again). 
				if (!init) Console.WriteLine("Error: invalid number of players entered.\n");
				Console.WriteLine("\tThis game is for 2 to 6 players.");
				Console.Write("\tHow many players (2-6): ");
				int.TryParse(Console.ReadLine(), out numPlayers);
				Console.WriteLine(); // Whitespace
				init = false;
			} while (numPlayers < 2 || numPlayers > 6);
			Console.WriteLine(); // Whitespace
			return numPlayers;
		}

		/// <summary>
		///  Plays 1 race
		/// </summary>
		static void Race() {
			bool init = true; // Flag to keep track of first round
			bool tie = false; // Flag to keep track of tie
			Player player; // A variable used to access properties easily

			// Play rounds until number of winners >= 1
			while (SpaceRaceGame.Winners.Count < 1) {
				tie = SpaceRaceGame.Losers.Count == SpaceRaceGame.Players.Count;
				// Break the loop and display tie
				if (tie) {
					Console.WriteLine("\tAll players out of fuel. It's a tie!\n");
					break;
				}

				Console.WriteLine("Press Enter to play a round ...");
				Console.ReadLine();
				SpaceRaceGame.PlayOneRound();


				if (init) {
					Console.WriteLine("\tFirst Round\n");
					init = false;
				} else {
					Console.WriteLine("\tNext Round\n");
				}

				// Show locations after round
				for (int i = 0; i < SpaceRaceGame.Players.Count; i++) {
					player = SpaceRaceGame.Players[i];
					Console.WriteLine("\t{0} on square {1} with {2} yottawatt of power remaining", player.Name, player.Position, player.RocketFuel);
				}
				Console.WriteLine(); // Whitespace
			}

			// Show winner(s)
			if (!tie) {
				Console.WriteLine("\tThe following player(s) finished the game\n");
				for (int i = 0; i < SpaceRaceGame.Winners.Count; i++) {
					player = SpaceRaceGame.Winners[i];
					Console.WriteLine("\t\t{0}\n", player.Name);
				}
			}

			// Show final locations
			Console.WriteLine("\n\tIndividual players finished with the at the locations specified.\n");
			for (int i = 0; i < SpaceRaceGame.Players.Count; i++) {
				player = SpaceRaceGame.Players[i];
				Console.WriteLine("\t\t{0} with {1} yattowatt of power at square {2}\n", player.Name, player.RocketFuel, player.Position);
			}
			Console.WriteLine("\n\tPress Enter key to continue ...");
		}

		/// <summary>
		/// Asks user if they want to replay
		/// Pre: None
		/// Post: The user's choise is assigned to replay
		/// </summary>
		/// <param name="replay">The user's choice</param>
		static void GetReplay(out bool replay) {
			Console.Write("\n\n\n\n\n\n\tPlay Again? (Y or N): ");
			string choice = Console.ReadLine().ToLower();
			if (choice != "y") replay = false;
			else replay = true;
		}
	}//end Console class
}
