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
    public class _15_8_2_18Fixture : Test262Fixture
    {
        public _15_8_2_18Fixture()
            : base("ch15\\15.8\\15.8.2\\15.8.2.18")
        {
        }

        [Test(Description = "Checking if Math.tan(NaN) is NaN")]
        public void S15_8_2_18_A1()
        {
            RunFile("S15.8.2.18_A1.js");
        }

        [Test(Description = "Checking if Math.tan(+0) equals to +0")]
        public void S15_8_2_18_A2()
        {
            RunFile("S15.8.2.18_A2.js");
        }

        [Test(Description = "Checking if Math.tan(-0) equals to -0")]
        public void S15_8_2_18_A3()
        {
            RunFile("S15.8.2.18_A3.js");
        }

        [Test(Description = "Checking if Math.tan(+Infinity) is NaN")]
        public void S15_8_2_18_A4()
        {
            RunFile("S15.8.2.18_A4.js");
        }

        [Test(Description = "Checking if Math.tan(-Infinity) is NaN")]
        public void S15_8_2_18_A5()
        {
            RunFile("S15.8.2.18_A5.js");
        }

        [Test(Description = "Checking if Math.tan(x) equals to Math.tan(x+n*Math.PI) with precision 0.000000000003, where n is an integer from 1 to 100 and x is one of 10 float point values from 0 to Math.PI")]
        public void S15_8_2_18_A6()
        {
            RunFile("S15.8.2.18_A6.js");
        }

        [Test(Description = "Checking if Math.tan is approximately equals to its mathematical values on the set of 64 argument values; all the sample values is calculated with LibC")]
        public void S15_8_2_18_A7()
        {
            RunFile("S15.8.2.18_A7.js");
        }
    }
}
