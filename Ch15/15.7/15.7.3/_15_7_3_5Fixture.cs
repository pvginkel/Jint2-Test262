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

namespace Jint.Test262.Ch15._15_7._15_7_3
{
    [TestFixture]
    public class _15_7_3_5Fixture : Test262Fixture
    {
        public _15_7_3_5Fixture()
            : base("ch15\\15.7\\15.7.3\\15.7.3.5")
        {
        }

        [Test(Description = "Checking sign and finiteness of Number.NEGATIVE_INFINITY")]
        public void S15_7_3_5_A1()
        {
            RunFile("S15.7.3.5_A1.js");
        }

        [Test(Description = "Checking if varying Number.NEGATIVE_INFINITY fails")]
        public void S15_7_3_5_A2()
        {
            RunFile("S15.7.3.5_A2.js");
        }

        [Test(Description = "Checking if deleting Number.NEGATIVE_INFINITY fails")]
        public void S15_7_3_5_A3()
        {
            RunFile("S15.7.3.5_A3.js");
        }

        [Test(Description = "Checking if enumerating Number.NEGATIVE_INFINITY fails")]
        public void S15_7_3_5_A4()
        {
            RunFile("S15.7.3.5_A4.js");
        }
    }
}