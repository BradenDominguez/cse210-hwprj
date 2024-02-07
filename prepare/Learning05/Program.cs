class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square square = new Square("Red", 11);
        shapes.Add(square);
        Circle circle = new Circle("Blue", 11);
        shapes.Add(circle);
        Rectangle rectangle = new Rectangle("Green", 11, 12);
        shapes.Add(rectangle);
        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"Shape is {color} and {area}.");
        }
    }
}