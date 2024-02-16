namespace CsharpAbstractDemo;

public class ButtonFactory
{
  protected List<IClickable> _clickables;

  public ButtonFactory(List<IClickable> clickables)
  {
    _clickables = clickables;
  }

  public virtual Button Make(Rectangle rect, string label, Action action)
  {
    Button b = new(rect, label, action);
    _clickables.Add(b);

    return b;
  }
}
