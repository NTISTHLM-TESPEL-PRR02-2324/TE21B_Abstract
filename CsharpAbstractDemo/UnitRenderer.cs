namespace CsharpAbstractDemo;

public class UnitRenderer: IRenderable
{
  protected Color _color;

  public UnitRenderer(Color color)
  {
    _color = color;
  }

  public void Render(Rectangle rect)
  {
    Raylib.DrawRectangleRec(rect, _color);
  }
}