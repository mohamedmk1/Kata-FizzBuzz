using Kata1;
using NUnit.Framework;

namespace Kata1Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Should_return_number()
        {
            // Arrange
            FizzBuzz fb = new FizzBuzz();
            string expectedResult = "4";

            // Act
            string result = fb.GetNumber(4);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void Should_return_fizz_if_number_is_divisible_by_3()
        {
            // Arrange
            FizzBuzz fb = new FizzBuzz();
            string expectedResult = "fizz";

            // Act
            string result = fb.GetNumber(3);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void Should_return_buzz_if_number_is_divisible_by_5()
        {
            // Arrange
            FizzBuzz fb = new FizzBuzz();
            string expectedResult = "buzz";

            // Act
            string result = fb.GetNumber(10);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void Should_return_fizzbuzz_if_number_is_divisible_by_3_and_5()
        {
            // Arrange
            FizzBuzz fb = new FizzBuzz();
            string expectedResult = "fizzbuzz";

            // Act
            string result = fb.GetNumber(15);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }
    }
}