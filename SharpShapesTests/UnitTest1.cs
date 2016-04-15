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

    [TestMethod]
    public void TestCircleArea()
    {
      Circle circle = new Circle();
      circle.radius = 1;
      Assert.IsTrue(circle.calculateArea() == Math.PI);
    }

    [TestMethod]
    public void TestCylinderVolume()
    {
      Cylinder cylinder = new Cylinder();
      cylinder.radius = 1;
      cylinder.height = 1;
      Assert.IsTrue(cylinder.calculateVolume() == Math.PI);
    }

    [TestMethod]
    public void TestPyramidVolume()
    {
      Pyramid pyramid = new Pyramid();
      pyramid.length = 1;
      pyramid.width = 1;
      pyramid.height = 3;
      Assert.IsTrue(pyramid.calculateVolume() == 1);
    }

    [TestMethod]
    public void TestPyramidSides()
    {
      Pyramid pyramid = new Pyramid();
      Assert.IsTrue(pyramid.sides == 5);
    }

    [TestMethod]
    public void TestCircleSides()
    {
      Circle circle = new Circle();
      Assert.IsTrue(circle.sides == 1);
    }

    [TestMethod]
    public void TestCylinderSides()
    {
      Cylinder cylinder = new Cylinder();
      Assert.IsTrue(cylinder.sides == 3);
    }

    [TestMethod]
    public void TestSquareSides()
    {
      Square square = new Square();
      Assert.IsTrue(square.sides == 4);
    }
  }
}
