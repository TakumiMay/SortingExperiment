using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingExperiment;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void HeapSortSimple()
        {
            //Arrange
            int[] array = { 4, 16, 2, 5, 10, 60, 100, 102, 40, 20 };

            //Act
            HeapSort.sort(array);

            int[] esperado = { 2, 4, 5, 10, 16, 20, 40, 60, 100, 102 };

            //Assert
            for (int i = 0; i < esperado.Length; i++)
            {
                Assert.IsTrue(esperado[i] == array[i]);
            }
            //Assert.AreEqual(esperado, array); 


        }

        [TestMethod]
        public void HeapSortSimple2()
        {
            HeapSort hs = new HeapSort();

            int[] array = { 108, 200, 600, 98, 5, 800, 1000, 78, 98 };
            HeapSort.sort(array);

            int[] esperado = { 5, 78, 98, 98, 108, 200, 600, 800, 1000 };
            //Assert
            for (int i = 0; i < esperado.Length; i++)
            {
                Assert.IsTrue(esperado[i] == array[i]);
            }
        }

        [TestMethod]
        public void HeapSortSimple3()
        {
            int[] array = { 70, 45, 41, 39, 36, 30, 14, 5, 1, 0 };
            HeapSort.sort(array);
            int[] esperado = { 0, 1, 5, 14, 30, 36, 39, 41, 45, 70 };
            for (int i = 0; i < esperado.Length; i++)
            {
                Assert.IsTrue(esperado[i] == array[i]);
            }
        }

        [TestMethod]
        public void HeapSortBig()
        {
            int[] array = generateRandom(1000);
            HeapSort.sort(array);
            for (int i = 0; i < array.Length-1; i++)
            {
                Assert.IsTrue(array[i] <= array[i+1]);
            }
        }
        [TestMethod]
        public void HeapSortBigger()
        {
            int[] array = generateRandom(1000000);
            HeapSort.sort(array);
            for (int i = 0; i < array.Length - 1; i++)
            {
                Assert.IsTrue(array[i] <= array[i + 1]);
            }
        }
        public int[] generateRandom(int max)
        {
            int[] array = new int[max];
            for (int i = 0; i < max; i++)
            {
                array[i] = (new Random()).Next(1, max);
            }


            return array;




        }
    }
}
