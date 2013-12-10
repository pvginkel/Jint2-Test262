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

namespace Jint.Test262.Ch15._15_2._15_2_3
{
    [TestFixture]
    public class _15_2_3_2Fixture : Test262Fixture
    {
        public _15_2_3_2Fixture()
            : base("ch15\\15.2\\15.2.3\\15.2.3.2")
        {
        }

        [Test(Description = "Object.getPrototypeOf must exist as a function")]
        public void _15_2_3_2_0_1()
        {
            RunFile("15.2.3.2-0-1.js");
        }

        [Test(Description = "Object.getPrototypeOf must exist as a function taking 1 parameter")]
        public void _15_2_3_2_0_2()
        {
            RunFile("15.2.3.2-0-2.js");
        }

        [Test(Description = "Object.getPrototypeOf must take 1 parameter")]
        public void _15_2_3_2_0_3()
        {
            RunFile("15.2.3.2-0-3.js");
        }

        [Test(Description = "Object.getPrototypeOf throws TypeError if 'O' is null")]
        public void _15_2_3_2_1_2()
        {
            RunFile("15.2.3.2-1-2.js");
        }

        [Test(Description = "Object.getPrototypeOf throws TypeError if 'O' is a boolean")]
        public void _15_2_3_2_1_3()
        {
            RunFile("15.2.3.2-1-3.js");
        }

        [Test(Description = "Object.getPrototypeOf throws TypeError if 'O' is a string")]
        public void _15_2_3_2_1_4()
        {
            RunFile("15.2.3.2-1-4.js");
        }

        [Test(Description = "Object.getPrototypeOf throws TypeError if type of first param is not Object")]
        public void _15_2_3_2_1()
        {
            RunFile("15.2.3.2-1.js");
        }

        [Test(Description = "Object.getPrototypeOf returns the [[Prototype]] of its parameter (Boolean)")]
        public void _15_2_3_2_2_1()
        {
            RunFile("15.2.3.2-2-1.js");
        }

        [Test(Description = "Object.getPrototypeOf returns the [[Prototype]] of its parameter (RegExp)")]
        public void _15_2_3_2_2_10()
        {
            RunFile("15.2.3.2-2-10.js");
        }

        [Test(Description = "Object.getPrototypeOf returns the [[Prototype]] of its parameter (Error)")]
        public void _15_2_3_2_2_11()
        {
            RunFile("15.2.3.2-2-11.js");
        }

        [Test(Description = "Object.getPrototypeOf returns the [[Prototype]] of its parameter (EvalError)")]
        public void _15_2_3_2_2_12()
        {
            RunFile("15.2.3.2-2-12.js");
        }

        [Test(Description = "Object.getPrototypeOf returns the [[Prototype]] of its parameter (RangeError)")]
        public void _15_2_3_2_2_13()
        {
            RunFile("15.2.3.2-2-13.js");
        }

        [Test(Description = "Object.getPrototypeOf returns the [[Prototype]] of its parameter (ReferenceError)")]
        public void _15_2_3_2_2_14()
        {
            RunFile("15.2.3.2-2-14.js");
        }

        [Test(Description = "Object.getPrototypeOf returns the [[Prototype]] of its parameter (SyntaxError)")]
        public void _15_2_3_2_2_15()
        {
            RunFile("15.2.3.2-2-15.js");
        }

        [Test(Description = "Object.getPrototypeOf returns the [[Prototype]] of its parameter (TypeError)")]
        public void _15_2_3_2_2_16()
        {
            RunFile("15.2.3.2-2-16.js");
        }

        [Test(Description = "Object.getPrototypeOf returns the [[Prototype]] of its parameter (URIError)")]
        public void _15_2_3_2_2_17()
        {
            RunFile("15.2.3.2-2-17.js");
        }

        [Test(Description = "Object.getPrototypeOf returns the [[Prototype]] of its parameter (JSON)")]
        public void _15_2_3_2_2_18()
        {
            RunFile("15.2.3.2-2-18.js");
        }

        [Test(Description = "Object.getPrototypeOf returns the [[Prototype]] of its parameter (Object object)")]
        public void _15_2_3_2_2_19()
        {
            RunFile("15.2.3.2-2-19.js");
        }

        [Test(Description = "Object.getPrototypeOf returns the [[Prototype]] of its parameter (custom object)")]
        public void _15_2_3_2_2_2()
        {
            RunFile("15.2.3.2-2-2.js");
        }

        [Test(Description = "Object.getPrototypeOf returns the [[Prototype]] of its parameter (Function Object)")]
        public void _15_2_3_2_2_20()
        {
            RunFile("15.2.3.2-2-20.js");
        }

        [Test(Description = "Object.getPrototypeOf returns the [[Prototype]] of its parameter (Array object)")]
        public void _15_2_3_2_2_21()
        {
            RunFile("15.2.3.2-2-21.js");
        }

        [Test(Description = "Object.getPrototypeOf returns the [[Prototype]] of its parameter (String object)")]
        public void _15_2_3_2_2_22()
        {
            RunFile("15.2.3.2-2-22.js");
        }

        [Test(Description = "Object.getPrototypeOf returns the [[Prototype]] of its parameter (Boolean object)")]
        public void _15_2_3_2_2_23()
        {
            RunFile("15.2.3.2-2-23.js");
        }

        [Test(Description = "Object.getPrototypeOf returns the [[Prototype]] of its parameter (Number object)")]
        public void _15_2_3_2_2_24()
        {
            RunFile("15.2.3.2-2-24.js");
        }

        [Test(Description = "Object.getPrototypeOf returns the [[Prototype]] of its parameter (Date object)")]
        public void _15_2_3_2_2_25()
        {
            RunFile("15.2.3.2-2-25.js");
        }

        [Test(Description = "Object.getPrototypeOf returns the [[Prototype]] of its parameter (RegExp object)")]
        public void _15_2_3_2_2_26()
        {
            RunFile("15.2.3.2-2-26.js");
        }

        [Test(Description = "Object.getPrototypeOf returns the [[Prototype]] of its parameter (Error object)")]
        public void _15_2_3_2_2_27()
        {
            RunFile("15.2.3.2-2-27.js");
        }

        [Test(Description = "Object.getPrototypeOf returns the [[Prototype]] of its parameter (the Arguments object)")]
        public void _15_2_3_2_2_28()
        {
            RunFile("15.2.3.2-2-28.js");
        }

        [Test(Description = "Object.getPrototypeOf returns the [[Prototype]] of its parameter (Object)")]
        public void _15_2_3_2_2_3()
        {
            RunFile("15.2.3.2-2-3.js");
        }

        [Test(Description = "Object.getPrototypeOf returns the [[Prototype]] of its parameter (the global object)")]
        public void _15_2_3_2_2_30()
        {
            RunFile("15.2.3.2-2-30.js");
        }

        [Test(Description = "Object.getPrototypeOf returns null")]
        public void _15_2_3_2_2_31()
        {
            RunFile("15.2.3.2-2-31.js");
        }

        [Test(Description = "Object.getPrototypeOf returns the [[Prototype]] of its parameter (Function)")]
        public void _15_2_3_2_2_4()
        {
            RunFile("15.2.3.2-2-4.js");
        }

        [Test(Description = "Object.getPrototypeOf returns the [[Prototype]] of its parameter (Array)")]
        public void _15_2_3_2_2_5()
        {
            RunFile("15.2.3.2-2-5.js");
        }

        [Test(Description = "Object.getPrototypeOf returns the [[Prototype]] of its parameter (String)")]
        public void _15_2_3_2_2_6()
        {
            RunFile("15.2.3.2-2-6.js");
        }

        [Test(Description = "Object.getPrototypeOf returns the [[Prototype]] of its parameter (Number)")]
        public void _15_2_3_2_2_7()
        {
            RunFile("15.2.3.2-2-7.js");
        }

        [Test(Description = "Object.getPrototypeOf returns the [[Prototype]] of its parameter (Math)")]
        public void _15_2_3_2_2_8()
        {
            RunFile("15.2.3.2-2-8.js");
        }

        [Test(Description = "Object.getPrototypeOf returns the [[Prototype]] of its parameter (Date)")]
        public void _15_2_3_2_2_9()
        {
            RunFile("15.2.3.2-2-9.js");
        }
    }
}
