namespace CsharpAbstractDemo;

public class Unit: GameObject, IStateful
{
  private Rectangle _rect;
  public Rectangle Rect { 
    get => _rect; 
    set => _rect = value; 
  }
  public Vector2 Velocity { get; set; }
  protected float _speed = 30f;
  protected IRenderable _renderer;

  protected State _state;

  public Unit(Vector2 startPosition, IRenderable renderer)
  {
    Rect = new(startPosition.X, startPosition.Y, 64, 64);
    Velocity = Vector2.UnitX;
    _renderer = renderer;
    _state = new PatrollingState(this);
  }

  public override void Update(float deltaTime)
  {
    _state.Update();
    _rect.X += Velocity.X * _speed * deltaTime;
    _rect.Y += Velocity.Y * _speed * deltaTime;
  }

  public override void Draw()
  {
    _renderer.Render(Rect);
  }

  public State GetState()
  {
    return _state;
  }

  public void SetState(State newState)
  {
    _state = newState;
  }
}