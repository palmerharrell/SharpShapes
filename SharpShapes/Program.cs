using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpShapes.Shapes;

namespace SharpShapes
{
  class Program
  {
    static void Main(string[] args)
    {
      // Display Menu in console
      //Console.Clear(); // Doesn't work in git bash
      Console.WriteLine("");
      Console.WriteLine("Select a shape:");
      Console.WriteLine("1. Circle");
      Console.WriteLine("2. Square");
      Console.WriteLine("3. Rhombus");
      Console.WriteLine("4. Cube");
      Console.WriteLine("5. Cylinder");
      Console.Write("> ");
      string inputTest = Console.ReadLine();
      //Console.WriteLine("User input: {0}", inputTest);

      if(inputTest == "2")
      {
        Square square = new Square();
        Console.Write("Enter Width of square: ");
        double width = Convert.ToDouble(Console.ReadLine());
        square.width = width;
        double squareArea = square.calculateArea();
        Console.WriteLine("The area of the square is {0}", squareArea);
      }
      else if(inputTest == "1")
      {
        Circle circle = new Circle();
        Console.Write("Enter Radius of circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        circle.radius = radius;
        Console.WriteLine("circle.radius: {0}", circle.radius);
        // Area method not written yet
      }
      else if (inputTest == "5")
      {
        Cylinder cylinder = new Cylinder();
        Console.Write("Enter Height and radius of cylinder, seperated by a comma: ");
        string input = Console.ReadLine();
        string[] dimensions = input.Split(',');
        cylinder.height = Convert.ToDouble(dimensions[0]);
        cylinder.radius = Convert.ToDouble(dimensions[1]);
        double cylinderVolume = cylinder.calculateVolume();
        Console.WriteLine("The volume of the cylinder is {0}", cylinderVolume);

      }
    }
  }
}
