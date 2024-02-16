namespace CsharpAbstractDemo;

public class PatrollingState : State
{
  public PatrollingState(Unit parent) : base(parent)
  {
    Unit p = (Unit)_parent;
    p.Velocity = Vector2.UnitX;
  }

  public override void Update()
  {
    Unit p = (Unit)_parent;
    if (p.Rect.X + p.Rect.Width > Raylib.GetScreenWidth() || p.Rect.X < 0)
    {
      p.Velocity = -p.Velocity;
    }
  }
}
