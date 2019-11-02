using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath1ConsoleApp
{
    //make class public to allow library access
    public class MyMath1
    {
        //create a method that multiplies two numbers of ushort type togther
        public static ushort Multiply(ushort x, ushort y)
        {
            ushort b = (ushort)(x * y);
            //return value
            return b;

        }
    }
}
