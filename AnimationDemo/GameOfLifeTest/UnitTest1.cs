using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArraySandBox;

namespace GameOfLifeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CollectionAssert.AreEqual(new int[,]{{1, 1, 0}, {1, 1, 0}, {0, 0, 0}}, 
                            ArraySandBox.ArraySandBox.GetGameOfLifeNextStep(
                                      new int[,]{{1, 1, 0}, {1, 1, 0}, {0, 0, 0}}));
        }
        [TestMethod]
        public void TestMethod2()
        {
            CollectionAssert.AreEqual(new int[,]{{1, 0, 1}, {1, 0, 1}, {0, 0, 0}}, 
                            ArraySandBox.ArraySandBox.GetGameOfLifeNextStep(
                                      new int[,]{{1, 1, 1}, {1, 1, 0}, {0, 0, 0}}));
        }
        [TestMethod]
        public void TestMethod3()
        {
            CollectionAssert.AreEqual(new int[,]{{1, 0, 1}, {0, 0, 0}, {1, 0, 1}}, 
                            ArraySandBox.ArraySandBox.GetGameOfLifeNextStep(
                                      new int[,]{{1, 1, 1}, {1, 1, 1}, {1, 1, 1}}));
        }
    }
}
