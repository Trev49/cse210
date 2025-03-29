using Raylib_cs;
public class FallingObject : GameObject
{
    private int _value;
    private int _speed;

    public FallingObject(int x, int y, int value, int speed) : base(x, y)
    {
        _value = value;
        _speed = speed;
    }

    public void Fall()
    {
        _y += _speed;
        if (_y > GameManager.SCREEN_HEIGHT)
        {
            _y = 0;
            _x = Raylib.GetRandomValue(0, GameManager.SCREEN_WIDTH - 20);
        }


        if (_y > GameManager.SCREEN_HEIGHT)
        {
            _y = Raylib.GetRandomValue(-50, -20);
            _x = Raylib.GetRandomValue(0, GameManager.SCREEN_WIDTH - 20);
        }
    }


    public override void Draw()
    {
        Raylib.DrawRectangle(_x, _y, 20, 20, Color.Red);
    }

    public int GetValue() => _value;

    public Rectangle GetBounds()
    {
        return new Rectangle(_x, _y, 20, 20);
    }
}
