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
    public class _15_8_2_15Fixture : Test262Fixture
    {
        public _15_8_2_15Fixture()
            : base("ch15\\15.8\\15.8.2\\15.8.2.15")
        {
        }

        [Test(Description = "Checking if Math.round(x) is NaN, where x is NaN")]
        public void S15_8_2_15_A1()
        {
            RunFile("S15.8.2.15_A1.js");
        }

        [Test(Description = "Checking if Math.round(x) equals to +0, where x is +0")]
        public void S15_8_2_15_A2()
        {
            RunFile("S15.8.2.15_A2.js");
        }

        [Test(Description = "Checking if Math.round(x) equals to -0, where x is -0")]
        public void S15_8_2_15_A3()
        {
            RunFile("S15.8.2.15_A3.js");
        }

        [Test(Description = "Checking if Math.round(x) is +Infinity, where x is +Infinity")]
        public void S15_8_2_15_A4()
        {
            RunFile("S15.8.2.15_A4.js");
        }

        [Test(Description = "Checking if Math.round(x) is -Infinity, where x is -Infinity")]
        public void S15_8_2_15_A5()
        {
            RunFile("S15.8.2.15_A5.js");
        }

        [Test(Description = "Checking if Math.round(x) is equal to Math.floor(x+0.5), where x equals to 0, greater than 0, or is less than -0.5; this check is performed on 2000 argument x values")]
        public void S15_8_2_15_A6()
        {
            RunFile("S15.8.2.15_A6.js");
        }

        [Test(Description = "Checking if Math.round(x) is equal -0, where x is equal to 0, equal to -0.5, or less than -0 while greater than -0.5")]
        public void S15_8_2_15_A7()
        {
            RunFile("S15.8.2.15_A7.js");
        }
    }
}
