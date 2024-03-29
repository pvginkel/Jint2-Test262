﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Jint.Test262.Ch15._15_8._15_8_2
{
    [TestFixture]
    public class _15_8_2_13Fixture : Test262Fixture
    {
        public _15_8_2_13Fixture()
            : base("ch15\\15.8\\15.8.2\\15.8.2.13")
        {
        }

        [Test(Description = "Checking if Math.pow(x,y) is NaN, where y is NaN")]
        public void S15_8_2_13_A1()
        {
            RunFile("S15.8.2.13_A1.js");
        }

        [Test(Description = "Checking if Math.pow(x,y) equals to +Infinity, where abs(x)<1 and y is -Infinity")]
        public void S15_8_2_13_A10()
        {
            RunFile("S15.8.2.13_A10.js");
        }

        [Test(Description = "Checking if Math.pow(x,y) equals to +Infinity, where x is +Infinity and y>0")]
        public void S15_8_2_13_A11()
        {
            RunFile("S15.8.2.13_A11.js");
        }

        [Test(Description = "Checking if Math.pow(x,y) equals to +0, where x is +Infinity and y<0")]
        public void S15_8_2_13_A12()
        {
            RunFile("S15.8.2.13_A12.js");
        }

        [Test(Description = "Checking if Math.pow(x,y) equals to -Infinity, where x is -Infinity and y>0")]
        public void S15_8_2_13_A13()
        {
            RunFile("S15.8.2.13_A13.js");
        }

        [Test(Description = "Checking if Math.pow(x,y) equals to +Infinity, where x is -Infinity and y>0")]
        public void S15_8_2_13_A14()
        {
            RunFile("S15.8.2.13_A14.js");
        }

        [Test(Description = "Checking if Math.pow(x,y) equals to -0, where x is -Infinity and y<0")]
        public void S15_8_2_13_A15()
        {
            RunFile("S15.8.2.13_A15.js");
        }

        [Test(Description = "Checking if Math.pow(x,y) equals to +0, where x is -Infinity and y<0")]
        public void S15_8_2_13_A16()
        {
            RunFile("S15.8.2.13_A16.js");
        }

        [Test(Description = "Checking if Math.pow(x,y) equals to +0, where x is +0 and y>0")]
        public void S15_8_2_13_A17()
        {
            RunFile("S15.8.2.13_A17.js");
        }

        [Test(Description = "Checking if Math.pow(x,y) equals to +Infinity, where x is +0 and y<0")]
        public void S15_8_2_13_A18()
        {
            RunFile("S15.8.2.13_A18.js");
        }

        [Test(Description = "Checking if Math.pow(x,y) equals to -0, where x is -0 and y>0")]
        public void S15_8_2_13_A19()
        {
            RunFile("S15.8.2.13_A19.js");
        }

        [Test(Description = "Checking if Math.pow(x,y) equals to 1, where y is +0 and x is number or NaN")]
        public void S15_8_2_13_A2()
        {
            RunFile("S15.8.2.13_A2.js");
        }

        [Test(Description = "Checking if Math.pow(x,y) equals to +0, where x is -0 and y>0 and y is NOT an odd integer")]
        public void S15_8_2_13_A20()
        {
            RunFile("S15.8.2.13_A20.js");
        }

        [Test(Description = "Checking if Math.pow(x,y) equals to -Infinity, where x is -0 and y is an odd integer")]
        public void S15_8_2_13_A21()
        {
            RunFile("S15.8.2.13_A21.js");
        }

        [Test(Description = "Checking if Math.pow(x,y) equals to +Infinity, where x is -0 and y<0 and y is NOT an odd integer")]
        public void S15_8_2_13_A22()
        {
            RunFile("S15.8.2.13_A22.js");
        }

        [Test(Description = "Checking if Math.pow(x,y) is NaN, where x<0 and x is finite and y is finite and y is not an integer")]
        public void S15_8_2_13_A23()
        {
            RunFile("S15.8.2.13_A23.js");
        }

        [Test(Description = "Checking if Math.pow(argument1, argument2) is approximately equals to its mathematical value on the set of 64 argument1 values and 64 argument2 values; all the sample values is calculated with LibC")]
        public void S15_8_2_13_A24()
        {
            RunFile("S15.8.2.13_A24.js");
        }

        [Test(Description = "Checking if Math.pow(x,y) equals to 1, where x is number or NaN and y is -0")]
        public void S15_8_2_13_A3()
        {
            RunFile("S15.8.2.13_A3.js");
        }

        [Test(Description = "Checking if Math.pow(x,y) is NaN, where x is NaN and y is nonzero")]
        public void S15_8_2_13_A4()
        {
            RunFile("S15.8.2.13_A4.js");
        }

        [Test(Description = "Checking if Math.pow(x,y) equals to +Infinity, where abs(x)>1 and y is +Infinity")]
        public void S15_8_2_13_A5()
        {
            RunFile("S15.8.2.13_A5.js");
        }

        [Test(Description = "Checking if Math.pow(x,y) equals to +0, where abs(x)>1 and y is -Infinity")]
        public void S15_8_2_13_A6()
        {
            RunFile("S15.8.2.13_A6.js");
        }

        [Test(Description = "Checking if Math.pow(x,y) is NaN, where abs(x)==1 and y is +Infinity")]
        public void S15_8_2_13_A7()
        {
            RunFile("S15.8.2.13_A7.js");
        }

        [Test(Description = "Checking if Math.pow(x,y) is NaN, where abs(x)==1 and y is -Infinity")]
        public void S15_8_2_13_A8()
        {
            RunFile("S15.8.2.13_A8.js");
        }

        [Test(Description = "Checking if Math.pow(x,y) equals to +0, where abs(x)<1 and y is +Infinity")]
        public void S15_8_2_13_A9()
        {
            RunFile("S15.8.2.13_A9.js");
        }
    }
}
