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
    public class _15_10_7Fixture : Test262Fixture
    {
        public _15_10_7Fixture()
            : base("ch15\\15.10\\15.10.7")
        {
        }

        [Test(Description = "Checking if call of RegExp instance fails")]
        public void S15_10_7_A1_T1()
        {
            RunFile("S15.10.7_A1_T1.js");
        }

        [Test(Description = "Checking if call of RegExp(\"a|b\",\"g\")() fails")]
        public void S15_10_7_A1_T2()
        {
            RunFile("S15.10.7_A1_T2.js");
        }

        [Test(Description = "Checking if creating new RegExp instance fails")]
        public void S15_10_7_A2_T1()
        {
            RunFile("S15.10.7_A2_T1.js");
        }

        [Test(Description = "Checking if creating \"new RegExp\" instance fails")]
        public void S15_10_7_A2_T2()
        {
            RunFile("S15.10.7_A2_T2.js");
        }

        [Test(Description = "Checking type of RegExp instance with operators typeof, instanceof and check it constructor.")]
        public void S15_10_7_A3_T1()
        {
            RunFile("S15.10.7_A3_T1.js");
        }

        [Test(Description = "Checking type of RegExp instance with operators typeof, instanceof and check it constructor.")]
        public void S15_10_7_A3_T2()
        {
            RunFile("S15.10.7_A3_T2.js");
        }
    }
}
