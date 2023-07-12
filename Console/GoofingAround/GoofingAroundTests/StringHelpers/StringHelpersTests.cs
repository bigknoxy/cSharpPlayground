using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GoofingAround.StringHelpers.Tests
{
    [TestClass()]
    public class StringHelpersTests
    {
        [TestMethod]
        public void ReverseCase_ShouldReverseCaseOfLetters()
        {
            // Arrange
            string input = "Hello World";
            string expected = "hELLO wORLD";

            // Act
            string result = input.ReverseCase();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Reverse_ShouldReverseString()
        {
            // Arrange
            string input = "Hello World";
            string expected = "dlroW olleH";

            // Act
            string result = input.Reverse();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReverseCase_ShouldNotChangeSpecialCharacters()
        {
            // Arrange
            string input = "Hello!@#$%^&*()_+";
            string expected = "hELLO!@#$%^&*()_+";

            // Act
            string result = input.ReverseCase();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Reverse_ShouldReverseStringWithSpecialCharacters()
        {
            // Arrange
            string input = "Hello!@#$%^&*()_+";
            string expected = "+_)(*&^%$#@!olleH";

            // Act
            string result = input.Reverse();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReverseCase_ShouldHandleEmptyString()
        {
            // Arrange
            string input = "";
            string expected = "";

            // Act
            string result = input.ReverseCase();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Reverse_ShouldHandleEmptyString()
        {
            // Arrange
            string input = "";
            string expected = "";

            // Act
            string result = input.Reverse();

            // Assert
            Assert.AreEqual(expected, result);
        }

    }
}