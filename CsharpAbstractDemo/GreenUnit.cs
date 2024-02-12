
namespace CsharpAbstractDemo;

public class GreenUnit : Unit, IClickable
{
  public GreenUnit(Vector2 startPosition, IRenderable renderer) : base(startPosition, renderer)
  {
    // _color = Color.Green;
    _speed = 60;
  }

  public void Click()
  {
    // _color = Color.Blue;
  }

  public bool IsHovering(Vector2 mousePos)
  {
    return Raylib.CheckCollisionPointRec(mousePos, _rect);
  }
}
