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

namespace Jint.Test262.Ch07
{
    [TestFixture]
    public class _7_7Fixture : Test262Fixture
    {
        public _7_7Fixture()
            : base("ch07\\7.7")
        {
        }

        [Test(Description = "Using all punctuators")]
        public void S7_7_A1()
        {
            RunFile("S7.7_A1.js");
        }

        [Test(Description = "Try to use {} as a Unicode \\u007B\\u007D")]
        [ExpectedException]
        public void S7_7_A2_T1()
        {
            RunFile("S7.7_A2_T1.js");
        }

        [Test(Description = "Try to use / as a Unicode \\u002F")]
        [ExpectedException]
        public void S7_7_A2_T10()
        {
            RunFile("S7.7_A2_T10.js");
        }

        [Test(Description = "Try to use () as Unicode \\u00281\\u0029")]
        [ExpectedException]
        public void S7_7_A2_T2()
        {
            RunFile("S7.7_A2_T2.js");
        }

        [Test(Description = "Try to use [] as a Unicode \\u005B\\u005D")]
        [ExpectedException]
        public void S7_7_A2_T3()
        {
            RunFile("S7.7_A2_T3.js");
        }

        [Test(Description = "Try to use ; as a Unicode \\u003B")]
        [ExpectedException]
        public void S7_7_A2_T4()
        {
            RunFile("S7.7_A2_T4.js");
        }

        [Test(Description = "Try to use . as a Unicode \\u002E")]
        [ExpectedException]
        public void S7_7_A2_T5()
        {
            RunFile("S7.7_A2_T5.js");
        }

        [Test(Description = "Try to use , as a Unicode \\u002C")]
        [ExpectedException]
        public void S7_7_A2_T6()
        {
            RunFile("S7.7_A2_T6.js");
        }

        [Test(Description = "Try to use + as a Unicode \\u002B")]
        [ExpectedException]
        public void S7_7_A2_T7()
        {
            RunFile("S7.7_A2_T7.js");
        }

        [Test(Description = "Try to use -  as a Unicode \\u002D")]
        [ExpectedException]
        public void S7_7_A2_T8()
        {
            RunFile("S7.7_A2_T8.js");
        }

        [Test(Description = "Try to use * as a Unicode \\u002A")]
        [ExpectedException]
        public void S7_7_A2_T9()
        {
            RunFile("S7.7_A2_T9.js");
        }
    }
}
