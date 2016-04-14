using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpShapes; // is this necessary? Or does the reference take care of this?

namespace SharpShapesTests
{
  [TestClass]
  public class Test
  {
    [TestMethod]
    public void TestShapeType()
    {
      Shape simple = new Shape();
      Assert.IsInstanceOfType(simple, typeof(Shape));
    }

    [TestMethod]
    public void TestShapeArea()
    {
      Shape simple = new Shape();
      simple.width = 2;
      simple.height = 2;
      Assert.IsTrue(simple.calculateArea() == 4);
    }

    //[TestMethod]
    //public void TestShapeVolume()
    //{
    //  Shape simple = new Shape();
    //  simple.width = 2;
    //  simple.height = 3;
    //  simple.depth = 5;
    //  Assert.IsTrue(simple.calculateVolume() == 30);
    //}
  }
}
