using MathLibrary;
using Raylib_cs;

namespace Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathLibrary.Vector2 a = new MathLibrary.Vector2();
            MathLibrary.Vector2 b = new MathLibrary.Vector2();
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);

            Raylib.InitWindow(800, 480, "Hello World");

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(new Color(30, 125, 189, 255));

                Raylib.DrawCircle(150, 350, 100, Color.Gold);
                Raylib.DrawRectangle(0, 350, 800, 150, Color.Beige);
                Raylib.DrawCircle(700,130,50,new Color(255, 226, 198, 255));
                Raylib.DrawRectangle(675,180,50,100,Color.White);
                Raylib.DrawRectangle(675, 280, 20, 100, Color.Black);
                Raylib.DrawRectangle(705, 280, 20, 100, Color.Black);
                Raylib.DrawRectangle(655,180,20,100,new Color(255,226,198,255));
                Raylib.DrawRectangle(725,180,20,100,new Color(255,226,198,255));
                Raylib.DrawText("Man", 290, 380, 110, Color.Black);
                Raylib.DrawText("Man", 300, 390, 100, Color.White);

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}
