using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using System;

namespace Triangle.Tests
{
    public class Tests
    {
        
        [TestCase(new string[] { "1" }, true)]
        [TestCase(new string[] { "1", "2,2", "3", "4,4" }, true)]
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
        [TestCase(new string[] { "123", "120", "125,2" }, "Обычный")]
        [TestCase(new string[] { "123,1", "120,1", "125,2" }, "Обычный")]
        [TestCase(new string[] { "2,2", "2,2", "2,2" }, "Равносторонний")]
        [TestCase(new string[] { "4", "4", "4" }, "Равносторонний")]
        [TestCase(new string[] { "1,78E+308", "1,78E+308", "1,78E+308" }, "Равносторонний")]
        [TestCase(new string[] { "2", "4", "4" }, "Равнобедренный")]
        [TestCase(new string[] { "2,2", "3", "2,2" }, "Равнобедренный")]
        [TestCase(new string[] { "0", "0", "0" }, "Не Треугольник")]
        [TestCase(new string[] { "1", "2,2", "1" }, "Не Треугольник")]
        [TestCase(new string[] { "1,1", "2,2", "1,1" }, "Не Треугольник")]
        [TestCase(new string[] { "2", "4,2" }, "Не Треугольник")]
        [TestCase(new string[] { "2" }, "Не Треугольник")]
        [TestCase(new string[] { "2", "4", "5", "123" }, "Не Треугольник")]
        [TestCase(new string[] { }, "Не Треугольник")]
        [TestCase(new string[] { "2", "-4", "5" }, "Неизвестная ошибка")]
        [TestCase(new string[] { "", "", "" }, "Неизвестная ошибка")]
        [TestCase(new string[] { " ", " ", " " }, "Неизвестная ошибка")]
        [TestCase(new string[] { "2", "a", "5" }, "Неизвестная ошибка")]
        [TestCase(new string[] { "2", " ", "5" }, "Неизвестная ошибка")]
        [TestCase(new string[] { "2", " ", "5.4" }, "Неизвестная ошибка")]
        [TestCase(new string[] { "2", "4,2", "5", "asd" }, "Неизвестная ошибка")]
        [TestCase(new string[] { "2", "", "5sa" }, "Неизвестная ошибка")]
        [TestCase(new string[] { "2", "", "5" }, "Неизвестная ошибка")]
        [TestCase(new string[] { "2", "4", "5sd" }, "Неизвестная ошибка")]
        [TestCase(new string[] { "a" }, "Неизвестная ошибка")]
        [TestCase(new string[] { "as", "s", "d", "asd" }, "Неизвестная ошибка")]
        [TestCase(new string[] { "2", "4,1", "5", "asd" }, "Неизвестная ошибка")]
        [TestCase(new string[] { "2", "4d" }, "Неизвестная ошибка")]
        [TestCase(new string[] { "2E+309", "2E+308", "2E+307" }, "Неизвестная ошибка")]
        [TestCase(new string[] { "-2E+309", "2E+308", "-2E+307" }, "Неизвестная ошибка")]
        [TestCase(new string[] { "0xAA", "20", "10" }, "Неизвестная ошибка")]
        public void CheckTriangleTest(string[] args, string answer)
        {
            Assert.AreEqual(Triangle.Program.CheckTriangle(ref args), answer);
        }
    }
}