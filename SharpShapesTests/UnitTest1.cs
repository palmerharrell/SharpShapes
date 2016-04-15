using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpShapes; // is this necessary? Or does the reference take care of this?
using SharpShapes.Shapes;

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
    public void TestSquareType()
    {
      Square square = new Square();
      Assert.IsInstanceOfType(square, typeof(Square));
    }

    [TestMethod]
    public void TestCircleType()
    {
      Circle circle = new Circle();
      Assert.IsInstanceOfType(circle, typeof(Circle));
    }

    [TestMethod]
    public void TestPyramidType()
    {
      Pyramid pyramid = new Pyramid();
      Assert.IsInstanceOfType(pyramid, typeof(Pyramid));
    }

    [TestMethod]
    public void TestCylinderType()
    {
      Cylinder cylinder = new Cylinder();
      Assert.IsInstanceOfType(cylinder, typeof(Cylinder));
    }

    [TestMethod]
    public void TestShapeArea()
    {
      Shape simple = new Shape();
      simple.width = 2;
      simple.height = 2;
      Assert.IsTrue(simple.calculateArea() == 4);
    }

    [TestMethod]
    public void TestShapeVolume()
    {
      Shape simple = new Shape();
      simple.width = 2;
      simple.height = 3;
      simple.depth = 5;
      Assert.IsTrue(simple.calculateVolume() == 30);
    }

    [TestMethod]
    public void TestSquareArea()
    {
      Square square = new Square();
      square.width = 2;
      Assert.IsTrue(square.calculateArea() == 4);
    }
  }
}
