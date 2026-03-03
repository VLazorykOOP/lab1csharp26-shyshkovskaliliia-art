namespace Lab1.Tests.Tests
{
    [TestClass]
    public class Task4Tests
    {
        [TestMethod]
        [DataRow(1, 31, 30)]   // Початок місяця (січень)
        [DataRow(15, 30, 15)]  // Середина місяця (квітень)
        [DataRow(20, 28, 8)]   // Лютий у звичайний рік
        [DataRow(30, 31, 1)]   // Передостанній день
        public void CalcRemaining_ValidDates_ReturnsCorrectDays(int day, int daysInMonth, int expected)
        {
            // Act
            int actual = Task4.CalcRemaining(day, daysInMonth);

            // Assert
            Assert.AreEqual(expected, actual, $"Помилка для дня {day} у місяці з {daysInMonth} днями.");
        }

        [TestMethod]
        public void CalcRemaining_LastDayOfMonth_ReturnsZero()
        {
            // Arrange
            int day = 31;
            int daysInMonth = 31;

            // Act
            int result = Task4.CalcRemaining(day, daysInMonth);

            // Assert
            Assert.AreEqual(0, result, "В останній день місяця має залишитися 0 днів.");
        }

        [TestMethod]
        public void CalcRemaining_FirstDayOfShortMonth_ReturnsCorrectValue()
        {
            // Перевірка для лютого (28 днів)
            Assert.AreEqual(27, Task4.CalcRemaining(1, 28));
        }
    }
}