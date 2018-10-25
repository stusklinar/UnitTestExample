using System.Collections.Generic;
using DB;
using Moq;
using NUnit.Framework;
using ServiceLayer;
using Web.Controllers;

namespace CalcUnitTests
{
    public class CalcTests
    {
        private Mock<IRepoLayer> _mockRepoLayer;
        private Mock<ISimpleCalc> _mockSimpleCalc;

        private ValuesController _valuesController;

        [SetUp]
        public void Setup()
        {
            _mockRepoLayer = new Mock<IRepoLayer>();
            _mockSimpleCalc = new Mock<ISimpleCalc>();
            _valuesController = new ValuesController(_mockSimpleCalc.Object, _mockRepoLayer.Object);


        }


        [Test]

        public void TestCalc()
        {
            _mockRepoLayer.Setup(x => x.GetNumbers()).Returns(() => new List<KeyValuePair<int, int>>()
            {
                new KeyValuePair<int, int>(It.IsAny<int>(), It.IsAny<int>())
            });

            _mockSimpleCalc.Setup(x => x.Calc(It.IsAny<int>(), It.IsAny<int>())).Returns(It.IsAny<double>);

            var results = _valuesController.Get();
            Assert.That(results, Is.Not.Null);
            _mockRepoLayer.Verify(x=>x.GetNumbers(),Times.Once);

        }
    }
}
