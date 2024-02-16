namespace CsharpAbstractDemo;

public class UnitFactory
{
  protected IRenderable _renderer;
  protected Button _reverseButton;
  private IRenderable renderer;

  public UnitFactory(IRenderable renderer, Button reverseButton)
  {
    _renderer = renderer;
    _reverseButton = reverseButton;
  }

  public virtual Unit Make(Vector2 startPosition)
  {
    Unit unit = new(startPosition, _renderer);
    _reverseButton.OnClick += unit.Reverse;

    return unit;
  }
}
