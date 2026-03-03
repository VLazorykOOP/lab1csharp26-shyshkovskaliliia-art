namespace Lab1.Tests.Tests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void CalcArea_WithP6_ReturnsCorrectArea()
        {
            double p = 6;
            double expected = 1.7320508075688772;

            double actual = Task1.CalcArea(p);
            Assert.AreEqual(expected, actual, 0.0000001, "Площа розрахована неправильно.");
        }

        [TestMethod]
        public void CalcArea_WithZeroPerimeter_ReturnsZero()
        {
            double p = 0;
            double actual = Task1.CalcArea(p);
            Assert.AreEqual(0, actual, 0.000001);
        }
    }
}