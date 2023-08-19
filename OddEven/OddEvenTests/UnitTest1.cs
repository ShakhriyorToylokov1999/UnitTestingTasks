using NUnit.Framework;
using OddEven;
using System;

namespace OddEvenTests
{
    public class Tests
    {

        [Test]
        public void check_FizzBuzz_ReturnsCorrectStrings()
        {
            // Arrange
            int oddNum = 33;
            int evenNum = 20;
            int primeNum = 17;

            // Act
            string result1 = OddEvenPrime.CheckOddEven(oddNum);
            string result2 = OddEvenPrime.CheckOddEven(evenNum);
            string result3 = OddEvenPrime.CheckOddEven(primeNum);

            // Assert
            Assert.That(result1, Is.EqualTo("ODD"));
            Assert.That(result2, Is.EqualTo("EVEN"));
            Assert.That(result3, Is.EqualTo(primeNum.ToString()));
        }

        [Test]
        public void checkFizzBuzz_ThrowsException_WhenInvalidNumberGiven()
        {
            // Arrange
            int invalidNumber = 300;

            // Act && Assert
            Assert.Throws<ArgumentException>(() => OddEvenPrime.CheckOddEven(invalidNumber));

        }
    }
}