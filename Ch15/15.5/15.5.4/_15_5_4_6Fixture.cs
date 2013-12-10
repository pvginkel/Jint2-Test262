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

namespace Jint.Test262.Ch15._15_5._15_5_4
{
    [TestFixture]
    public class _15_5_4_6Fixture : Test262Fixture
    {
        public _15_5_4_6Fixture()
            : base("ch15\\15.5\\15.5.4\\15.5.4.6")
        {
        }

        [Test(Description = "Checking if varying the String.prototype.concat.length property fails")]
        public void S15_5_4_6_A10()
        {
            RunFile("S15.5.4.6_A10.js");
        }

        [Test(Description = "Checking String.prototype.concat.length")]
        public void S15_5_4_6_A11()
        {
            RunFile("S15.5.4.6_A11.js");
        }

        [Test(Description = "Arguments are false and true, and instance is object")]
        public void S15_5_4_6_A1_T1()
        {
            RunFile("S15.5.4.6_A1_T1.js");
        }

        [Test(Description = "Call concat([,[...]]) function with object arguments")]
        public void S15_5_4_6_A1_T10()
        {
            RunFile("S15.5.4.6_A1_T10.js");
        }

        [Test(Description = "Arguments are equation with false and true, and instance is Boolean object")]
        public void S15_5_4_6_A1_T2()
        {
            RunFile("S15.5.4.6_A1_T2.js");
        }

        [Test(Description = "Call concat([,[...]]) function without argument of string object")]
        public void S15_5_4_6_A1_T4()
        {
            RunFile("S15.5.4.6_A1_T4.js");
        }

        [Test(Description = "Call concat([,[...]]) function with null argument of function object")]
        public void S15_5_4_6_A1_T5()
        {
            RunFile("S15.5.4.6_A1_T5.js");
        }

        [Test(Description = "Call concat([,[...]]) function with x argument of new String object, where x is undefined variable")]
        public void S15_5_4_6_A1_T6()
        {
            RunFile("S15.5.4.6_A1_T6.js");
        }

        [Test(Description = "Call concat([,[...]]) function with undefined argument of string object")]
        public void S15_5_4_6_A1_T7()
        {
            RunFile("S15.5.4.6_A1_T7.js");
        }

        [Test(Description = "Call concat([,[...]]) function with void 0 argument of string object")]
        public void S15_5_4_6_A1_T8()
        {
            RunFile("S15.5.4.6_A1_T8.js");
        }

        [Test(Description = "Call concat([,[...]]) function with function(){}() argument of string object")]
        public void S15_5_4_6_A1_T9()
        {
            RunFile("S15.5.4.6_A1_T9.js");
        }

        [Test(Description = "Call concat([,[...]]) function with 128 arguments")]
        public void S15_5_4_6_A2()
        {
            RunFile("S15.5.4.6_A2.js");
        }

        [Test(Description = "Checking if varying the instance that is applied fails")]
        public void S15_5_4_6_A3()
        {
            RunFile("S15.5.4.6_A3.js");
        }

        [Test(Description = "Override toString function")]
        public void S15_5_4_6_A4_T1()
        {
            RunFile("S15.5.4.6_A4_T1.js");
        }

        [Test(Description = "Override toString function onto function, that throw exception")]
        public void S15_5_4_6_A4_T2()
        {
            RunFile("S15.5.4.6_A4_T2.js");
        }

        [Test(Description = "Checking String.prototype.concat.prototype")]
        public void S15_5_4_6_A6()
        {
            RunFile("S15.5.4.6_A6.js");
        }

        [Test(Description = "Checking if creating the String.prototype.concat object fails")]
        public void S15_5_4_6_A7()
        {
            RunFile("S15.5.4.6_A7.js");
        }

        [Test(Description = "Checking if enumerating the String.prototype.concat.length property fails")]
        public void S15_5_4_6_A8()
        {
            RunFile("S15.5.4.6_A8.js");
        }

        [Test(Description = "Checking if deleting the String.prototype.concat.length property fails")]
        public void S15_5_4_6_A9()
        {
            RunFile("S15.5.4.6_A9.js");
        }
    }
}
