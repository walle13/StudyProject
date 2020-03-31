using System;
using Xunit;
using InterfaceExample4;
using Moq;

namespace InterfaceExample.Tests
{
    public class DeskFanTests
    {
        [Fact]
        public void PowerLowerThanZero_OK()
        {
            var mock = new Mock<IPowerSupply>();
            mock.Setup(ps => ps.GetPower()).Returns(() => 0);

            var fan1 = new DeskFan(mock.Object);
            var expected1 = "Won't work";
            var actual1 = fan1.Work();
            Assert.Equal(expected1, actual1);

        }

        [Fact]
        public void PowerHigherThan200_Warning()
        {
            var mock = new Mock<IPowerSupply>();
            mock.Setup(ps => ps.GetPower()).Returns(() => 200);

            var fan = new DeskFan(mock.Object);
            var expected = "Warning!";
            var actual = fan.Work();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PowerLowerThan100_Work()
        {
            var mock = new Mock<IPowerSupply>();
            mock.Setup(ps => ps.GetPower()).Returns(() => 100);

            var fan = new DeskFan(mock.Object);
            var expected = "Work fine";
            var actual = fan.Work();
            Assert.Equal(expected, actual);
        }
    }

    /*
    class PowerSupplyLowerThanZero:IPowerSupply
    {
        public int GetPower()
        {
            return 0;
        }
    }

    class PowerSupplyLowerThanHundred : IPowerSupply
    {
        public int GetPower()
        {
            return 90;
        }
    }

    class PowerSupplyLowerThanTwoHundred : IPowerSupply
    {
        public int GetPower()
        {
            return 112;
        }
    }

    class PowerSupplyLowerThanThreeHundred : IPowerSupply
    {
        public int GetPower()
        {
            return 220;
        }
    }
    */

}
