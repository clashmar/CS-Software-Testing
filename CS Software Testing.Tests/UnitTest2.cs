using FluentAssertions;

namespace CS_Software_Testing.Tests
{
    internal class UnitTest2
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(TestName = "get the total number of all products (i.e. all product ids) in the warehouse")]
        public void GetTotalNumberOfProducts_1()
        {
            WarehouseInventory.NumberOfProducts().Should().Be(0);
        }

        [Test]
        [TestCase(TestName = "get the total number of all products (i.e. all product ids) in the warehouse")]
        public void GetTotalNumberOfProducts_2()
        {
            Product product = new Product(1);

            WarehouseInventory.NumberOfProducts().Should().Be(1);
        }
    }
}
