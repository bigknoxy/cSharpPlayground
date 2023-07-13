namespace GoofingAround.Tests.Helpers;

using GoofingAround.Helpers;
using GoofingAround.Tests.Supporting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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

    #region Contains Duplicates


    [TestMethod]
    public void ContainsDuplicates_ShouldReturnFalse_WhenArrayIsEmpty()
    {
        // Arrange
        int[] emptyArray = new int[0];

        // Act
        bool result = ArrayHelpers.ContainsDuplicates(emptyArray);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void ContainsDuplicates_ShouldReturnFalse_WhenArrayHasNoDuplicates()
    {
        // Arrange
        int[] array = { 1, 2, 3, 4, 5 };

        // Act
        bool result = ArrayHelpers.ContainsDuplicates(array);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void ContainsDuplicates_ShouldReturnTrue_WhenArrayHasDuplicates()
    {
        // Arrange
        int[] array = { 1, 2, 3, 4, 5, 2 };

        // Act
        bool result = ArrayHelpers.ContainsDuplicates(array);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void ContainsDuplicates_ShouldReturnFalse_WhenArrayHasDuplicateNullElements()
    {
        // Arrange
        string[] array = { null, "Hello", null, "World" };

        // Act
        bool result = ArrayHelpers.ContainsDuplicates(array);

        // Assert        
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void ContainsDuplicates_ShouldReturnTrue_WhenArrayHasDuplicateCustomObjects()
    {
        // Arrange
        Person[] array = {
            new Person("John", 25),
            new Person("Jane", 30),
            new Person("John", 25),
            new Person("Alex", 35)
        };

        // Act
        bool result = ArrayHelpers.ContainsDuplicates(array);

        // Assert
        Assert.IsTrue(result);
    }
    #endregion

    #region duplicate int[] specific 
    [TestMethod]
    public void ContainsDuplications_ShouldRemoveThem()
    {
        //arrange
        int[] ints = { 1, 2, 3,3};
        int[] expected = { 1, 2,3 };

        //Act
        ints = ints.RemoveDuplicates();

        //Assert
        CollectionAssert.AreEqual(expected, ints);
        //Assert.AreEqual(expected, ints);
    }

    [TestMethod]
    public void ContainsNoDuplications_ShouldNotRemoveAnything()
    {
        //arrange
        int[] ints = { 1, 2, 3, 4,5,6,7 };
        int[] expected = { 1, 2, 3,4,5,6,7 };

        //Act
        ints = ints.RemoveDuplicates();

        //Assert
        CollectionAssert.AreEqual(expected, ints);
        //Assert.AreEqual(expected, ints);
    }

    #endregion
}
