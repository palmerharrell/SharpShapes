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
      int shapeChoice;
      double dimension;
      string[] dimensions;
      bool shapeSelected = false;

      // Display menu in console
      Console.WriteLine("");
      Console.WriteLine("Select a shape:");
      Console.WriteLine("1. Circle");
      Console.WriteLine("2. Square");
      Console.WriteLine("3. Cylinder");
      Console.WriteLine("4. Pyramid");
      Console.Write("> ");

      // Get shape choice
      Int32.TryParse(Console.ReadLine(), out shapeChoice);
      
      while(shapeSelected == false)
      {
        switch (shapeChoice)
        {
          case 1:
            Console.WriteLine("");
            Console.WriteLine("Enter the radius of the circle:");
            Console.Write("> ");
            dimension = Convert.ToDouble(Console.ReadLine());
            Circle circle = new Circle();
            circle.radius = dimension;
            Console.WriteLine("");
            Console.WriteLine("Circle of Radius {0}", circle.radius);
            Console.WriteLine("--------------------");
            Console.WriteLine("A circle has {0} side.", circle.sides);
            Console.WriteLine("The area of this circle is {0}.", circle.calculateArea());
            shapeSelected = true;
            break;
          case 2:
            Console.WriteLine("");
            Console.WriteLine("Square selected");
            shapeSelected = true;
            break;
          case 3:
            Console.WriteLine("");
            Console.WriteLine("Cylinder selected");
            shapeSelected = true;
            break;
          case 4:
            Console.WriteLine("");
            Console.WriteLine("Pyramid selected");
            shapeSelected = true;
            break;
          default:
            Console.WriteLine("Invalid choice. Please type a number from the list.");
            Console.Write("> ");
            Int32.TryParse(Console.ReadLine(), out shapeChoice);
            break;
        }
      }

      //if (inputTest == "2")
      //{
      //  Square square = new Square();
      //  Console.Write("Enter Width of square: ");
      //  double width = Convert.ToDouble(Console.ReadLine());
      //  square.width = width;
      //  double squareArea = square.calculateArea();
      //  Console.WriteLine("The area of the square is {0}", squareArea);
      //}
      //else if(inputTest == "1")
      //{
      //  Circle circle = new Circle();
      //  Console.Write("Enter Radius of circle: ");
      //  double radius = Convert.ToDouble(Console.ReadLine());
      //  circle.radius = radius;
      //  Console.WriteLine("circle.radius: {0}", circle.radius);
      //  // Area method not written yet
      //}
      //else if (inputTest == "5")
      //{
      //  Cylinder cylinder = new Cylinder();
      //  Console.Write("Enter Height and radius of cylinder, seperated by a comma: ");
      //  string input = Console.ReadLine();
      //  string[] dimensions = input.Split(',');
      //  cylinder.height = Convert.ToDouble(dimensions[0]);
      //  cylinder.radius = Convert.ToDouble(dimensions[1]);
      //  double cylinderVolume = cylinder.calculateVolume();
      //  Console.WriteLine("The volume of the cylinder is {0}", cylinderVolume);

      //}
    }
  }
}
