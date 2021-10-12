using System.Collections.Generic;
using Discount;
using NUnit.Framework;

namespace DiscountTests
{
    [TestFixture]
    public class DiscountCounterTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new int[] {50, 20, 30, 17, 100}, 10 , "207.00")]
        [TestCase(new int[] {1, 2, 3, 4, 5, 6, 7}, 100 , "15.00")]
        [TestCase(new int[] {1, 1, 1}, 33 , "2.67")]
        public void DiscountCounter_ReturnsCorrectValue(int[] inputList, int discountPercent, string output)
        {
            Assert.AreEqual( output, DiscountCounter.ApplyDiscount(new List<int>(inputList), discountPercent));
        }
    }
}