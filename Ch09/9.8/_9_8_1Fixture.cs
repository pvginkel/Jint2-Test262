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

namespace Jint.Test262.Ch09._9_8
{
    [TestFixture]
    public class _9_8_1Fixture : Test262Fixture
    {
        public _9_8_1Fixture()
            : base("ch09\\9.8\\9.8.1")
        {
        }

        [Test(Description = "NaN convert to String by explicit transformation")]
        public void S9_8_1_A1()
        {
            RunFile("S9.8.1_A1.js");
        }

        [Test(Description = "Various float numbers convert to String by explicit transformation")]
        public void S9_8_1_A10()
        {
            RunFile("S9.8.1_A10.js");
        }

        [Test(Description = "+0 and -0 convert to String by explicit transformation")]
        public void S9_8_1_A2()
        {
            RunFile("S9.8.1_A2.js");
        }

        [Test(Description = "-1234567890 convert to String by explicit transformation")]
        public void S9_8_1_A3()
        {
            RunFile("S9.8.1_A3.js");
        }

        [Test(Description = "+/-Infinity convert to String by explicit transformation")]
        public void S9_8_1_A4()
        {
            RunFile("S9.8.1_A4.js");
        }

        [Test(Description = "Various integer numbers convert to String by explicit transformation")]
        public void S9_8_1_A6()
        {
            RunFile("S9.8.1_A6.js");
        }

        [Test(Description = "1.0000001 and -1.0000001 convert to String by explicit transformation")]
        public void S9_8_1_A7()
        {
            RunFile("S9.8.1_A7.js");
        }

        [Test(Description = "Various float numbers convert to String by explicit transformation")]
        public void S9_8_1_A8()
        {
            RunFile("S9.8.1_A8.js");
        }

        [Test(Description = "Various big numbers convert to String by explicit transformation")]
        public void S9_8_1_A9_T1()
        {
            RunFile("S9.8.1_A9_T1.js");
        }

        [Test(Description = "Various float numbers with many zeros convert to String by explicit transformation")]
        public void S9_8_1_A9_T2()
        {
            RunFile("S9.8.1_A9_T2.js");
        }
    }
}