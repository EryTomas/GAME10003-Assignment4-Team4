using Raylib_cs;
using System.Numerics;
namespace ConsoleApp1
{
    internal class Program
    {
        static bool startgame = false;
        static int[,] board = new int[3, 3]; // 0 = empty, 1 = player 1 (X), 2 = player 2 (O)
        static int currentPlayer = 1; // Start with player 1
        static bool gameActive = true;

        const int screenWidth = 600;
        const int screenHeight = 600;
        const int cellSize = 200;

        static void Main(string[] args)
        {
            Console.WriteLine("Testing branch commits/pulls");
            Loadwindow();
            Titlescreen();
            // Wait for any of key press to start the game
            while (!Raylib.WindowShouldClose() && !startgame)
            {
                Updatetitlescreen();
                Raylib.BeginDrawing();
                Drawtitlescreen();
                Raylib.EndDrawing();
            }

            Raylib.CloseWindow(); // Make sure window is closed

            Raylib.InitWindow(screenWidth, screenHeight, "3x3 Chessboard");
            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose() && gameActive)
            {
                DrawBoard();
                HandleInput();
                CheckWinCondition();
            }
            Raylib.CloseWindow();
        }

        static void Loadwindow()
        {

            Raylib.SetTargetFPS(60);
            Raylib.InitWindow(900, 600, "Tic Tac Toe");
        }
        static void Drawtitlescreen()
        {
            Raylib.ClearBackground(Color.Gold);
            Raylib.DrawText("Tic Tac Toe", 205, 220, 74, Color.Black);
            Raylib.DrawText("Press any key to start", 140, 330, 54, Color.Black);

        }
        static void Updatetitlescreen()
        {
            if (Raylib.GetKeyPressed() != 0)  //check any key has been pressed
            {
                startgame = true;
            }
        }

        static void Titlescreen()
        {

        }
        static void DrawBoard()
        {

            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.White);

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {

                    int posX = col * cellSize;
                    int posY = row * cellSize;

                    // Draw the cell based on the board state
                    if (board[row, col] == 1)
                    {
                        Raylib.DrawText("X", posX + (cellSize / 2) - 20, posY + 20, 100, Color.Red);
                    }
                    else if (board[row, col] == 2)
                    {
                        Raylib.DrawText("O", posX + (cellSize / 2) - 20, posY + 20, 100, Color.Blue);
                    }

                    // Draw the grid lines
                    Raylib.DrawLine(posX, posY, posX, posY + cellSize, Color.White);
                    Raylib.DrawLine(posX, posY, posX + cellSize, posY, Color.White);
                }
            }

            Raylib.DrawLine(screenWidth, 0, screenWidth, screenHeight, Color.White); // Right border
            Raylib.DrawLine(0, screenHeight, screenWidth, screenHeight, Color.White); // Bottom border

            Raylib.EndDrawing();
        }
        static void HandleInput()
        {
            if (Raylib.IsMouseButtonPressed(MouseButton.Left))
            {
                Vector2 mousePosition = Raylib.GetMousePosition();
                int row = (int)mousePosition.Y / cellSize;
                int col = (int)mousePosition.X / cellSize;

                if (board[row, col] == 0)
                {
                    board[row, col] = currentPlayer;
                    currentPlayer = currentPlayer == 1 ? 2 : 1; // Switch players
                }
            }
        }

        //ERYKA
        static void CheckWinCondition()
        {
            //Checking ROWS (horizontal)
            for (int row = 0; row < 3; row++)
            {
                if (board[row, 0] != 0 && board[row, 0] == board[row, 1] && board[row, 0] == board[row, 2])
                {
                    gameActive = false;
                    Console.WriteLine("Player " + board[row, 0] + " wins!");
                    return;
                }
            }

            //Checking COLUMNS (vertical)
            for (int col = 0; col < 3; col++)
            {
                if (board[0, col] != 0 && board[0, col] == board[1, col] && board[0, col] == board[2, col])
                {
                    gameActive = false;
                    Console.WriteLine("Player " + board[0, col] + " wins!");
                    return;
                }
            }


            //Checking DIAGONALS
            if (board[0, 0] != 0 && board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2])
            {
                gameActive = false;
                Console.WriteLine("Player " + board[0, 0] + " wins!");
                return;
            }

            if (board[0, 2] != 0 && board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0])
            {
                gameActive = false;
                Console.WriteLine("Player " + board[0, 2] + " wins!");
                return;
            }

            //Check for a DRAW
            bool draw = true;
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (board[row, col] == 0)
                    {
                        draw = false;
                        break;
                    }
                }
                if (!draw)
                    break;
            }



        }
    }
}
