using CalculatorApp;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace CalculatorApp.CalculatorTests
{
    public class Tests
    {
        [TestFixture]
        public class Operations
        {
            private Calculator _calculator;

            [SetUp]
            public void SetUp()
            {
                _calculator = new Calculator();
            }

            [Test]
            public void Add()
            {
                ClassicAssert.AreEqual(_calculator.Add(15, 7), 22);
            }

            [Test]
            public void Substract()
            {
                ClassicAssert.AreEqual(_calculator.Subtract(80, 23), 57);
            }

            [Test]
            public void Multiply()
            {
                ClassicAssert.AreEqual(_calculator.Multiply(3, 7), 21);
            }

            [Test]
            public void Divide()
            {
                ClassicAssert.AreEqual(_calculator.Divide(80, 10), 8);
            }

            [Test]
            public void Percentage()
            {
                ClassicAssert.AreEqual(_calculator.Percentage(3, 5), 0.15);
            }
        }

    }
}