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
    public class _15_7_3_4Fixture : Test262Fixture
    {
        public _15_7_3_4Fixture()
            : base("ch15\\15.7\\15.7.3\\15.7.3.4")
        {
        }

        [Test(Description = "Checking isNaN(Number.NaN)")]
        public void S15_7_3_4_A1()
        {
            RunFile("S15.7.3.4_A1.js");
        }

        [Test(Description = "Checking if varying Number.NaN fails")]
        public void S15_7_3_4_A2()
        {
            RunFile("S15.7.3.4_A2.js");
        }

        [Test(Description = "Checking if deleting Number.NaN fails")]
        public void S15_7_3_4_A3()
        {
            RunFile("S15.7.3.4_A3.js");
        }

        [Test(Description = "Checking if enumerating Number.NaN fails")]
        public void S15_7_3_4_A4()
        {
            RunFile("S15.7.3.4_A4.js");
        }
    }
}
