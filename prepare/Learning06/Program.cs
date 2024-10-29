using System;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

class Program
{
    //public List<string> shapes = new List<string>();
    static void Main(string[] args)
    {

        Square square1 = new Square(5);
        square1.GetColor();
        square1.SetColor("blue");
        DisplayShapeArea(square1, "square");

        Rectangle rectangle1 = new Rectangle(10, 2);
        rectangle1.GetColor();
        rectangle1.SetColor("red");
        DisplayShapeArea(rectangle1, "rectangle");

        Circle Circle1 = new Circle(8);
        Circle1.GetColor();
        Circle1.SetColor("yellow");
        DisplayShapeArea(Circle1, "circle");
    }
    public static void DisplayShapeArea(Shape shape, string type)
    {
        Console.WriteLine($"The area of the {type} is {shape.GetArea():F2} and the color is {shape.GetColor()}. ");
        
    }
}