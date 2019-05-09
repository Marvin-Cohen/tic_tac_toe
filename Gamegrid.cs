using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe
{
    static class Gamegrid
    {
        const int GRID_SIDE_LENGTH = 3;
        private static string[,] grid = new string[GRID_SIDE_LENGTH, GRID_SIDE_LENGTH]; // This grid will only ever contain one of the three : "", "x", "o". 
        private static string teamTurn = "x";

        public static string ValueAt(int x,int y)
        {
            // If x and y are outside of the grid then "return ;"
            if (x >= GRID_SIDE_LENGTH || y >= GRID_SIDE_LENGTH || x < 0 || y < 0)
            {
                System.Windows.MessageBox.Show("Invalid coordinates passed to ValueAt");
                return "!";
            }

            return grid[x, y];
        }
        public static string WhoseTurn()
        {
            return teamTurn;
        }

        // Set up empty grid
        public static void InitializeGrid()
        {
            for (int i = 0; i < GRID_SIDE_LENGTH; i++)
            {
                for (int j = 0; j < GRID_SIDE_LENGTH; j++)
                {
                    grid[i,j] = "";
                }
            }
        }

        public static void ChangeTurn()
        {
            if (teamTurn == "x")
            {
                teamTurn = "o";
            }
            else if (teamTurn == "X")
            {
                teamTurn = "o";
            }
            else if (teamTurn == "O")
            {
                teamTurn = "x";
            }
            else if (teamTurn == "o")
            {
                teamTurn = "x";
            }
            else
            {
                System.Windows.MessageBox.Show("Invalid character in teamTurn");
            }
        }
        // Places an "x" or "o" in the grid at grid[x,y]. Whether it is an "x" or "o" is determined by the value of teamMarker. 
        public static void PlaceMarker(int x, int y, string teamMarker)
        {
            // If x and y are outside of the grid then "return ;"
            if (x >= GRID_SIDE_LENGTH || y >= GRID_SIDE_LENGTH || x < 0 || y < 0)
            {
                System.Windows.MessageBox.Show("Invalid coordinates passed to PlaceMarker");
                return;
            }

            // Check if teamMarker is a valid input. 
            teamMarker = SanitizeTeamMarker(teamMarker);
            if( teamMarker == "bad marker")
            {
                return;
            }

            if (teamMarker == teamTurn)
            {
                // If the x,y cell in the grid empty then place the marker on the grid 
                if (grid[x, y] == "")
                {
                    grid[x, y] = teamMarker;
                }
            }
            else
            {
                System.Windows.MessageBox.Show("Turn violation passed to PlaceMarker");
            }

        }
        // Returns true if the team that plays with the symbol "teamMarker" has won the game or not by checking the grid. teamMarker is only allowed to have values "o","O","x", or "X". 
        public static bool HasTeamWon( string teamMarker )
        {
            // Check if teamMarker is a valid input. 
            teamMarker = SanitizeTeamMarker(teamMarker);

            if (teamMarker == "bad marker")
            {
                System.Windows.MessageBox.Show("Bad marker passed to HasTeamWon");
                return false;
            }

            // horizontal
            if (grid[0, 0] == grid[1, 0] && grid[1, 0] == grid[2, 0] && grid[0, 0] == teamMarker)
            {
                return true;
            }
            // horizontal
            if (grid[0, 1] == grid[1, 1] && grid[1, 1] == grid[2, 1] && grid[0, 1] == teamMarker)
            {
                return true;
            }
            // horizontal
            if (grid[0, 2] == grid[1, 2] && grid[1, 2] == grid[2, 2] && grid[0, 2] == teamMarker)
            {
                return true;
            }
            // vertical
            if (grid[0, 0] == grid[0, 1] && grid[0, 1] == grid[0, 2] && grid[0, 0] == teamMarker)
            {
                return true;
            }
            // vertical
            if (grid[1, 0] == grid[1, 1] && grid[1, 1] == grid[1, 2] && grid[1, 0] == teamMarker)
            {
                return true;
            }
            // vertical
            if (grid[2, 0] == grid[2, 1] && grid[2, 1] == grid[2, 2] && grid[2, 0] == teamMarker)
            {
                return true;
            }
            // diagonal
            if (grid[0, 0] == grid[1, 1] && grid[1, 1] == grid[2, 2] && grid[0, 0] == teamMarker)
            {
                return true;
            }
            // diagonal
            if (grid[0, 2] == grid[1, 1] && grid[1, 1] == grid[2, 0] && grid[0, 2] == teamMarker)
            {
                return true;
            }

            return false;
        }

        private static string SanitizeTeamMarker(string teamMarker)
        {
            // If team marker isn't an "X", "x", "o", "O" then "return ;"
            if (teamMarker != "X" || teamMarker != "x" || teamMarker != "O" || teamMarker != "o")
            {
                System.Windows.MessageBox.Show("Incorrect marker passed to PlaceMarker");
                return "bad marker";
            }

            // If teamMarker is capitalized then make it lower case. 
            if (teamMarker == "X")
            {
                teamMarker = "x";
            }
            if (teamMarker == "O")
            {
                teamMarker = "o";
            }
            return teamMarker;
        }
    }
}
