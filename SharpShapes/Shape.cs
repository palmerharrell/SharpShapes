using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
  public class Shape
  {
    public double width { get; set; }
    public double height { get; set; }
    public double depth { get; set; }
    public double radius { get; set; }

    public virtual double calculateArea()
    {
      return width*height;
    }

    public virtual double calculateVolume()
    {
      return width*height*depth;
    }
  }
}
