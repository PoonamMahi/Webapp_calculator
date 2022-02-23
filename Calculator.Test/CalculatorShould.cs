using NUnit.Framework;
using Calculator.Library;
using System;

namespace Calculator.Test
{
    public class CalculatorShould
    {
        private CalculatorEvents _calculatorEvents;
        [SetUp]
        public void Setup()
        {
             _calculatorEvents=new CalculatorEvents();
        }

        [TearDown]
        public void TearDown()
        {
            _calculatorEvents = null;
        }

        //Addtion Task scenario Tests
        [Test]
        [TestCase(10,20)]
        [TestCase(20,30)]
        [TestCase(30,100)]
        [TestCase(100,40)]
        [TestCase(9,1)]
        [TestCase(23,55)]
        [TestCase(11,23)]
        [TestCase(12,56)]   
        [TestCase(88,99)]
        [TestCase(44,55)]
        public void Should_Perform_Addtion_Task(int x,int y)
        {
            var result=_calculatorEvents.Addition(x, y);
            Assert.IsNotNull(result);
            Assert.AreEqual(result, x + y);
        }
        //Subtraction Task scenario Tests
        [Test]
        [TestCase(12, 20)]
        [TestCase(22, 30)]
        [TestCase(33, 100)]
        [TestCase(130, 40)]
        [TestCase(33, 1)]
        [TestCase(25, 55)]
        [TestCase(17, 23)]
        [TestCase(19, 56)]
        [TestCase(80, 99)]
        [TestCase(40, 55)]
        public void Should_Perform_Subtraction_Task(int x, int y)
        {
            var result = _calculatorEvents.Subtraction(x, y);
            Assert.IsNotNull(result);
            Assert.AreEqual(result, x - y);
        }

        //Division Task scenario Tests
        [Test]
        [TestCase(12, 20)]
        [TestCase(22, 30)]
        [TestCase(33, 100)]
        [TestCase(130, 40)]
        [TestCase(33, 1)]
        [TestCase(25, 55)]
        [TestCase(17, 23)]
        [TestCase(19, 56)]
        [TestCase(80, 99)]
        [TestCase(40, 55)]
        public void Should_Perform_Division_Task(int x, int y)
        {
            var result = _calculatorEvents.Division(x, y);
            Assert.IsNotNull(result);
            Assert.AreEqual(result, x/y);
        }

        [Test]
        [TestCase(10,0)]
        [TestCase(0,0)]
        public void Division_Task_Should_Throw_Exception(int x,int y)
        {
            var result =Assert.Throws<Exception>(() => _calculatorEvents.Division(x, y));
            Assert.That(result.Message, Is.EqualTo("Attempted to divide by zero."));
        }

        //Multiplication Task scenario Tests
        [Test]
        [TestCase(12, 20)]
        [TestCase(22, 30)]
        [TestCase(33, 100)]
        [TestCase(130, 40)]
        [TestCase(33, 1)]
        [TestCase(25, 55)]
        [TestCase(17, 23)]
        [TestCase(19, 56)]
        [TestCase(80, 99)]
        [TestCase(40, 55)]
        public void Should_Perform_Multiplication_Task(int x, int y)
        {
            var result = _calculatorEvents.Multiplication(x, y);
            Assert.IsNotNull(result);
            Assert.AreEqual(result, x*y);
        }
    }
}