using HarryPotter;
using NUnit.Framework;

namespace HarryPotterTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculatePriceMethod_ReturnsCorrectPrice()
        {
            int[] testBasket = { 2, 2, 2, 1, 1 };
            double expectedPrice = 51.60;

            var actual = HarryPotter.HarryPotter.CalculatePrice(testBasket);

            Assert.AreEqual(expectedPrice, actual); 
        }
    }
}