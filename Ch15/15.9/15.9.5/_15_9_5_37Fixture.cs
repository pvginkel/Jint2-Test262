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

namespace Jint.Test262.Ch15._15_9._15_9_5
{
    [TestFixture]
    public class _15_9_5_37Fixture : Test262Fixture
    {
        public _15_9_5_37Fixture()
            : base("ch15\\15.9\\15.9.5\\15.9.5.37")
        {
        }

        [Test(Description = "Checking absence of ReadOnly attribute")]
        public void S15_9_5_37_A1_T1()
        {
            RunFile("S15.9.5.37_A1_T1.js");
        }

        [Test(Description = "Checking absence of DontDelete attribute")]
        public void S15_9_5_37_A1_T2()
        {
            RunFile("S15.9.5.37_A1_T2.js");
        }

        [Test(Description = "Checking DontEnum attribute")]
        public void S15_9_5_37_A1_T3()
        {
            RunFile("S15.9.5.37_A1_T3.js");
        }

        [Test(Description = "The \"length\" property of the \"setUTCDate\" is 1")]
        public void S15_9_5_37_A2_T1()
        {
            RunFile("S15.9.5.37_A2_T1.js");
        }

        [Test(Description = "Checking ReadOnly attribute")]
        public void S15_9_5_37_A3_T1()
        {
            RunFile("S15.9.5.37_A3_T1.js");
        }

        [Test(Description = "Checking DontDelete attribute")]
        public void S15_9_5_37_A3_T2()
        {
            RunFile("S15.9.5.37_A3_T2.js");
        }

        [Test(Description = "Checking DontEnum attribute")]
        public void S15_9_5_37_A3_T3()
        {
            RunFile("S15.9.5.37_A3_T3.js");
        }
    }
}
