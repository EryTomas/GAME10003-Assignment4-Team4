using Raylib_cs;
namespace ConsoleApp1
{
    internal class Program
    {
        static bool startgame = false;
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
     }
}
