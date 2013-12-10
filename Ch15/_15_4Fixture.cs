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

namespace Jint.Test262.Ch15
{
    [TestFixture]
    public class _15_4Fixture : Test262Fixture
    {
        public _15_4Fixture()
            : base("ch15\\15.4")
        {
        }

        [Test(Description = "Checking for boolean primitive")]
        public void S15_4_A1_1_T1()
        {
            RunFile("S15.4_A1.1_T1.js");
        }

        [Test(Description = "Array index is power of two")]
        public void S15_4_A1_1_T10()
        {
            RunFile("S15.4_A1.1_T10.js");
        }

        [Test(Description = "Checking for number primitive")]
        public void S15_4_A1_1_T2()
        {
            RunFile("S15.4_A1.1_T2.js");
        }

        [Test(Description = "Checking for number primitive")]
        public void S15_4_A1_1_T3()
        {
            RunFile("S15.4_A1.1_T3.js");
        }

        [Test(Description = "Checking for string primitive")]
        public void S15_4_A1_1_T4()
        {
            RunFile("S15.4_A1.1_T4.js");
        }

        [Test(Description = "Checking for null and undefined")]
        public void S15_4_A1_1_T5()
        {
            RunFile("S15.4_A1.1_T5.js");
        }

        [Test(Description = "Checking for Boolean object")]
        public void S15_4_A1_1_T6()
        {
            RunFile("S15.4_A1.1_T6.js");
        }

        [Test(Description = "Checking for Number object")]
        public void S15_4_A1_1_T7()
        {
            RunFile("S15.4_A1.1_T7.js");
        }

        [Test(Description = "Checking for Number object")]
        public void S15_4_A1_1_T8()
        {
            RunFile("S15.4_A1.1_T8.js");
        }

        [Test(Description = "If Type(value) is Object, evaluate ToPrimitive(value, String)")]
        public void S15_4_A1_1_T9()
        {
            RunFile("S15.4_A1.1_T9.js");
        }
    }
}