namespace CsharpAbstractDemo;

public class UnitRenderer: IRenderable
{
  protected Color _color = Color.Red;
  private static UnitRenderer _instance;

  private UnitRenderer() { }

  public static UnitRenderer Get()
  {
    if (_instance == null)
    {
      _instance = new();
    }
    return _instance;
  }

  public void Render(Rectangle rect)
  {
    Raylib.DrawRectangleRec(rect, _color);
  }
}