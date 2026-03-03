namespace Lab1.Tests.Tests
{
    [TestClass]
    public class Task6Tests
    {
        // 1. УСПІШНИЙ ТЕСТ (Passed)
        [TestMethod]
        public void CalcZ_StandardValues_ReturnsCorrectResult()
        {
            
            double x = 1.0;
            double y = 2.0;
            double expected = 3.0;

            double actual = Task6.CalcZ(x, y);
            Assert.AreEqual(expected, actual, 0.0001, "Розрахунок для x=1, y=2 має дорівнювати 3");
        }

        // 2. ПРОВАЛЕНИЙ ТЕСТ (Failed)
        [TestMethod]
        public void CalcZ_IncorrectExpectation_ReturnsFailure()
        {
            double x = 2.0;
            double y = 2.0;
            double expected = 100.0;
            double actual = Task6.CalcZ(x, y);

            Assert.AreEqual(expected, actual, 0.0001, "Цей тест навмисно провалено.");
        }

        [TestMethod]
        public void CalcZ_DivisionByZero_ReturnsInfinity()
        {
            // Якщо y = 0, то (1 / (x * y)) дасть Infinity
            double actual = Task6.CalcZ(1.0, 0.0);

            Assert.IsTrue(double.IsInfinity(actual), "Результат має бути нескінченністю при y=0");
        }
    }
}