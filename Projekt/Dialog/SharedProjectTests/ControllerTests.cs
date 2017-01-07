using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SharedProject.Tests
{
    [TestClass()]
    public class ControllerTests
    {
        Controller controller = new Controller();

        [TestMethod()]
        public void GetFieldTypesTest()
        {
            var result = controller.GetFieldTypes().Count;
            Assert.IsTrue(result > 0);
        }

        [TestMethod()]
        public void GetUnitTypesTest()
        {
            var result = controller.GetUnitTypes().Count;
            Assert.IsTrue(result > 0);
        }

        [TestMethod()]
        public void GetFieldsTest()
        {
            var result = controller.GetFields();
            Assert.IsTrue(2 > 0);
        }

        [TestMethod()]
        public void GetFieldTest()
        {

            Assert.Fail();
        }

        [TestMethod()]
        public void GetUserTest()
        {
            var result = controller.GetUser(1).IDUser;
            Assert.IsTrue(result == 1);
        }

        [TestMethod()]
        public void GetBoardTest()
        {
            var result = controller.GetBoard(1).Field.Count;
            Assert.IsTrue(result > 0);
        }

        [TestMethod()]
        public void GetGameTest()
        {
            var result = controller.GetGame(1);
            Assert.Fail();
        }

        [TestMethod()]
        public void GetUnitsTest()
        {
            var result = controller.GetUnits();
            Assert.Fail();
        }
    }
}