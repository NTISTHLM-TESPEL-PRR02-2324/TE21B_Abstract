namespace CsharpAbstractDemo;

public interface IStateful
{
  public State GetState();
  public void SetState(State newState);
}
