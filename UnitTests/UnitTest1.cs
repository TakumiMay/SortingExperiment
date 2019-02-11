using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingExperiment;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void sortSimple()
        {
            //Arrange
            int[] array = { 4, 16, 2, 5, 10, 60, 100, 102, 40, 20 };

            //Act
            HeapSort.sort(array);
            int[] esperado = { 2, 4, 5, 10, 16, 20, 40, 60, 100, 102 };

            //Assert
            Assert.AreEqual(esperado, array); 

        }

        [TestMethod]
        public void SortSimple2()
        {
            HeapSort hs = new HeapSort();

            int[] array = { 108, 200, 600, 98, 5, 800, 1000, 78, 98 };
            HeapSort.sort(array);

            int[] esperado = { 5, 78, 98, 98, 108, 200, 600, 800, 1000 };
            Assert.AreEqual(esperado, array);
        }


    }
}
