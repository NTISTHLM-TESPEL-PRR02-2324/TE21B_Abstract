global using Raylib_cs;
global using System.Numerics;
using CsharpAbstractDemo;

Raylib.InitWindow(800, 600, "StratGame");
Raylib.SetTargetFPS(60);

// Create units
List<Unit> units = new();
units.Add(new Unit(Vector2.Zero));
units.Add(new Unit(new Vector2(64, 128)));
GreenUnit green = new GreenUnit(new Vector2(0, 256));
units.Add(green);

// Create buttons
List<Button> buttons = new();
buttons.Add(new Button(new(10, 400, 140, 30), "KLIKME", () => Console.WriteLine("hey!")));
buttons.Add(new Button(new(160, 400, 140, 30), "KLIKME2", () => Console.WriteLine("whoa!")));

List<IClickable> clickables = new();
clickables.AddRange(buttons);
clickables.Add(green);


while (!Raylib.WindowShouldClose())
{
  // Get frame-wide variables
  float deltaTime = Raylib.GetFrameTime();
  Vector2 mousePosition = Raylib.GetMousePosition();

  // Update logic
  units.ForEach(u => u.Update(deltaTime));

  if (Raylib.IsMouseButtonPressed(0))
  {
    foreach (IClickable c in clickables)
    {
      if (c.IsHovering(mousePosition))
      {
        c.Click();
      }
    }
  }

  // Draw
  Raylib.BeginDrawing();
  Raylib.ClearBackground(Color.White);

  units.ForEach(u => u.Draw());

  buttons.ForEach(b => b.Draw());

  Raylib.EndDrawing();
}