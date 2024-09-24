using System.Drawing;

namespace Lab1_ConsoleApp.Tests;

public class UnitTest1
{
    [Fact]

    public void TestPerimeterCalculator_Triangle()
    {
        // Arrange
        Point p1 = new Point(0, 0);
        Point p2 = new Point(4, 0);
        Point p3 = new Point(4, 3);
        Figure triangle = new Figure("Треугольник", p1, p2, p3);

        double perimeter = triangle.PerimeterCalculator();

        Assert.Equal(13, perimeter);
        Console.WriteLine("test 1");
    }
}