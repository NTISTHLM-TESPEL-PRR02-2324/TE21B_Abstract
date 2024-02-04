global using Raylib_cs;
global using System.Numerics;
using CsharpAbstractDemo;

Raylib.InitWindow(800, 600, "StratGame");
Raylib.SetTargetFPS(60);

// Create units
GameObject unit = new Unit(Vector2.Zero);

// Create buttons
List<Button> buttons = new();
buttons.Add(new Button(new(10, 400, 140, 30), "KLIKME", () => Console.WriteLine("hey!")));
buttons.Add(new Button(new(160, 400, 140, 30), "KLIKME2", () => Console.WriteLine("whoa!")));



while (!Raylib.WindowShouldClose())
{
  // Get frame-wide variables
  float deltaTime = Raylib.GetFrameTime();
  Vector2 mousePosition = Raylib.GetMousePosition();

  // Update logic
  unit.Update(deltaTime);

  if (Raylib.IsMouseButtonPressed(0))
  {
    foreach (Button b in buttons)
    {
      if (b.PointIsInside(mousePosition))
      {
        b.Click();
      }
    }
  }

  // Draw
  Raylib.BeginDrawing();
  Raylib.ClearBackground(Color.White);

  unit.Draw();

  buttons.ForEach(b => b.Draw());

  Raylib.EndDrawing();
}