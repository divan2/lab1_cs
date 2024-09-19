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
        Figure triangle = new Figure("�����������", p1, p2, p3);

        // Act
        double perimeter = triangle.PerimeterCalculator();

        // Assert
        Assert.Equal(12, perimeter);
    }
}