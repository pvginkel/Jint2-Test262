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

namespace Jint.Test262.Ch15._15_10._15_10_2
{
    [TestFixture]
    public class _15_10_2_10Fixture : Test262Fixture
    {
        public _15_10_2_10Fixture()
            : base("ch15\\15.10\\15.10.2\\15.10.2.10")
        {
        }

        [Test(Description = "Use \\t in RegExp and \\u0009 in tested string")]
        public void S15_10_2_10_A1_1_T1()
        {
            RunFile("S15.10.2.10_A1.1_T1.js");
        }

        [Test(Description = "Use \\n in RegExp and \\u000A in tested string")]
        public void S15_10_2_10_A1_2_T1()
        {
            RunFile("S15.10.2.10_A1.2_T1.js");
        }

        [Test(Description = "Use \\v in RegExp and \\u000B in tested string")]
        public void S15_10_2_10_A1_3_T1()
        {
            RunFile("S15.10.2.10_A1.3_T1.js");
        }

        [Test(Description = "Use \\f in RegExp and \\u000C in tested string")]
        public void S15_10_2_10_A1_4_T1()
        {
            RunFile("S15.10.2.10_A1.4_T1.js");
        }

        [Test(Description = "Use \\r in RegExp and \\u000D in tested string")]
        public void S15_10_2_10_A1_5_T1()
        {
            RunFile("S15.10.2.10_A1.5_T1.js");
        }

        [Test(Description = "ControlLetter :: A - Z")]
        public void S15_10_2_10_A2_1_T1()
        {
            RunFile("S15.10.2.10_A2.1_T1.js");
        }

        [Test(Description = "ControlLetter :: a - z")]
        public void S15_10_2_10_A2_1_T2()
        {
            RunFile("S15.10.2.10_A2.1_T2.js");
        }

        [Test(Description = "ControlLetter :: RUSSIAN ALPHABET is incorrect")]
        public void S15_10_2_10_A2_1_T3()
        {
            RunFile("S15.10.2.10_A2.1_T3.js");
        }

        [Test(Description = "Tested string include equal unicode symbols")]
        public void S15_10_2_10_A3_1_T1()
        {
            RunFile("S15.10.2.10_A3.1_T1.js");
        }

        [Test(Description = "Checking ENGLISH CAPITAL ALPHABET and english small alphabet")]
        public void S15_10_2_10_A3_1_T2()
        {
            RunFile("S15.10.2.10_A3.1_T2.js");
        }

        [Test(Description = "RegExp and tested string include uncode symbols")]
        public void S15_10_2_10_A4_1_T1()
        {
            RunFile("S15.10.2.10_A4.1_T1.js");
        }

        [Test(Description = "Tested string include ENGLISH CAPITAL ALPHABET and english small alphabet")]
        public void S15_10_2_10_A4_1_T2()
        {
            RunFile("S15.10.2.10_A4.1_T2.js");
        }

        [Test(Description = "Tested string include RUSSIAN CAPITAL ALPHABET and russian small alphabet in unicode notation")]
        public void S15_10_2_10_A4_1_T3()
        {
            RunFile("S15.10.2.10_A4.1_T3.js");
        }

        [Test(Description = "Tested string is \"~`!@#$%^&*()-+={[}]|\\\\:;'<,>./?\" + '\"'")]
        public void S15_10_2_10_A5_1_T1()
        {
            RunFile("S15.10.2.10_A5.1_T1.js");
        }
    }
}
