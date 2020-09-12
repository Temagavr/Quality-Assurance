using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;

namespace Triangle.Tests
{
    public class Tests
    {
        [TestCase(new string[] { "1" }, true)]
        [TestCase(new string[] { "1", "2", "3", "4" }, true)]
        [TestCase(new string[] { "1", "2", "3", "4", "123" }, true)]
        [TestCase(new string[] { "a", "b", "c", "d" }, false)]
        [TestCase(new string[] { "1", "b", "3", "d" }, false)]
        [TestCase(new string[] { "1", "2", "3", "4d" }, false)]
        [TestCase(new string[] { "1", "2", "3", " " }, false)]
        [TestCase(new string[] { "1", "", "3", "d" }, false)]
        [TestCase(new string[] { }, true)]
        [TestCase(new string[] { "" }, false)]
        [TestCase(new string[] { " " }, false)]
        public void CheckArgsTest(string[] args, bool answer)
        {
            Assert.AreEqual(Triangle.Program.CheckArgs(ref args), answer);
        }

        [TestCase(new string[] { "2", "4", "5" }, "Обычный")]
        [TestCase(new string[] { "123", "120", "125" }, "Обычный")]
        [TestCase(new string[] { "2", "2", "2" }, "Равносторонний")]
        [TestCase(new string[] { "4", "4", "4" }, "Равносторонний")]
        [TestCase(new string[] { "2", "4", "4" }, "Равнобедренный")]
        [TestCase(new string[] { "2", "3", "2" }, "Равнобедренный")]
        [TestCase(new string[] { "1", "2", "1" }, "Не Треугольник")]
        [TestCase(new string[] { "2", "4" }, "Не Треугольник")]
        [TestCase(new string[] { "2" }, "Не Треугольник")]
        [TestCase(new string[] { "2", "4", "5", "123" }, "Не Треугольник")]
        [TestCase(new string[] { }, "Не Треугольник")]
        [TestCase(new string[] { "2", "a", "5" }, "Неизвестная ошибка")]
        [TestCase(new string[] { "2", " ", "5" }, "Неизвестная ошибка")]
        [TestCase(new string[] { "2", "4", "5", "asd" }, "Неизвестная ошибка")]
        [TestCase(new string[] { "2", "", "5" }, "Неизвестная ошибка")]
        [TestCase(new string[] { "2", "4", "5sd" }, "Неизвестная ошибка")]
        [TestCase(new string[] { "a" }, "Неизвестная ошибка")]
        [TestCase(new string[] { "2", "4", "5", "asd" }, "Неизвестная ошибка")]
        [TestCase(new string[] { "2", "4d" }, "Неизвестная ошибка")]
        public void CheckTriangleTest(string[] args, string answer)
        {
            Assert.AreEqual(Triangle.Program.CheckTriangle(ref args), answer);
        }
    }
}