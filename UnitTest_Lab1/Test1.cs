using Lab1;

namespace UnitTest_Lab1
{
    [TestClass]
    public sealed class Test1
    {

        [TestMethod]
        [DataRow(402, 20, 10)]
        // If capacity is equal to 10 (max weight), at least one item should be inside backpack
        public void TestMethodAtLeastOneItemFit(int seed, int n, int capacity)
        {
            Problem problem = new Problem(n, seed);
            Result result = problem.Solve(capacity);
            Assert.AreNotEqual(0, result.items.Count);
        }

        [TestMethod]
        [DataRow(542324, 20, 0)]
        // If capacity is equal to 0, non item should be inside backpack
        public void TestMethodNonItemFit(int seed, int n, int capacity)
        {
            Problem problem = new Problem(n, seed);
            Result result = problem.Solve(capacity);
            Assert.AreEqual(0, result.items.Count);
        }

        [TestMethod]
        [DataRow(0, 10, 40)]
        // This Instance of the problem, should list items: 2 5 0 8 1 6, weight: 38, value: 41
        public void TestMethodCertainInstanceValue(int seed, int n, int capacity)
        {
            Problem problem = new Problem(n, seed);
            Result result = problem.Solve(capacity);
            int[] items = { 2, 5, 0, 8, 1, 6 };
            int expectedValue = 41;
            int expectedWeight = 38;
            foreach (var item in items)
                Assert.IsTrue(result.items.Contains(item));

            Assert.AreEqual(result.sumWeight, expectedWeight);
            Assert.AreEqual(result.sumValue, expectedValue);
        }

        [TestMethod]
        [DataRow(4343, 0, 40)]
        // If number of items is equal to 0, non item should be inside backpack
        public void TestMethodZeroItemsInput(int seed, int n, int capacity)
        {
            Problem problem = new Problem(n, seed);
            Result result = problem.Solve(capacity);
            Assert.AreEqual(result.sumWeight, 0);
            Assert.AreEqual(result.sumValue, 0);
            Assert.AreEqual(result.items.Count, 0);
        }

        [TestMethod]
        [DataRow(746345, 0, 40)]
        // All items weights and values are between 1 and 10
        public void TestMethodCorrectValuesAndWeights(int seed, int n, int capacity)
        {
            Problem problem = new Problem(n, seed);
            foreach (var item in problem.items)
            {
                Assert.IsTrue(item.weight > 0);
                Assert.IsTrue(item.weight < 11);
                Assert.IsTrue(item.value > 0);
                Assert.IsTrue(item.value < 11);
            }
        }
    }
}
