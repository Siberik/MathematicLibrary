using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathematicLibrary;

namespace MathematicLibraryTests
{
    [TestClass]
    public class MathematicClassTests
    {
        /// <summary>
        /// Сумма двух и нуля
        /// </summary>
        [TestMethod]
        public void Sum_2And0_Returned0()
        {
            //Arrange
            int x = 2;
            int y = 0;
            int expected = 2;
            //Act
            int actual=MathematicClass.Sum(x, y);
            //Assert
            Assert.AreEqual(expected,actual);
        }
        /// <summary>
        /// Деление двух и двух
        /// </summary>
        [TestMethod]
        public void Div_2And2_Returned1()
        {
            //Arrange
            int x = 2;
            int y = 2;
            int expected = 1;
            //Act
            int actual = MathematicClass.Div(x, y);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
