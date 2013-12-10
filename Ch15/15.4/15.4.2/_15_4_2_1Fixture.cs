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

namespace Jint.Test262.Ch15._15_4._15_4_2
{
    [TestFixture]
    public class _15_4_2_1Fixture : Test262Fixture
    {
        public _15_4_2_1Fixture()
            : base("ch15\\15.4\\15.4.2\\15.4.2.1")
        {
        }

        [Test(Description = "Create new property of Array.prototype. When new Array object has this property")]
        public void S15_4_2_1_A1_1_T1()
        {
            RunFile("S15.4.2.1_A1.1_T1.js");
        }

        [Test(Description = "Array.prototype.toString = Object.prototype.toString")]
        public void S15_4_2_1_A1_1_T2()
        {
            RunFile("S15.4.2.1_A1.1_T2.js");
        }

        [Test(Description = "Checking use isPrototypeOf")]
        public void S15_4_2_1_A1_1_T3()
        {
            RunFile("S15.4.2.1_A1.1_T3.js");
        }

        [Test(Description = "Checking use Object.prototype.toString")]
        public void S15_4_2_1_A1_2_T1()
        {
            RunFile("S15.4.2.1_A1.2_T1.js");
        }

        [Test(Description = "Checking case when Array constructor is given one argument")]
        public void S15_4_2_1_A1_3_T1()
        {
            RunFile("S15.4.2.1_A1.3_T1.js");
        }

        [Test(Description = "Array constructor is given no arguments or at least two arguments")]
        public void S15_4_2_1_A2_1_T1()
        {
            RunFile("S15.4.2.1_A2.1_T1.js");
        }

        [Test(Description = "Checking correct work this algorithm")]
        public void S15_4_2_1_A2_2_T1()
        {
            RunFile("S15.4.2.1_A2.2_T1.js");
        }
    }
}