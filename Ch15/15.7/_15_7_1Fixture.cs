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

namespace Jint.Test262.Ch15._15_7
{
    [TestFixture]
    public class _15_7_1Fixture : Test262Fixture
    {
        public _15_7_1Fixture()
            : base("ch15\\15.7\\15.7.1")
        {
        }

        [Test(Description = "Used values \"10\", 10, new String(\"10\"), new Object(10) and \"abc\"")]
        public void S15_7_1_1_A1()
        {
            RunFile("S15.7.1.1_A1.js");
        }

        [Test(Description = "Call Number() and check result")]
        public void S15_7_1_1_A2()
        {
            RunFile("S15.7.1.1_A2.js");
        }
    }
}
