using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes.Shapes
{
  public class Cylinder : Shape
  {
    public override double calculateVolume()
    {
      // V = πr2h
      return Math.PI * radius * radius * height;
    }
  }
}
