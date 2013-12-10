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
    public class _15_8_2_9Fixture : Test262Fixture
    {
        public _15_8_2_9Fixture()
            : base("ch15\\15.8\\15.8.2\\15.8.2.9")
        {
        }

        [Test(Description = "Checking if Math.floor(NaN) is NaN")]
        public void S15_8_2_9_A1()
        {
            RunFile("S15.8.2.9_A1.js");
        }

        [Test(Description = "Checking if Math.floor(x) is +0, where x is +0")]
        public void S15_8_2_9_A2()
        {
            RunFile("S15.8.2.9_A2.js");
        }

        [Test(Description = "Checking if Math.floor(x) is -0, where x is -0")]
        public void S15_8_2_9_A3()
        {
            RunFile("S15.8.2.9_A3.js");
        }

        [Test(Description = "Checking if Math.floor(x) is +Infinity, where x is +Infinity")]
        public void S15_8_2_9_A4()
        {
            RunFile("S15.8.2.9_A4.js");
        }

        [Test(Description = "Checking if Math.floor(x) is -Infinity, where x is -Infinity")]
        public void S15_8_2_9_A5()
        {
            RunFile("S15.8.2.9_A5.js");
        }

        [Test(Description = "Checking if Math.floor(x) is +0, where x is greater than 0 but less than 1")]
        public void S15_8_2_9_A6()
        {
            RunFile("S15.8.2.9_A6.js");
        }

        [Test(Description = "Checking if Math.floor(x) is equal to -Math.ceil(-x) on 2000 floating-point argument values")]
        public void S15_8_2_9_A7()
        {
            RunFile("S15.8.2.9_A7.js");
        }
    }
}