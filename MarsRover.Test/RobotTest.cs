using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRover.Library;

namespace MarsRover.Test
{
    [TestClass]
    public class RobotTest
    {
        [TestMethod][Priority(0)][TestCategory("Robot Control")]
        public void RobotLocation_Control()
        {
            Robots robots = new Robots();
            bool rbt = robots.xycontrol(1,1);
            Assert.IsTrue(rbt,"kordinat deðerleri doðru aralýkta deðil");
        }
    }
}
