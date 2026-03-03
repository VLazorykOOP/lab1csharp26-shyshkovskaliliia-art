namespace Lab1.Tests.Tests
{
    [TestClass]
    public class Task2Tests
    {
        [TestMethod]
        public void CheckParity_EvenPositive_ReturnsEven()
        {
            int input = 10;
            string expected = "Even";

            string actual = Task2.CheckParity(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckParity_OddPositive_ReturnsOdd()
        {
            int input = 7;
            string expected = "Odd";

            string actual = Task2.CheckParity(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckParity_Zero_ReturnsEven()
        {
            Assert.AreEqual("Even", Task2.CheckParity(0));
        }

        [TestMethod]
        public void CheckParity_NegativeOdd_ReturnsOdd()
        {
            Assert.AreEqual("Odd", Task2.CheckParity(-3));
        }
    }
}