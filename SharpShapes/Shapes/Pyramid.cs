using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes.Shapes
{
  public class Pyramid : Shape
  {
    //public double length;
    //public double width;
    //public double height;
    public override double calculateVolume()
    {
      return (length * width * height) / 3;
    }
  }
}
