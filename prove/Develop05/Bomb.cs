using Raylib_cs;
public class Bomb : FallingObject
{

    public Bomb(int x, int y, int value, int speed) : base(x, y, value, speed)
    {

    }

    public override void Draw()
    {
        Raylib.DrawRectangle(_x, _y, 20, 20, Color.Red);
    }
}