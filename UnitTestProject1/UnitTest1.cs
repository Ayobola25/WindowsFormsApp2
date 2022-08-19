using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp2;

namespace UnitTestProject1
{ }
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculatorTest(double length, double breath, double result)
        {
            var cal = new Calculator();
            var area = cal.Area(2, 3);
            Assert.AreEqual(5, area);
        }
        
      




    }
       

        
    
