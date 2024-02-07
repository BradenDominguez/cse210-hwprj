class Circle : Shape
{
    private int _circumference;
    public Circle(string color, int circumference) : base(color)
    {
        _circumference = circumference;
    }
    public override double GetArea()
    {
         
        double radius = (_circumference / (2 * Math.PI));
        double area = ((radius*radius) * Math.PI);
        return area;
    }
}