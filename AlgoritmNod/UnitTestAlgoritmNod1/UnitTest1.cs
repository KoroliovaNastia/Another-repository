using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using AlgoritmNod;

namespace UnitTestAlgoritmNod1
{
    [TestClass]
    public class TestAlgoritms
    {
        [TestMethod]
        public void TestEuclidsAlgoritmForTwoNamber()
        {
            //arrange
            int a = 1056279;
            int b = 905382;
            int nod = 150897;
            long time;
            //actual
            int actual=Logic.NodE(a,b,out time);
            //assert
            Assert.AreEqual(nod,actual);
            Debug.WriteLine("time:" + time+","+actual);
        }
        [TestMethod]
        public void TestEuclidsAlgoritmForThreeNamber()
        {
            //arrange
            int a = 1071;
            int b = 462;
            int c = 7;
            int nod = 7;
            long time;
            //actual
            int actual = Logic.NodE(a, b, c, out time);
            //assert
            Assert.AreEqual(nod, actual);
            Debug.WriteLine("time:" + time);
        }
        [TestMethod]
        public void TestEuclidsAlgoritmForList()
        {
            //arrange
            int[] list = { 897, 364, 1183, 572 };
            long time;
            int nod = 13;
            //actual
            int actual = Logic.NodE(out time, list);
            //assert
            Assert.AreEqual(nod, actual);
            Debug.WriteLine("time:" + time);
        }
        //[TestMethod]
        //public void TestStanesAlgoritm()
        //{
        //}
    }
}
