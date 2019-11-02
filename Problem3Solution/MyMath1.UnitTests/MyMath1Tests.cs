using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//use NUnit and MyMath1ConsoleApp
using NUnit.Framework;
using MyMath1ConsoleApp;
//ensure correct namespace
namespace MyMath1.UnitTests
{
    //mark a class as being a TestFixture
    [TestFixture]
    //create the class that will test MyMath1
    public class MyMath1Tests
    {
        //test that asserts that MyMath1 1*9 equals 9, sum returned is correct
        [Test] 
        public void Add_SumWithinUshortRange_ReturnCorrectSum()
        {
            Assert.AreEqual(9, MyMath1ConsoleApp.MyMath1.Multiply(1, 9));
        }
        //test that asserts that MyMath1 100*900 equals 90000, sum returned is
        //incorrect
        [Test] 
        public void Add_SumOutsideUshortRange_ReturnIncorrectSum() 
        
        { 
            Assert.AreEqual(90000, MyMath1ConsoleApp.MyMath1.Multiply(100, 900)); 
        }

    }
}
