namespace CsharpAbstractDemo;

public class Unit: GameObject
{
  protected Rectangle _rect;
  private Vector2 _velocity;
  protected float _speed = 30f;
  protected IRenderable _renderer;

  public Unit(Vector2 startPosition, IRenderable renderer)
  {
    _rect = new(startPosition.X, startPosition.Y, 64, 64);
    _velocity = Vector2.UnitX;
    _renderer = renderer;
  }

  public void Reverse()
  {
    _velocity = -_velocity;
  }

  public override void Update(float deltaTime)
  {
    _rect.X += _velocity.X * _speed * deltaTime;

    if (_rect.X + _rect.Width > Raylib.GetScreenWidth() || _rect.X < 0)
    {
      Reverse();
    }
  }

  public override void Draw()
  {
    _renderer.Render(_rect);
  }
}