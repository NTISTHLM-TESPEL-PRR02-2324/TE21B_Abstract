﻿global using Raylib_cs;
global using System.Numerics;
using CsharpAbstractDemo;

Raylib.InitWindow(800, 600, "StratGame");
Raylib.SetTargetFPS(60);

// Lists
List<Unit> units = new();
List<Button> buttons = new();
List<IClickable> clickables = new();
List<IDrawable> drawables = new();

// Create buttons
buttons.Add(new Button(new(10, 400, 140, 30), "KLIKME", () => Console.WriteLine("hey!")));
buttons.Add(new Button(new(160, 400, 140, 30), "KLIKME2", () => Console.WriteLine("whoa!")));

// Factories
UnitFactory unitFactory = new(UnitRenderer.Get(), buttons[1]);
OtherUnitFactory otherUnitFactory = new(UnitRenderer.Get(), clickables, buttons[1]);

// Create units
units.Add(unitFactory.Make(Vector2.Zero));
units.Add(unitFactory.Make(new Vector2(64, 128)));
units.Add(otherUnitFactory.Make(new Vector2(0, 256)));


clickables.AddRange(buttons);

drawables.AddRange(units);
drawables.AddRange(buttons);

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

  drawables.ForEach(d => d.Draw());

  Raylib.EndDrawing();
}