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

namespace Jint.Test262.Ch15._15_1._15_1_2
{
    [TestFixture]
    public class _15_1_2_4Fixture : Test262Fixture
    {
        public _15_1_2_4Fixture()
            : base("ch15\\15.1\\15.1.2\\15.1.2.4")
        {
        }

        [Test(Description = "Checking all primitive")]
        public void S15_1_2_4_A1_T1()
        {
            RunFile("S15.1.2.4_A1_T1.js");
        }

        [Test(Description = "Checking all object")]
        public void S15_1_2_4_A1_T2()
        {
            RunFile("S15.1.2.4_A1_T2.js");
        }

        [Test(Description = "Checking use propertyIsEnumerable, for-in")]
        public void S15_1_2_4_A2_1()
        {
            RunFile("S15.1.2.4_A2.1.js");
        }

        [Test(Description = "Checking use hasOwnProperty, delete")]
        public void S15_1_2_4_A2_2()
        {
            RunFile("S15.1.2.4_A2.2.js");
        }

        [Test(Description = "Checking if varying the length property fails")]
        public void S15_1_2_4_A2_3()
        {
            RunFile("S15.1.2.4_A2.3.js");
        }

        [Test(Description = "isNaN.length === 1")]
        public void S15_1_2_4_A2_4()
        {
            RunFile("S15.1.2.4_A2.4.js");
        }

        [Test(Description = "Checking use propertyIsEnumerable, for-in")]
        public void S15_1_2_4_A2_5()
        {
            RunFile("S15.1.2.4_A2.5.js");
        }

        [Test(Description = "Checking isNaN.prototype")]
        public void S15_1_2_4_A2_6()
        {
            RunFile("S15.1.2.4_A2.6.js");
        }

        [Test(Description = "If property does not implement the internal [[Construct]] method, throw a TypeError exception")]
        public void S15_1_2_4_A2_7()
        {
            RunFile("S15.1.2.4_A2.7.js");
        }
    }
}
