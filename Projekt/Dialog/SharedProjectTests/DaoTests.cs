using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharedProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace SharedProject.Tests
{
    [TestClass()]
    public class DaoTests
    {
        Dao dao = new Dao();

        dbDialogoweEntities contex = new dbDialogoweEntities();

        [TestMethod()]
        public void GetFieldTypesTest()
        {
            var result = dao.GetFieldTypes().Count;
            Assert.IsTrue(result > 0);
        }

        [TestMethod()]
        public void checkConnectionTest()
        {
            var result = dao.checkConnection();
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void GetUnitTypesTest()
        {
            var result = dao.GetUnitTypes().Count;
            Assert.IsTrue(result > 0);
        }

        [TestMethod()]
        public void GetFieldsTest()
        {
            var result = dao.GetFields().Count;
            Assert.IsTrue(result > 0);
        }

        [TestMethod()]
        public void GetFieldTest()
        {
            var result = dao.GetField(1).IDField;
            Assert.IsTrue(result == 1);
        }

        [TestMethod()]
        public void GetUserTest()
        {
            var result = dao.GetUser(1).IDUser;
            Assert.IsTrue(result==1);
        }
    }
}