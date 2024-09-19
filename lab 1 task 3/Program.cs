public class Point
{
    public int x { get; }
    public int y { get; }  

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

public class Figure
{
    private Point[] points;

    public string type { get; }

    public Figure(string type, params Point[] points) { 

        if (points.Length< 3 || points.Length> 5)
        {
            throw new ArgumentException("в фигуре должно быть от 3 до 5 точек");
        }
        this.points = points;
        this.type = type;
    }

    public double LenghtSide(Point p1, Point p2)
    {
        return Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2));
    }

    public double PerimeterCalculator() 
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length; i++)
        {
            perimeter += LenghtSide(points[i], points[(i + 1) % points.Length]);
        }
        return perimeter;
    }

}


class Program
{
    static void Main()
    {
        Point p1 = new Point(0, 0);
        Point p2 = new Point(0, 5);
        Point p3 = new Point(5, 5);;
        Figure triangle = new Figure("Triangle", p1, p2, p3);
        Console.WriteLine($"Название фигуры: {triangle.type}");
        Console.WriteLine($"Периметр фигуры: {triangle.PerimeterCalculator()}");
    }
}