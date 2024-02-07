using System.Drawing;
using System.Reflection.Metadata.Ecma335;

class Square : Shape
{
    private int _side;
    public Square(string color, int side) : base(color)
    {
        _side = side;
    }
    public override double GetArea()
    {
        double area = _side*_side;
        return area;
    }
}