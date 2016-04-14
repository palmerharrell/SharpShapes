using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
  public class Shape
  {
    public double width;
    public double height;
    public double depth;
    public double calculateArea()
    {
      return width*height;
    }
  }
}
