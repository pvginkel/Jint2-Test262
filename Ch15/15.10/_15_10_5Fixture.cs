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

namespace Jint.Test262.Ch15._15_10
{
    [TestFixture]
    public class _15_10_5Fixture : Test262Fixture
    {
        public _15_10_5Fixture()
            : base("ch15\\15.10\\15.10.5")
        {
        }

        [Test(Description = "Checking RegExp.prototype property")]
        public void S15_10_5_1_A1()
        {
            RunFile("S15.10.5.1_A1.js");
        }

        [Test(Description = "Checking if enumerating the RegExp.prototype property fails")]
        public void S15_10_5_1_A2()
        {
            RunFile("S15.10.5.1_A2.js");
        }

        [Test(Description = "Checking if deleting the RegExp.prototype property fails")]
        public void S15_10_5_1_A3()
        {
            RunFile("S15.10.5.1_A3.js");
        }

        [Test(Description = "Checking if varying the RegExp.prototype property fails")]
        public void S15_10_5_1_A4()
        {
            RunFile("S15.10.5.1_A4.js");
        }

        [Test(Description = "Checking RegExp.length property")]
        public void S15_10_5_A1()
        {
            RunFile("S15.10.5_A1.js");
        }

        [Test(Description = "Checking Function.prototype.isPrototypeOf(RegExp)")]
        public void S15_10_5_A2_T1()
        {
            RunFile("S15.10.5_A2_T1.js");
        }

        [Test(Description = "Add new property to Function.prototype and then check this property of RegExp")]
        public void S15_10_5_A2_T2()
        {
            RunFile("S15.10.5_A2_T2.js");
        }
    }
}
