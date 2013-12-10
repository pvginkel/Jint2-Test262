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

namespace Jint.Test262.Ch11._11_9
{
    [TestFixture]
    public class _11_9_4Fixture : Test262Fixture
    {
        public _11_9_4Fixture()
            : base("ch11\\11.9\\11.9.4")
        {
        }

        [Test(Description = "Checking by using eval")]
        public void S11_9_4_A1()
        {
            RunFile("S11.9.4_A1.js");
        }

        [Test(Description = "Either Type is not Reference or GetBase is not null")]
        public void S11_9_4_A2_1_T1()
        {
            RunFile("S11.9.4_A2.1_T1.js");
        }

        [Test(Description = "If GetBase(x) is null, throw ReferenceError")]
        public void S11_9_4_A2_1_T2()
        {
            RunFile("S11.9.4_A2.1_T2.js");
        }

        [Test(Description = "If GetBase(y) is null, throw ReferenceError")]
        public void S11_9_4_A2_1_T3()
        {
            RunFile("S11.9.4_A2.1_T3.js");
        }

        [Test(Description = "Checking with \"=\"")]
        public void S11_9_4_A2_4_T1()
        {
            RunFile("S11.9.4_A2.4_T1.js");
        }

        [Test(Description = "Checking with \"throw\"")]
        public void S11_9_4_A2_4_T2()
        {
            RunFile("S11.9.4_A2.4_T2.js");
        }

        [Test(Description = "Checking with undeclarated variables")]
        public void S11_9_4_A2_4_T3()
        {
            RunFile("S11.9.4_A2.4_T3.js");
        }

        [Test(Description = "x and y are primitive booleans")]
        public void S11_9_4_A3()
        {
            RunFile("S11.9.4_A3.js");
        }

        [Test(Description = "x is NaN")]
        public void S11_9_4_A4_1_T1()
        {
            RunFile("S11.9.4_A4.1_T1.js");
        }

        [Test(Description = "y is NaN")]
        public void S11_9_4_A4_1_T2()
        {
            RunFile("S11.9.4_A4.1_T2.js");
        }

        [Test(Description = "Checking all combinations")]
        public void S11_9_4_A4_2()
        {
            RunFile("S11.9.4_A4.2.js");
        }

        [Test(Description = "x and y are primitive numbers")]
        public void S11_9_4_A4_3()
        {
            RunFile("S11.9.4_A4.3.js");
        }

        [Test(Description = "x and y are primitive strings")]
        public void S11_9_4_A5()
        {
            RunFile("S11.9.4_A5.js");
        }

        [Test(Description = "void 0, eval(\"var x\") is undefined")]
        public void S11_9_4_A6_1()
        {
            RunFile("S11.9.4_A6.1.js");
        }

        [Test(Description = "null === null")]
        public void S11_9_4_A6_2()
        {
            RunFile("S11.9.4_A6.2.js");
        }

        [Test(Description = "Checking Boolean object, Number object, String object, Object object")]
        public void S11_9_4_A7()
        {
            RunFile("S11.9.4_A7.js");
        }

        [Test(Description = "x or y is primitive boolean")]
        public void S11_9_4_A8_T1()
        {
            RunFile("S11.9.4_A8_T1.js");
        }

        [Test(Description = "x or y is primitive number")]
        public void S11_9_4_A8_T2()
        {
            RunFile("S11.9.4_A8_T2.js");
        }

        [Test(Description = "x or y is primitive string")]
        public void S11_9_4_A8_T3()
        {
            RunFile("S11.9.4_A8_T3.js");
        }

        [Test(Description = "x or y is null or undefined")]
        public void S11_9_4_A8_T4()
        {
            RunFile("S11.9.4_A8_T4.js");
        }

        [Test(Description = "Checking with such x and y that either x or y is primitive string and the other is primitive number")]
        public void S11_9_4_A8_T5()
        {
            RunFile("S11.9.4_A8_T5.js");
        }
    }
}
