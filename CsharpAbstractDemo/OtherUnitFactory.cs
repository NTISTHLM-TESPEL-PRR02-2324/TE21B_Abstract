
namespace CsharpAbstractDemo;

public class OtherUnitFactory : UnitFactory
{
  protected List<IClickable> _clickables;

  public OtherUnitFactory(IRenderable renderer, List<IClickable> clickables, Button reverseButton) : base(renderer, reverseButton)
  {
    _clickables = clickables;
  }

  public override Unit Make(Vector2 startPosition)
  {
    GreenUnit unit = new(startPosition, _renderer);
    _clickables.Add(unit);
    return unit;
  }

}
