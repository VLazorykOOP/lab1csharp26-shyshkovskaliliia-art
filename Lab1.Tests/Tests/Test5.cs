namespace Lab1.Tests.Tests
{
    [TestClass]
    public class Task5Tests
    {
        // Цей тест буде УСПІШНИМ (Passed)
        [TestMethod]
        public void Calc_PositiveNumbers_ReturnsCorrectDifference()
        {
            // Arrange
            int a = 10;
            int b = 4;
            int expected = 6; // 10 - 4 = 6

            // Act
            int actual = Task5.Calc(a, b);

            // Assert
            Assert.AreEqual(expected, actual, "Розрахунок має бути правильним.");
        }

        // Цей тест буде ПРОВАЛЕНИМ (Failed)
        [TestMethod]
        public void Calc_IncorrectExpectation_ReturnsFailure()
        {
            // Arrange
            int a = 5;
            int b = 2;
            int expected = 100; // Навмисно пишемо неправильний результат (має бути 3)

            // Act
            int actual = Task5.Calc(a, b);

            // Assert
            // Тест впаде, тому що actual (3) не дорівнює expected (100)
            Assert.AreEqual(expected, actual, "Цей тест навмисно провалено для демонстрації.");
        }
    }
}