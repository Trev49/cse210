using Raylib_cs;
public class Treasure : FallingObject
{
    private Color _color;
    public Treasure(int x, int y, int value, int speed, Color color) : base(x, y, value, speed)
    {
        _color = color;
    }
    public override void Draw()
    {
        Raylib.DrawRectangle(_x, _y, 20, 20, _color);
    }
}