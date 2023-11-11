// See https://aka.ms/new-console-template for more information
using AreaLib.Figures;
public class Program
{
    public static void Main()
    {
        var c = new Circle(4);
        var t = new Triangle(3, 5, 7);
        Console.WriteLine(new Program().CalculateFigureArea(c));
        Console.WriteLine(new Program().CalculateFigureArea(t));
    }
    public double CalculateFigureArea(IFigure figure)
    {
        return figure.Area();
    }
}