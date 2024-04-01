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
            
            while (startgame==false)
            {
                Updatetitlescreen();
                Raylib.BeginDrawing();
                Drawtitlescreen();
                Raylib.EndDrawing();
            }

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
            if (Raylib.IsKeyDown(KeyboardKey.Space))
            {
                startgame = true;
            }
        }

        static void Titlescreen()
        {

        }
    }
}
