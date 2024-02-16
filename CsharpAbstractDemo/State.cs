namespace CsharpAbstractDemo;

public abstract class State
{
  protected IStateful _parent;

  public State(IStateful parent)
  {
    _parent = parent;
  }

  public abstract void Update();
}
