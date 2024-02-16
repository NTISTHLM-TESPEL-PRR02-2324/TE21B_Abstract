
namespace CsharpAbstractDemo;

public class GreenUnitFactory : UnitFactory
{
  protected List<IClickable> _clickables;

  public GreenUnitFactory(IRenderable renderer, List<IClickable> clickables) : base(renderer)
  {
    _clickables = clickables;
  }

  public override Unit Make(Vector2 startPosition)
  {
    GreenUnit u = new GreenUnit(startPosition, _renderer);
    _clickables.Add(u);
    return u;
  }
}
