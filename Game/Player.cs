
using Raylib_cs;
public class Player : GameObject
{
    private int _speed = 5;
    public Player(int x, int y) : base(x, y)
    {

    }

    public void Move()
    {
        if (Raylib.IsKeyDown(KeyboardKey.Left) && _x > 0)
        {
            _x -= _speed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.Right) && _x < GameManager.SCREEN_WIDTH - 50)
        {
            _x += _speed;
        }
    }
    public override void Draw()
    {
        Raylib.DrawRectangle(_x, _y, 50, 10, Color.Blue);
    }
    public Rectangle GetBounds()
    {
        return new Rectangle(_x, _y, 50, 10);
    }
}
