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

namespace Jint.Test262.Ch15._15_6
{
    [TestFixture]
    public class _15_6_1Fixture : Test262Fixture
    {
        public _15_6_1Fixture()
            : base("ch15\\15.6\\15.6.1")
        {
        }

        [Test(Description = "Used values 1, new String(\"1\"), new Object(1) and called without argument")]
        public void S15_6_1_1_A1_T1()
        {
            RunFile("S15.6.1.1_A1_T1.js");
        }

        [Test(Description = "Used various number values as argument")]
        public void S15_6_1_1_A1_T2()
        {
            RunFile("S15.6.1.1_A1_T2.js");
        }

        [Test(Description = "Used various string values as argument")]
        public void S15_6_1_1_A1_T3()
        {
            RunFile("S15.6.1.1_A1_T3.js");
        }

        [Test(Description = "Used various undefined values and null as argument")]
        public void S15_6_1_1_A1_T4()
        {
            RunFile("S15.6.1.1_A1_T4.js");
        }

        [Test(Description = "Used various assigning values to any variable as argument")]
        public void S15_6_1_1_A1_T5()
        {
            RunFile("S15.6.1.1_A1_T5.js");
        }

        [Test(Description = "Call Boolean() and check result")]
        public void S15_6_1_1_A2()
        {
            RunFile("S15.6.1.1_A2.js");
        }
    }
}
