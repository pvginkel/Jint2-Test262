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
    public class _15_2_3_13Fixture : Test262Fixture
    {
        public _15_2_3_13Fixture()
            : base("ch15\\15.2\\15.2.3\\15.2.3.13")
        {
        }

        [Test(Description = "Object.isExtensible must exist as a function")]
        public void _15_2_3_13_0_1()
        {
            RunFile("15.2.3.13-0-1.js");
        }

        [Test(Description = "Object.isExtensible must exist as a function taking 1 parameter")]
        public void _15_2_3_13_0_2()
        {
            RunFile("15.2.3.13-0-2.js");
        }

        [Test(Description = "Object.isExtensible is true for objects created using the Object constructor")]
        public void _15_2_3_13_0_3()
        {
            RunFile("15.2.3.13-0-3.js");
        }

        [Test(Description = "Object.isExtensible throws TypeError if 'O' is undefined")]
        public void _15_2_3_13_1_1()
        {
            RunFile("15.2.3.13-1-1.js");
        }

        [Test(Description = "Object.isExtensible throws TypeError if 'O' is null")]
        public void _15_2_3_13_1_2()
        {
            RunFile("15.2.3.13-1-2.js");
        }

        [Test(Description = "Object.isExtensible throws TypeError if 'O' is a boolean")]
        public void _15_2_3_13_1_3()
        {
            RunFile("15.2.3.13-1-3.js");
        }

        [Test(Description = "Object.isExtensible throws TypeError if 'O' is a string")]
        public void _15_2_3_13_1_4()
        {
            RunFile("15.2.3.13-1-4.js");
        }

        [Test(Description = "Object.isExtensible throws TypeError if type of first param is not Object")]
        public void _15_2_3_13_1()
        {
            RunFile("15.2.3.13-1.js");
        }

        [Test(Description = "Object.isExtensible returns true for all built-in objects (Global)")]
        public void _15_2_3_13_2_1()
        {
            RunFile("15.2.3.13-2-1.js");
        }

        [Test(Description = "Object.isExtensible returns true for all built-in objects (RegExp)")]
        public void _15_2_3_13_2_10()
        {
            RunFile("15.2.3.13-2-10.js");
        }

        [Test(Description = "Object.isExtensible returns true for all built-in objects (Error)")]
        public void _15_2_3_13_2_11()
        {
            RunFile("15.2.3.13-2-11.js");
        }

        [Test(Description = "Object.isExtensible returns true for all built-in objects (JSON)")]
        public void _15_2_3_13_2_12()
        {
            RunFile("15.2.3.13-2-12.js");
        }

        [Test(Description = "Object.isExtensible returns true for all built-in objects (Function.constructor)")]
        public void _15_2_3_13_2_13()
        {
            RunFile("15.2.3.13-2-13.js");
        }

        [Test(Description = "Object.isExtensible returns true for all built-in objects (Function.prototype)")]
        public void _15_2_3_13_2_14()
        {
            RunFile("15.2.3.13-2-14.js");
        }

        [Test(Description = "Object.isExtensible returns true for all built-in objects (Array.prototype)")]
        public void _15_2_3_13_2_15()
        {
            RunFile("15.2.3.13-2-15.js");
        }

        [Test(Description = "Object.isExtensible returns true for all built-in objects (String.prototype)")]
        public void _15_2_3_13_2_16()
        {
            RunFile("15.2.3.13-2-16.js");
        }

        [Test(Description = "Object.isExtensible returns true for all built-in objects (Boolean.prototype)")]
        public void _15_2_3_13_2_17()
        {
            RunFile("15.2.3.13-2-17.js");
        }

        [Test(Description = "Object.isExtensible returns true for all built-in objects (Number.prototype)")]
        public void _15_2_3_13_2_18()
        {
            RunFile("15.2.3.13-2-18.js");
        }

        [Test(Description = "Object.isExtensible returns true for all built-in objects (Date.prototype)")]
        public void _15_2_3_13_2_19()
        {
            RunFile("15.2.3.13-2-19.js");
        }

        [Test(Description = "Object.isExtensible returns true for all built-in objects (Object)")]
        public void _15_2_3_13_2_2()
        {
            RunFile("15.2.3.13-2-2.js");
        }

        [Test(Description = "Object.isExtensible returns true for all built-in objects (RegExp.prototype)")]
        public void _15_2_3_13_2_20()
        {
            RunFile("15.2.3.13-2-20.js");
        }

        [Test(Description = "Object.isExtensible returns true for all built-in objects (Error.prototype)")]
        public void _15_2_3_13_2_21()
        {
            RunFile("15.2.3.13-2-21.js");
        }

        [Test(Description = "Object.isExtensible returns true if 'O' is extensible")]
        public void _15_2_3_13_2_22()
        {
            RunFile("15.2.3.13-2-22.js");
        }

        [Test(Description = "Object.isExtensible returns false if 'O' is not extensible")]
        public void _15_2_3_13_2_23()
        {
            RunFile("15.2.3.13-2-23.js");
        }

        [Test(Description = "Object.isExtensible returns true if O is extensible and has a prototype that is extensible")]
        public void _15_2_3_13_2_24()
        {
            RunFile("15.2.3.13-2-24.js");
        }

        [Test(Description = "Object.isExtensible returns true if O is extensible and has a prototype that is not extensible")]
        public void _15_2_3_13_2_25()
        {
            RunFile("15.2.3.13-2-25.js");
        }

        [Test(Description = "Object.isExtensible returns false if O is not extensible and has a prototype that is extensible")]
        public void _15_2_3_13_2_26()
        {
            RunFile("15.2.3.13-2-26.js");
        }

        [Test(Description = "Object.isExtensible returns false if O is not extensible and has a prototype that is not extensible")]
        public void _15_2_3_13_2_27()
        {
            RunFile("15.2.3.13-2-27.js");
        }

        [Test(Description = "Object.isExtensible returns true for the global object")]
        public void _15_2_3_13_2_29()
        {
            RunFile("15.2.3.13-2-29.js");
        }

        [Test(Description = "Object.isExtensible returns true for all built-in objects (Function)")]
        public void _15_2_3_13_2_3()
        {
            RunFile("15.2.3.13-2-3.js");
        }

        [Test(Description = "Object.isExtensible returns true for all built-in objects (Array)")]
        public void _15_2_3_13_2_4()
        {
            RunFile("15.2.3.13-2-4.js");
        }

        [Test(Description = "Object.isExtensible returns true for all built-in objects (String)")]
        public void _15_2_3_13_2_5()
        {
            RunFile("15.2.3.13-2-5.js");
        }

        [Test(Description = "Object.isExtensible returns true for all built-in objects (Boolean)")]
        public void _15_2_3_13_2_6()
        {
            RunFile("15.2.3.13-2-6.js");
        }

        [Test(Description = "Object.isExtensible returns true for all built-in objects (Number)")]
        public void _15_2_3_13_2_7()
        {
            RunFile("15.2.3.13-2-7.js");
        }

        [Test(Description = "Object.isExtensible returns true for all built-in objects (Math)")]
        public void _15_2_3_13_2_8()
        {
            RunFile("15.2.3.13-2-8.js");
        }

        [Test(Description = "Object.isExtensible returns true for all built-in objects (Date)")]
        public void _15_2_3_13_2_9()
        {
            RunFile("15.2.3.13-2-9.js");
        }
    }
}