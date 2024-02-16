namespace CsharpAbstractDemo;

public class Button : IClickable, IDrawable
{
  private Rectangle _rect;
  private string _label;
  private Action _action;

  public Action OnClick;

  public Button(Rectangle rectangle, string label, Action action)
  {
    _rect = rectangle;
    _label = label;
    _action = action;
  }

  public bool IsHovering(Vector2 point)
  {
    return Raylib.CheckCollisionPointRec(point, _rect);
  }

  public void Click()
  {
    _action();
    
    if (OnClick != null)
    {
      OnClick.Invoke();
    }
  }

  public void Draw()
  {
    Raylib.DrawRectangleRec(_rect, Color.Green);
    Raylib.DrawText(_label, (int)_rect.X + 5, (int)_rect.Y + 5, 20, Color.Black);
  }
}
