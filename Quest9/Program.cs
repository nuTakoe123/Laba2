public interface IShape { }

public class Circle : IShape
{
    public double Radius { get; set; }
    public Circle(double radius) => Radius = radius;
}

public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public Rectangle(double width, double height) => (Width, Height) = (width, height);
}

public class Triangle : IShape
{
    public double Base { get; set; }
    public double Height { get; set; }
    public Triangle(double @base, double height) => (Base, Height) = (@base, height);
}

// В методе Main:
class Program
{
    static void Main(string[] args)
    {
        IShape[] shapes = new IShape[]
        {
            new Circle(5),
            new Rectangle(4, 6),
            new Triangle(3, 8),
            null
        };

        foreach (var shape in shapes)
        {
            // TODO: Вычислите площадь каждой фигуры
            // Площадь круга: π * r²
            // Площадь прямоугольника: width * height
            // Площадь треугольника: 0.5 * base * height
    
            double area = shape switch
            {
                Circle c => Math.PI * c.Radius * c.Radius,
                Rectangle r => r.Width * r.Height,
                Triangle t => 0.5 * t.Base * t.Height,
                null => 0,
                _ => throw new ArgumentException("Неизвестный тип фигуры")
            };
    
            string shapeType = shape?.GetType().Name ?? "null";
            Console.WriteLine($"Фигура: {shapeType}, Площадь: {area:F2}");
        }
    }
}