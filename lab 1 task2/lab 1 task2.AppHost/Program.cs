public class Rectangle
{
    private double sideA;
    private double sideB;  

    public Rectangle(double sA, double sB)
    {
        sideA = sA;
        sideB = sB;
    }
    private double CalculateArea()
    {
        return (sideA * sideB);
    }

    private double CalculatePerimeter()
    {
        return (sideA + sideB) * 2;
    }
    public double Get_Area
    {
        get { return CalculateArea(); }
    }

    public double Get_Perimeter
    {
        get { return CalculatePerimeter(); }
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите стороны прямоугольника");
        double sideA = Convert.ToDouble(Console.ReadLine());
        double sideB = Convert.ToDouble(Console.ReadLine());

        Rectangle r = new Rectangle(sideA, sideB);

        Console.WriteLine("Площадь {0}", r.Get_Area);
        Console.WriteLine("Периметр {0}", r.Get_Perimeter);
    }
}