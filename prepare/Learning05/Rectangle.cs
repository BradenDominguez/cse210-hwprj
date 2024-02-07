class Rectangle : Shape
{
    private int _width;
    private int _height;
    public Rectangle(string color, int width, int height) : base(color)
    {
        _width = width;
        _height = height;
    }
    public override double GetArea()
    {
        double area = _width * _height;
        return area;
    }
}