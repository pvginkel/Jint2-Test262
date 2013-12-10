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

namespace Jint.Test262.Ch15._15_4._15_4_3
{
    [TestFixture]
    public class _15_4_3_2Fixture : Test262Fixture
    {
        public _15_4_3_2Fixture()
            : base("ch15\\15.4\\15.4.3\\15.4.3.2")
        {
        }

        [Test(Description = "Array.isArray must exist as a function")]
        public void _15_4_3_2_0_1()
        {
            RunFile("15.4.3.2-0-1.js");
        }

        [Test(Description = "Array.isArray must exist as a function taking 1 parameter")]
        public void _15_4_3_2_0_2()
        {
            RunFile("15.4.3.2-0-2.js");
        }

        [Test(Description = "Array.isArray return true if its argument is an Array")]
        public void _15_4_3_2_0_3()
        {
            RunFile("15.4.3.2-0-3.js");
        }

        [Test(Description = "Array.isArray return false if its argument is not an Array")]
        public void _15_4_3_2_0_4()
        {
            RunFile("15.4.3.2-0-4.js");
        }

        [Test(Description = "Array.isArray return true if its argument is an Array (Array.prototype)")]
        public void _15_4_3_2_0_5()
        {
            RunFile("15.4.3.2-0-5.js");
        }

        [Test(Description = "Array.isArray return true if its argument is an Array (new Array())")]
        public void _15_4_3_2_0_6()
        {
            RunFile("15.4.3.2-0-6.js");
        }

        [Test(Description = "Array.isArray returns false if its argument is not an Array")]
        public void _15_4_3_2_0_7()
        {
            RunFile("15.4.3.2-0-7.js");
        }

        [Test(Description = "Array.isArray applied to boolean primitive")]
        public void _15_4_3_2_1_1()
        {
            RunFile("15.4.3.2-1-1.js");
        }

        [Test(Description = "Array.isArray applied to RegExp object")]
        public void _15_4_3_2_1_10()
        {
            RunFile("15.4.3.2-1-10.js");
        }

        [Test(Description = "Array.isArray applied to the JSON object")]
        public void _15_4_3_2_1_11()
        {
            RunFile("15.4.3.2-1-11.js");
        }

        [Test(Description = "Array.isArray applied to Error object")]
        public void _15_4_3_2_1_12()
        {
            RunFile("15.4.3.2-1-12.js");
        }

        [Test(Description = "Array.isArray applied to Arguments object")]
        public void _15_4_3_2_1_13()
        {
            RunFile("15.4.3.2-1-13.js");
        }

        [Test(Description = "Array.isArray applied to the global object")]
        public void _15_4_3_2_1_15()
        {
            RunFile("15.4.3.2-1-15.js");
        }

        [Test(Description = "Array.isArray applied to Boolean Object")]
        public void _15_4_3_2_1_2()
        {
            RunFile("15.4.3.2-1-2.js");
        }

        [Test(Description = "Array.isArray applied to number primitive")]
        public void _15_4_3_2_1_3()
        {
            RunFile("15.4.3.2-1-3.js");
        }

        [Test(Description = "Array.isArray applied to Number object")]
        public void _15_4_3_2_1_4()
        {
            RunFile("15.4.3.2-1-4.js");
        }

        [Test(Description = "Array.isArray applied to string primitive")]
        public void _15_4_3_2_1_5()
        {
            RunFile("15.4.3.2-1-5.js");
        }

        [Test(Description = "Array.isArray applied to String object")]
        public void _15_4_3_2_1_6()
        {
            RunFile("15.4.3.2-1-6.js");
        }

        [Test(Description = "Array.isArray applied to Function object")]
        public void _15_4_3_2_1_7()
        {
            RunFile("15.4.3.2-1-7.js");
        }

        [Test(Description = "Array.isArray applied to the Math object")]
        public void _15_4_3_2_1_8()
        {
            RunFile("15.4.3.2-1-8.js");
        }

        [Test(Description = "Array.isArray applied to Date object")]
        public void _15_4_3_2_1_9()
        {
            RunFile("15.4.3.2-1-9.js");
        }

        [Test(Description = "Array.isArray applied to an object with an array as the prototype")]
        public void _15_4_3_2_2_1()
        {
            RunFile("15.4.3.2-2-1.js");
        }

        [Test(Description = "Array.isArray applied to an object with Array.prototype as the prototype")]
        public void _15_4_3_2_2_2()
        {
            RunFile("15.4.3.2-2-2.js");
        }

        [Test(Description = "Array.isArray applied to an Array-like object with length and some indexed properties")]
        public void _15_4_3_2_2_3()
        {
            RunFile("15.4.3.2-2-3.js");
        }
    }
}