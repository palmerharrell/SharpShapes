using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes.Shapes
{
  public class Square : Shape
  {
    public override double calculateArea()
    {
      return width * width;
    }
  }
}
