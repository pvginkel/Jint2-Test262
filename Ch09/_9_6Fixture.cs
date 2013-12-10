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
    public class _9_6Fixture : Test262Fixture
    {
        public _9_6Fixture()
            : base("ch09\\9.6")
        {
        }

        [Test(Description = "For testing use operator >>>0")]
        public void S9_6_A1()
        {
            RunFile("S9.6_A1.js");
        }

        [Test(Description = "Converting numbers, which are in\\outside of Uint32 scopes, with >>>0 operator")]
        public void S9_6_A2_1()
        {
            RunFile("S9.6_A2.1.js");
        }

        [Test(Description = "Use operator >>>0")]
        public void S9_6_A2_2()
        {
            RunFile("S9.6_A2.2.js");
        }

        [Test(Description = "Type(x) is Boolean")]
        public void S9_6_A3_1_T1()
        {
            RunFile("S9.6_A3.1_T1.js");
        }

        [Test(Description = "Type(x) is Number")]
        public void S9_6_A3_1_T2()
        {
            RunFile("S9.6_A3.1_T2.js");
        }

        [Test(Description = "Type(x) is String")]
        public void S9_6_A3_1_T3()
        {
            RunFile("S9.6_A3.1_T3.js");
        }

        [Test(Description = "Type(x) is Object")]
        public void S9_6_A3_1_T4()
        {
            RunFile("S9.6_A3.1_T4.js");
        }

        [Test(Description = "Use operator >>>0")]
        public void S9_6_A3_2_T1()
        {
            RunFile("S9.6_A3.2_T1.js");
        }
    }
}
