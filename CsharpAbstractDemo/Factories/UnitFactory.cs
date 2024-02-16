namespace CsharpAbstractDemo;

public class UnitFactory
{
  protected IRenderable _renderer;

  public UnitFactory(IRenderable renderer)
  {
    _renderer = renderer;
  }

  public virtual Unit Make(Vector2 startPosition)
  {
    Unit u = new Unit(startPosition, _renderer);

    return u;
  }
}
