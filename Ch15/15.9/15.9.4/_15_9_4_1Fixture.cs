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

namespace Jint.Test262.Ch15._15_9._15_9_4
{
    [TestFixture]
    public class _15_9_4_1Fixture : Test262Fixture
    {
        public _15_9_4_1Fixture()
            : base("ch15\\15.9\\15.9.4\\15.9.4.1")
        {
        }

        [Test(Description = "Checking ReadOnly attribute")]
        public void S15_9_4_1_A1_T1()
        {
            RunFile("S15.9.4.1_A1_T1.js");
        }

        [Test(Description = "Checking DontDelete attribute")]
        public void S15_9_4_1_A1_T2()
        {
            RunFile("S15.9.4.1_A1_T2.js");
        }

        [Test(Description = "Checking DontEnum attribute")]
        public void S15_9_4_1_A1_T3()
        {
            RunFile("S15.9.4.1_A1_T3.js");
        }
    }
}
