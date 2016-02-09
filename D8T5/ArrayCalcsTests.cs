using Microsoft.VisualStudio.TestTools.UnitTesting;
using D8T5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D8T5.Tests
{
    [TestClass()]
    public class ArrayCalcsTests
    {
        [TestMethod()]
        public void SumTest()
        {
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double actual = ArrayCalcs.Sum(array);
            Assert.AreEqual(array.Sum(), actual);
        }

        [TestMethod()]
        public void AverageTest()
        {
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double actual = ArrayCalcs.Average(array); 
            Assert.AreEqual(array.Sum()/array.Length, actual);
        }

        [TestMethod()]
        public void MinTest()
        {
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double actual = ArrayCalcs.Min(array);
            Assert.AreEqual(array.Min(), actual);
        }

        [TestMethod()]
        public void MaxTest()
        {
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double actual = ArrayCalcs.Max(array);
            Assert.AreEqual(array.Max(), actual);
        }
    }
}
