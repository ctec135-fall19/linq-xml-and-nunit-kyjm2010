using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//use NUnit and MyMath1ConsoleApp
using NUnit.Framework;
using MyMath1ConsoleApp;
//ensure correct namespace
namespace MyMath2.UnitTests
{
    //mark a class as being a TestFixture
    [TestFixture]
    //create the class that will test MyMath2
    public class MyMath2Tests
    {
        //test that asserts that MyMath2 1*9 equals 9, sum returned is correct
        [Test]
        public void Add_SumWithinUshortRange_ReturnCorrectSum()
        {
            Assert.That(MyMath1ConsoleApp.MyMath2.Multiply(1, 9), Is.EqualTo(9));
        }

        //test that asserts that MyMath2 100 * 900 will throw an error due to
        //being outside the ushort range

        [Test] 
        public void Add_SumOutsideUshortRange_ThrowsException() 
        { 
            Assert.That(() => MyMath1ConsoleApp.MyMath2.Multiply(100, 900), Throws.Exception); 
        }
    }
}