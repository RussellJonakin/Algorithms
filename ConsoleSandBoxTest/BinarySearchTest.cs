using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleSandBoxTest
{
    [TestClass]
    public class BinarySearchTest
    {
        [TestMethod]
        public void UpperBoundTest_ListOfIntegers_0To100_100IsFound()
        {
            List<int> x = new List<int>();
            int target = 100;

            for (int i = 0; i <= 100; i++)
            {
                x.Add(i);
            }

            Assert.IsTrue(ConsoleSandbox.BinarySearch.HasElement(x, target));
        }

        [TestMethod]
        public void LowerBoundTest_ListOfIntegers_0To100_0IsFound()
        {
            List<int> x = new List<int>();
            int target = 0;

            for (int i = 0; i <= 100; i++)
            {
                x.Add(i);
            }

            Assert.IsTrue(ConsoleSandbox.BinarySearch.HasElement(x, target));
        }

        [TestMethod]
        public void LowerBoundTestPlus1_ListOfIntegers_0To100_1IsFound()
        {
            List<int> x = new List<int>();

            for (int i = 0; i <= 100; i++)
            {
                x.Add(i);
            }

            Assert.IsTrue(ConsoleSandbox.BinarySearch.HasElement(x, 1));
        }

        [TestMethod]
        public void UpperBoundTestMinus1_ListOfIntegers_0To100_99IsFound()
        {
            List<int> x = new List<int>();

            for (int i = 0; i <= 100; i++)
            {
                x.Add(i);
            }

            Assert.IsTrue(ConsoleSandbox.BinarySearch.HasElement(x, 99));
        }

        [TestMethod]
        public void MidPointTest_ListOfIntegers_0To100_50IsFound()
        {
            List<int> x = new List<int>();
            int target = 50;

            for (int i = 0; i <= 100; i++)
            {
                x.Add(i);
            }

            Assert.IsTrue(ConsoleSandbox.BinarySearch.HasElement(x, target));
        }

        [TestMethod]
        public void LessThanMidpointTest_ListOfIntegers_0To100_27IsFound()
        {
            List<int> x = new List<int>();
            int target = 27;

            for (int i = 0; i <= 100; i++)
            {
                x.Add(i);
            }

            Assert.IsTrue(ConsoleSandbox.BinarySearch.HasElement(x, target));
        }

        [TestMethod]
        public void GreaterThanMidpointTest_ListOfIntegers_0To100_84IsFound()
        {
            List<int> x = new List<int>();
            int target = 84;

            for (int i = 0; i <= 100; i++)
            {
                x.Add(i);
            }

            Assert.IsTrue(ConsoleSandbox.BinarySearch.HasElement(x, target));
        }

        [TestMethod]
        public void LargerNumberThanInListTest_ListOfIntegers_0To100_754IsNotFound()
        {
            List<int> x = new List<int>();
            int target = 754;

            for (int i = 0; i <= 100; i++)
            {
                x.Add(i);
            }

            Assert.IsFalse(ConsoleSandbox.BinarySearch.HasElement(x, target));
        }

        [TestMethod]
        public void SmallerNumberThanInListTest_ListOfIntegers_0To100_Negative42IsNotFound()
        {
            List<int> x = new List<int>();
            int target = -42;

            for (int i = 0; i <= 100; i++)
            {
                x.Add(i);
            }

            Assert.IsFalse(ConsoleSandbox.BinarySearch.HasElement(x, target));
        }
    }
}
