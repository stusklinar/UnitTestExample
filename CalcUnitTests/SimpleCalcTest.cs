using System;
using DB;
using Moq;
using NUnit;
using NUnit.Framework;
using ServiceLayer;

namespace CalcUnitTests
{
    public class SimpleCalcTest
    {
        private ServiceLayer.SimpleCalc _simpleCalc;

        [SetUp]
        public void Setup()
        {
            _simpleCalc = new ServiceLayer.SimpleCalc();
        }

        [TestCase(1,1,2)]
        [TestCase(2,2,4)]
        [Test]
        public void TestCalc(int one, int two, double expected)
        {
            Assert.That(_simpleCalc.Calc(one, two),Is.EqualTo(expected));
        }
    }
}
