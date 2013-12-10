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
    public class _15_8_2_11Fixture : Test262Fixture
    {
        public _15_8_2_11Fixture()
            : base("ch15\\15.8\\15.8.2\\15.8.2.11")
        {
        }

        [Test(Description = "Math.max({}) is NaN")]
        public void _15_8_2_11_1()
        {
            RunFile("15.8.2.11-1.js");
        }

        [Test(Description = "Checking if Math.max() equals to -Infinity")]
        public void S15_8_2_11_A1()
        {
            RunFile("S15.8.2.11_A1.js");
        }

        [Test(Description = "The script tests Math.max giving 1, 2 and 3 arguments to the function where at least one of the arguments is NaN")]
        public void S15_8_2_11_A2()
        {
            RunFile("S15.8.2.11_A2.js");
        }

        [Test(Description = "Checking if Math.max(-0,+0) and Math.max(+0,-0) equals to +0")]
        public void S15_8_2_11_A3()
        {
            RunFile("S15.8.2.11_A3.js");
        }

        [Test(Description = "Checking if Math.max.length property is defined and equals to 2")]
        public void S15_8_2_11_A4()
        {
            RunFile("S15.8.2.11_A4.js");
        }
    }
}
