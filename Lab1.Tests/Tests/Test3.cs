namespace Lab1.Tests.Tests
{
    [TestClass]
    public class Task3Tests
    {
        // 1. Точки всередині області
        [TestMethod]
        [DataRow(3f, 0f)]    // Центр ближче до осі
        [DataRow(5f, 5f)]    // 25 + 25 = 50 < 81
        [DataRow(1f, -8f)]   // 1 + 64 = 65 < 81
        public void CheckPoint_InsideArea_ReturnsInside(float x, float y)
        {
            string result = Task3.CheckPoint(x, y);
            Assert.AreEqual("Так (всередині)", result);
        }

        // 2. Точки безпосередньо на межі (Дуга та Вісь)
        [TestMethod]
        [DataRow(9f, 0f)]    // На правій крайній точці дуги
        [DataRow(0f, 9f)]    // Верхня точка на осі Y
        [DataRow(0f, -9f)]   // Нижня точка на осі Y
        [DataRow(0f, 0f)]    // Початок координат (теж на межі за вашим кодом)
        public void CheckPoint_OnBoundary_ReturnsOnBoundary(float x, float y)
        {
            string result = Task3.CheckPoint(x, y);
            Assert.AreEqual("На межі", result);
        }

        // 3. Точки поза областю (за радіусом)
        [TestMethod]
        [DataRow(10f, 0f)]   // Занадто далеко вправо
        [DataRow(7f, 7f)]    // 49 + 49 = 98 > 81
        [DataRow(0f, 10f)]   // Вище межі по осі Y
        public void CheckPoint_OutsideRadius_ReturnsOutside(float x, float y)
        {
            string result = Task3.CheckPoint(x, y);
            Assert.AreEqual("Ні (поза областю)", result);
        }

        // 4. Точки в лівій півплощині (x < 0)
        [TestMethod]
        [DataRow(-1f, 0f)]   // Близько до центру, але зліва
        [DataRow(-9f, 0f)]   // На відстані радіусу, але зліва
        public void CheckPoint_LeftHalfPlane_ReturnsOutside(float x, float y)
        {
            string result = Task3.CheckPoint(x, y);
            Assert.AreEqual("Ні (поза областю)", result);
        }
    }
}