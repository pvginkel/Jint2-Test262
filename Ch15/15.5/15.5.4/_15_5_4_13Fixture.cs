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
    public class _15_5_4_13Fixture : Test262Fixture
    {
        public _15_5_4_13Fixture()
            : base("ch15\\15.5\\15.5.4\\15.5.4.13")
        {
        }

        [Test(Description = "Checking if varying the String.prototype.slice.length property fails")]
        public void S15_5_4_13_A10()
        {
            RunFile("S15.5.4.13_A10.js");
        }

        [Test(Description = "Checking String.prototype.slice.length")]
        public void S15_5_4_13_A11()
        {
            RunFile("S15.5.4.13_A11.js");
        }

        [Test(Description = "Arguments are false and true, and instance is object")]
        public void S15_5_4_13_A1_T1()
        {
            RunFile("S15.5.4.13_A1_T1.js");
        }

        [Test(Description = "Arguments are object and function call, and instance is String, object have overrided valueOf function")]
        public void S15_5_4_13_A1_T10()
        {
            RunFile("S15.5.4.13_A1_T10.js");
        }

        [Test(Description = "Arguments are objects, and instance is string, objects have overrided valueOf function, that return exception")]
        public void S15_5_4_13_A1_T11()
        {
            RunFile("S15.5.4.13_A1_T11.js");
        }

        [Test(Description = "Arguments are objects, and instance is string.")]
        public void S15_5_4_13_A1_T12()
        {
            RunFile("S15.5.4.13_A1_T12.js");
        }

        [Test(Description = "Arguments are objects, and instance is string.")]
        public void S15_5_4_13_A1_T13()
        {
            RunFile("S15.5.4.13_A1_T13.js");
        }

        [Test(Description = "Used one argument, that is function(){}(). Instance is string")]
        public void S15_5_4_13_A1_T14()
        {
            RunFile("S15.5.4.13_A1_T14.js");
        }

        [Test(Description = "Call slice without arguments. Instance is Number with prototype.slice = String.prototype.slice")]
        public void S15_5_4_13_A1_T15()
        {
            RunFile("S15.5.4.13_A1_T15.js");
        }

        [Test(Description = "Arguments are function call and x, and instance is Boolean. x is undefined variable")]
        public void S15_5_4_13_A1_T2()
        {
            RunFile("S15.5.4.13_A1_T2.js");
        }

        [Test(Description = "Arguments are null and number, and instance is function call, that returned string")]
        public void S15_5_4_13_A1_T4()
        {
            RunFile("S15.5.4.13_A1_T4.js");
        }

        [Test(Description = "Arguments are null and call other slice(start, end), and instance is function object, that have overrided valueOf and toString functions")]
        public void S15_5_4_13_A1_T5()
        {
            RunFile("S15.5.4.13_A1_T5.js");
        }

        [Test(Description = "Arguments are x and number, and instance is new String, x is undefined variable")]
        public void S15_5_4_13_A1_T6()
        {
            RunFile("S15.5.4.13_A1_T6.js");
        }

        [Test(Description = "Arguments are symbol and undefined, and instance is String")]
        public void S15_5_4_13_A1_T7()
        {
            RunFile("S15.5.4.13_A1_T7.js");
        }

        [Test(Description = "Arguments are negative number and void 0, and instance is String(object), object have overrided toString function")]
        public void S15_5_4_13_A1_T8()
        {
            RunFile("S15.5.4.13_A1_T8.js");
        }

        [Test(Description = "Arguments are undefined and object, and instance is String(object), object have overrided valueOf and toString functions")]
        public void S15_5_4_13_A1_T9()
        {
            RunFile("S15.5.4.13_A1_T9.js");
        }

        [Test(Description = "Checking type of slice()")]
        public void S15_5_4_13_A2_T1()
        {
            RunFile("S15.5.4.13_A2_T1.js");
        }

        [Test(Description = "start is NaN, end is Infinity")]
        public void S15_5_4_13_A2_T2()
        {
            RunFile("S15.5.4.13_A2_T2.js");
        }

        [Test(Description = "Call slice from empty String object")]
        public void S15_5_4_13_A2_T3()
        {
            RunFile("S15.5.4.13_A2_T3.js");
        }

        [Test(Description = "start is Infinity, end is NaN")]
        public void S15_5_4_13_A2_T4()
        {
            RunFile("S15.5.4.13_A2_T4.js");
        }

        [Test(Description = "start is Infinity, end is Infinity")]
        public void S15_5_4_13_A2_T5()
        {
            RunFile("S15.5.4.13_A2_T5.js");
        }

        [Test(Description = "start is negative float number, end is 0")]
        public void S15_5_4_13_A2_T6()
        {
            RunFile("S15.5.4.13_A2_T6.js");
        }

        [Test(Description = "start is tested_string.length, end is tested_string.length")]
        public void S15_5_4_13_A2_T7()
        {
            RunFile("S15.5.4.13_A2_T7.js");
        }

        [Test(Description = "start is tested_string.length+1, end is 0")]
        public void S15_5_4_13_A2_T8()
        {
            RunFile("S15.5.4.13_A2_T8.js");
        }

        [Test(Description = "start is -Infinity, end is -Infinity")]
        public void S15_5_4_13_A2_T9()
        {
            RunFile("S15.5.4.13_A2_T9.js");
        }

        [Test(Description = "Apply String.prototype.slice to Object instance")]
        public void S15_5_4_13_A3_T1()
        {
            RunFile("S15.5.4.13_A3_T1.js");
        }

        [Test(Description = "Apply String.prototype.slice to Object instance, use other value for start and end values")]
        public void S15_5_4_13_A3_T2()
        {
            RunFile("S15.5.4.13_A3_T2.js");
        }

        [Test(Description = "Apply String.prototype.slice to Object instance, and call instance.slice(...).slice(...)")]
        public void S15_5_4_13_A3_T3()
        {
            RunFile("S15.5.4.13_A3_T3.js");
        }

        [Test(Description = "Checknig if applying String.prototype.slice to Function object instance passes")]
        public void S15_5_4_13_A3_T4()
        {
            RunFile("S15.5.4.13_A3_T4.js");
        }

        [Test(Description = "Checking String.prototype.slice.prototype")]
        public void S15_5_4_13_A6()
        {
            RunFile("S15.5.4.13_A6.js");
        }

        [Test(Description = "Checking if creating the String.prototype.slice object fails")]
        public void S15_5_4_13_A7()
        {
            RunFile("S15.5.4.13_A7.js");
        }

        [Test(Description = "Checking if enumerating the String.prototype.slice.length property fails")]
        public void S15_5_4_13_A8()
        {
            RunFile("S15.5.4.13_A8.js");
        }

        [Test(Description = "Checking if deleting the String.prototype.slice.length property fails")]
        public void S15_5_4_13_A9()
        {
            RunFile("S15.5.4.13_A9.js");
        }
    }
}