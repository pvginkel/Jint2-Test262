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

namespace Jint.Test262.Ch09
{
    [TestFixture]
    public class _9_2Fixture : Test262Fixture
    {
        public _9_2Fixture()
            : base("ch09\\9.2")
        {
        }

        [Test(Description = "Undefined, void and others are converted to Boolean by explicit transformation")]
        public void S9_2_A1_T1()
        {
            RunFile("S9.2_A1_T1.js");
        }

        [Test(Description = "Undefined, void and others are converted to Boolean by implicit transformation")]
        public void S9_2_A1_T2()
        {
            RunFile("S9.2_A1_T2.js");
        }

        [Test(Description = "null convert to Boolean by explicit transformation")]
        public void S9_2_A2_T1()
        {
            RunFile("S9.2_A2_T1.js");
        }

        [Test(Description = "null convert to Boolean by implicit transformation")]
        public void S9_2_A2_T2()
        {
            RunFile("S9.2_A2_T2.js");
        }

        [Test(Description = "true and false convert to Boolean by explicit transformation")]
        public void S9_2_A3_T1()
        {
            RunFile("S9.2_A3_T1.js");
        }

        [Test(Description = "true and false convert to Boolean by implicit transformation")]
        public void S9_2_A3_T2()
        {
            RunFile("S9.2_A3_T2.js");
        }

        [Test(Description = "+0, -0 and NaN convert to Boolean by explicit transformation")]
        public void S9_2_A4_T1()
        {
            RunFile("S9.2_A4_T1.js");
        }

        [Test(Description = "+0, -0 and NaN convert to Boolean by implicit transformation")]
        public void S9_2_A4_T2()
        {
            RunFile("S9.2_A4_T2.js");
        }

        [Test(Description = "Number.POSITIVE_INFINITY, Number.NEGATIVE_INFINITY,")]
        public void S9_2_A4_T3()
        {
            RunFile("S9.2_A4_T3.js");
        }

        [Test(Description = "Number.POSITIVE_INFINITY, Number.NEGATIVE_INFINITY,")]
        public void S9_2_A4_T4()
        {
            RunFile("S9.2_A4_T4.js");
        }

        [Test(Description = "\"\" is converted to Boolean by explicit transformation")]
        public void S9_2_A5_T1()
        {
            RunFile("S9.2_A5_T1.js");
        }

        [Test(Description = "\"\" convert to Boolean by implicit transformation")]
        public void S9_2_A5_T2()
        {
            RunFile("S9.2_A5_T2.js");
        }

        [Test(Description = "Any nonempty string convert to Boolean by explicit transformation")]
        public void S9_2_A5_T3()
        {
            RunFile("S9.2_A5_T3.js");
        }

        [Test(Description = "Any nonempty string convert to Boolean by implicit transformation")]
        public void S9_2_A5_T4()
        {
            RunFile("S9.2_A5_T4.js");
        }

        [Test(Description = "Different objects convert to Boolean by explicit transformation")]
        public void S9_2_A6_T1()
        {
            RunFile("S9.2_A6_T1.js");
        }

        [Test(Description = "Different objects convert to Boolean by implicit transformation")]
        public void S9_2_A6_T2()
        {
            RunFile("S9.2_A6_T2.js");
        }
    }
}
