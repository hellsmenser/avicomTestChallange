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
            //���������
            TestClass ts = new TestClass();
            ts.name = "����������������3";
            bool TestResult;
            bool ActualResult = true;

            //����������
            TestResult = ts.addFunc();

            //��������
            Assert.AreEqual(ActualResult, TestResult);

        }

        [TestMethod]
        public void NewManagerBadCreating()
        {
            //���������
            TestClass ts = new TestClass();
            ts.name = null;
            bool TestResult;
            bool ActualResult = false;

            //����������
            TestResult = ts.addFunc();

            //��������
            Assert.AreEqual(ActualResult, TestResult);

        }

        [TestMethod]
        public void RemoveManagerGoodRemoving()
        {
            //���������
            TestClass ts = new TestClass();
            ts.curid = 3;
            bool TestResult;
            bool ActualResult = true;

            //����������
            TestResult = ts.removeFunc();

            //��������
            Assert.AreEqual(ActualResult, TestResult);

        }


        [TestMethod]
        public void RemoveManagerBadRemoving()
        {
            //���������
            TestClass ts = new TestClass();
            bool TestResult;
            bool ActualResult = false;

            //����������
            TestResult = ts.removeFunc();

            //��������
            Assert.AreEqual(ActualResult, TestResult);

        }
    }
}
