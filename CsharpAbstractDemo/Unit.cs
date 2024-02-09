namespace CsharpAbstractDemo;

public class Unit: GameObject
{
  protected Rectangle _rect;
  private Vector2 _velocity;
  protected float _speed = 30f;
  protected Color _color;

  public Unit(Vector2 startPosition)
  {
    _rect = new(startPosition.X, startPosition.Y, 64, 64);
    _velocity = Vector2.UnitX;
    _color = Color.Red;
  }

  public override void Update(float deltaTime)
  {
    _rect.X += _velocity.X * _speed * deltaTime;

    if (_rect.X + _rect.Width > Raylib.GetScreenWidth() || _rect.X < 0)
    {
      _velocity = -_velocity;
    }
  }

  public override void Draw()
  {
    Raylib.DrawRectangleRec(_rect, _color);
  }
}
