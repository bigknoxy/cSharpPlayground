namespace GoofingAround.Tests.Helpers;

using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class ArrayHelpersTests
{
    [TestMethod]
    public void Min_ValidIntArray_ReturnsMinimumValue()
    {
        // Arrange
        int[] numbers = { 5, 2, 8, 1, 9 };

        // Act
        int min = numbers.Min();

        // Assert
        Assert.AreEqual(1, min);
    }

    [TestMethod]
    public void Min_EmptyArray_ThrowsException()
    {
        // Arrange
        int[] emptyArray = new int[0];

        // Act & Assert
        Assert.ThrowsException<InvalidOperationException>(() => emptyArray.Min());
    }

    [TestMethod]
    public void Max_ValidIntArray_ReturnsMaximumValue()
    {
        // Arrange
        int[] numbers = { 5, 2, 8, 1, 9 };

        // Act
        int max = numbers.Max();

        // Assert
        Assert.AreEqual(9, max);
    }

    [TestMethod]
    public void Max_EmptyArray_ThrowsException()
    {
        // Arrange
        int[] emptyArray = new int[0];

        // Act & Assert
        Assert.ThrowsException<InvalidOperationException>(() => emptyArray.Max());
    }
}
