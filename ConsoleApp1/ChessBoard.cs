using Raylib_cs;
using System;

namespace ChessboardExample
{
    class Program
    {
        static void Main(string[] args)
        {
            const int screenWidth = 600;
            const int screenHeight = 600;
            const int cellSize = 200; 

            Raylib.InitWindow(screenWidth, screenHeight, "3x3 Chessboard");
            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose()) 
            {
                Raylib.BeginDrawing();

                Raylib.ClearBackground(Color.White);

                for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        
                        Color color = (row + col) % 2 == 0 ? Color.Yellow : Color.White;
                        Raylib.DrawRectangle(col * cellSize, row * cellSize, cellSize, cellSize, color);
                    }
                }

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}
