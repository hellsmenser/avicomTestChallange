using avicomTestChallange.windows.EditData.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ProjectTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NewManagerGoodCreating()
        {
            //настройка
            TestClass ts = new TestClass();
            ts.name = "Модульнотестовый3";
            bool TestResult;
            bool ActualResult = true;

            //выполнение
            TestResult = ts.addFunc();

            //проверка
            Assert.AreEqual(ActualResult, TestResult);

        }

        [TestMethod]
        public void NewManagerBadCreating()
        {
            //настройка
            TestClass ts = new TestClass();
            ts.name = null;
            bool TestResult;
            bool ActualResult = false;

            //выполнение
            TestResult = ts.addFunc();

            //проверка
            Assert.AreEqual(ActualResult, TestResult);

        }

        [TestMethod]
        public void RemoveManagerGoodRemoving()
        {
            //настройка
            TestClass ts = new TestClass();
            ts.curid = 3;
            bool TestResult;
            bool ActualResult = true;

            //выполнение
            TestResult = ts.removeFunc();

            //проверка
            Assert.AreEqual(ActualResult, TestResult);

        }


        [TestMethod]
        public void RemoveManagerBadRemoving()
        {
            //настройка
            TestClass ts = new TestClass();
            bool TestResult;
            bool ActualResult = false;

            //выполнение
            TestResult = ts.removeFunc();

            //проверка
            Assert.AreEqual(ActualResult, TestResult);

        }
    }
}
