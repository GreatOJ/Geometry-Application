namespace GeoApptest;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeoApplib;

[TestClass]
public class ShapeTests
{
    [TestMethod]
    public void Square_Area_Calculation()
    {
        // Arrange
        var square = new Square(5);

        // Act
        var result = square.CalculateArea();

        // Assert
        Assert.AreEqual(25, result);
    }

    [TestMethod]
    public void Square_Perimeter_Calculation()
    {
        // Arrange
        var square = new Square(5);

        // Act
        var result = square.CalculatePerimeter();

        // Assert
        Assert.AreEqual(20, result);
    }

    [TestMethod]
    public void Rectangle_Area_Calculation()
    {
        // Arrange
        var rectangle = new Rectangle(4, 6);

        // Act
        var result = rectangle.CalculateArea();

        // Assert
        Assert.AreEqual(24, result);
    }

    [TestMethod]
    public void Rectangle_Perimeter_Calculation()
    {
        // Arrange
        var rectangle = new Rectangle(4, 6);

        // Act
        var result = rectangle.CalculatePerimeter();

        // Assert
        Assert.AreEqual(20, result);
    }

    [TestMethod]
    public void Triangle_Area_Calculation()
    {
        // Arrange
        var triangle = new Triangle(3, 4, 5);

        // Act
        var result = triangle.CalculateArea();

        // Assert
        Assert.AreEqual(6, result);
    }

    [TestMethod]
    public void Triangle_Perimeter_Calculation()
    {
        // Arrange
        var triangle = new Triangle(3, 4, 5);

        // Act
        var result = triangle.CalculatePerimeter();

        // Assert
        Assert.AreEqual(12, result);
    }
}
