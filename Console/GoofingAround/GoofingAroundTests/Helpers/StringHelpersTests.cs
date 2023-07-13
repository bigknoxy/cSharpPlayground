using GoofingAround.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GoofingAround.Tests.Helpers
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

        [TestMethod]
        public void LetterCount_ShouldHandleEmptyString()
        {
            // Arrange
            string stringToCheck = "";
            char letterToFind = 'a';
            int expected = 0;

            // Act
            int result = StringHelpers.LetterCount(stringToCheck, letterToFind);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LetterCount_CountUpperAndLowercase()
        {
            // Arrange
            string stringToCheck = "Good ole boys, gettin' down on the farm";
            char letterToFind = 'g';
            int expected = 2;

            // Act
            int result = StringHelpers.LetterCount(stringToCheck, letterToFind);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LetterCount_ShouldReturnCount_WhenLetterToFindIsASpace()
        {
            // Arrange
            string stringToCheck = "Hello World";
            char letterToFind = ' ';
            int expected = 1;

            // Act
            int result = StringHelpers.LetterCount(stringToCheck, letterToFind);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LetterCount_ShouldIgnoreCase_WhenComparingLetterToFind()
        {
            // Arrange
            string stringToCheck = "Hello World";
            char letterToFind = 'H';
            int expected = 1;

            // Act
            int result = StringHelpers.LetterCount(stringToCheck, letterToFind);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LetterCount_ShouldReturnCount_WhenLetterToFindIsInString()
        {
            // Arrange
            string stringToCheck = "Hello World";
            char letterToFind = 'o';
            int expected = 2;

            // Act
            int result = StringHelpers.LetterCount(stringToCheck, letterToFind);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LetterCount_ShouldReturnZero_WhenLetterToFindIsNotInString()
        {
            // Arrange
            string stringToCheck = "Hello World";
            char letterToFind = 'a';
            int expected = 0;

            // Act
            int result = StringHelpers.LetterCount(stringToCheck, letterToFind);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LetterCount_ShouldReturnZero_WhenStringIsEmpty()
        {
            // Arrange
            string stringToCheck = "";
            char letterToFind = 'a';
            int expected = 0;

            // Act
            int result = StringHelpers.LetterCount(stringToCheck, letterToFind);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsPalindrome_ValidPalindrome_ReturnsTrue()
        {
            // Arrange
            string palindrome = "level";

            // Act
            bool result = palindrome.IsPalindrome();

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindrome_ValidNonPalindrome_ReturnsFalse()
        {
            // Arrange
            string nonPalindrome = "hello";

            // Act
            bool result = nonPalindrome.IsPalindrome();

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsPalindrome_EmptyString_ReturnsTrue()
        {
            // Arrange
            string emptyString = "";

            // Act
            bool result = emptyString.IsPalindrome();

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindrome_StringWithWhitespace_ReturnsTrue()
        {
            // Arrange
            string stringWithWhitespace = "A man a plan a canal Panama";

            // Act
            bool result = stringWithWhitespace.IsPalindrome();

            // Assert
            Assert.IsTrue(result);
        }
    }
}