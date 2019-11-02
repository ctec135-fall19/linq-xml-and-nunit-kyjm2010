using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath1ConsoleApp
{
    //make class public to allow library access
    public class MyMath2
    {
         //create the same method as MyMath1 but check it
        public static ushort Multiply(ushort x, ushort y)
        {
            checked
            {
                ushort b = (ushort)(x * y);
                //return value
                return b;
            }
           
        }
    }
}
