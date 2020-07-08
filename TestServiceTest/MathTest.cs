using NUnit.Framework;
using System;
using TestServiceApp;

namespace TestServiceTest
{
    public class Tests
    {
        private MathService _mathService;

        [SetUp]
        public void Setup()
        {
            _mathService =new MathService();
        }

        [Test]
        public void AdditionTest()
        {
            double expected = 20;
            double actual = _mathService.Addition(10, 10);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SubtractionTest()
        {
            double expected = 10;
            double actual = _mathService.Subtraction(20, 10);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void MultiplicationTest()
        {
            double expected = 100;
            double actual = _mathService.Multiplication(10, 10);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void DivisionTest()
        {
            double expected = 4;
            double actual = _mathService.Division(20, 5);
            Assert.AreEqual(expected, actual);
        }

    }
}