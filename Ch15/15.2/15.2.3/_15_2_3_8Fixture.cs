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
    public class _15_2_3_8Fixture : Test262Fixture
    {
        public _15_2_3_8Fixture()
            : base("ch15\\15.2\\15.2.3\\15.2.3.8")
        {
        }

        [Test(Description = "Object.seal must exist as a function")]
        public void _15_2_3_8_0_1()
        {
            RunFile("15.2.3.8-0-1.js");
        }

        [Test(Description = "Object.seal must exist as a function taking 1 parameter")]
        public void _15_2_3_8_0_2()
        {
            RunFile("15.2.3.8-0-2.js");
        }

        [Test(Description = "Object.seal throws TypeError if type of first param is undefined")]
        public void _15_2_3_8_1_1()
        {
            RunFile("15.2.3.8-1-1.js");
        }

        [Test(Description = "Object.seal throws TypeError if type of first param is null")]
        public void _15_2_3_8_1_2()
        {
            RunFile("15.2.3.8-1-2.js");
        }

        [Test(Description = "Object.seal throws TypeError if type of first param is a boolean primitive")]
        public void _15_2_3_8_1_3()
        {
            RunFile("15.2.3.8-1-3.js");
        }

        [Test(Description = "Object.seal throws TypeError if type of first param is a string primitive")]
        public void _15_2_3_8_1_4()
        {
            RunFile("15.2.3.8-1-4.js");
        }

        [Test(Description = "Object.seal throws TypeError if type of first param is not Object")]
        public void _15_2_3_8_1()
        {
            RunFile("15.2.3.8-1.js");
        }

        [Test(Description = "Object.seal - extensible of 'O' is set as false even if 'O' has no own property")]
        public void _15_2_3_8_2_1()
        {
            RunFile("15.2.3.8-2-1.js");
        }

        [Test(Description = "Object.seal - inherited data properties are ignored")]
        public void _15_2_3_8_2_2()
        {
            RunFile("15.2.3.8-2-2.js");
        }

        [Test(Description = "Object.seal - inherited accessor properties are ignored")]
        public void _15_2_3_8_2_3()
        {
            RunFile("15.2.3.8-2-3.js");
        }

        [Test(Description = "Object.seal - non-enumerable own property of 'O' is sealed")]
        public void _15_2_3_8_2_4()
        {
            RunFile("15.2.3.8-2-4.js");
        }

        [Test(Description = "Object.seal - 'P' is own data property")]
        public void _15_2_3_8_2_a_1()
        {
            RunFile("15.2.3.8-2-a-1.js");
        }

        [Test(Description = "Object.seal - 'P' is own property of a Boolean object that uses Object's [[GetOwnProperty]]")]
        public void _15_2_3_8_2_a_10()
        {
            RunFile("15.2.3.8-2-a-10.js");
        }

        [Test(Description = "Object.seal - 'P' is own property of a Number object that uses Object's [[GetOwnProperty]]")]
        public void _15_2_3_8_2_a_11()
        {
            RunFile("15.2.3.8-2-a-11.js");
        }

        [Test(Description = "Object.seal - 'P' is own property of a Date object that uses Object's [[GetOwnProperty]]")]
        public void _15_2_3_8_2_a_12()
        {
            RunFile("15.2.3.8-2-a-12.js");
        }

        [Test(Description = "Object.seal - 'P' is own property of a RegExp object that uses Object's [[GetOwnProperty]]")]
        public void _15_2_3_8_2_a_13()
        {
            RunFile("15.2.3.8-2-a-13.js");
        }

        [Test(Description = "Object.seal - 'P' is own property of an Error object that uses Object's [[GetOwnProperty]]")]
        public void _15_2_3_8_2_a_14()
        {
            RunFile("15.2.3.8-2-a-14.js");
        }

        [Test(Description = "Object.seal - 'P' is own property of an Arguments object which implements its own [[GetOwnProperty]]")]
        public void _15_2_3_8_2_a_15()
        {
            RunFile("15.2.3.8-2-a-15.js");
        }

        [Test(Description = "Object.seal - 'P' is own data property that overrides an inherited data property")]
        public void _15_2_3_8_2_a_2()
        {
            RunFile("15.2.3.8-2-a-2.js");
        }

        [Test(Description = "Object.seal - 'P' is own data property that overrides an inherited accessor property")]
        public void _15_2_3_8_2_a_3()
        {
            RunFile("15.2.3.8-2-a-3.js");
        }

        [Test(Description = "Object.seal - 'P' is own accessor property")]
        public void _15_2_3_8_2_a_4()
        {
            RunFile("15.2.3.8-2-a-4.js");
        }

        [Test(Description = "Object.seal - 'P' is own accessor property that overrides an inherited data property")]
        public void _15_2_3_8_2_a_5()
        {
            RunFile("15.2.3.8-2-a-5.js");
        }

        [Test(Description = "Object.seal - 'P' is own accessor property that overrides an inherited accessor property")]
        public void _15_2_3_8_2_a_6()
        {
            RunFile("15.2.3.8-2-a-6.js");
        }

        [Test(Description = "Object.seal - 'P' is own property of a Function object that uses Object's [[GetOwnProperty]]")]
        public void _15_2_3_8_2_a_7()
        {
            RunFile("15.2.3.8-2-a-7.js");
        }

        [Test(Description = "Object.seal - 'P' is own property of an Array object that uses Object's [[GetOwnProperty]]")]
        public void _15_2_3_8_2_a_8()
        {
            RunFile("15.2.3.8-2-a-8.js");
        }

        [Test(Description = "Object.seal - 'P' is own property of a String object which implements its own [[GetOwnProperty]]")]
        public void _15_2_3_8_2_a_9()
        {
            RunFile("15.2.3.8-2-a-9.js");
        }

        [Test(Description = "Object.seal - the [[Configurable]] attribute of own data property of 'O' is set from true to false and other attributes of the property are unaltered")]
        public void _15_2_3_8_2_b_1()
        {
            RunFile("15.2.3.8-2-b-1.js");
        }

        [Test(Description = "Object.seal - the [[Configurable]] attribute of own accessor property of 'O' is set from true to false and other attributes of the property are unaltered")]
        public void _15_2_3_8_2_b_2()
        {
            RunFile("15.2.3.8-2-b-2.js");
        }

        [Test(Description = "Object.seal - the [[Configurable]] attribute of all own properties of 'O' are set from true to false and other attributes of the property are unaltered")]
        public void _15_2_3_8_2_b_3()
        {
            RunFile("15.2.3.8-2-b-3.js");
        }

        [Test(Description = "Object.seal - all own properties of 'O' are already non-configurable")]
        public void _15_2_3_8_2_b_4()
        {
            RunFile("15.2.3.8-2-b-4.js");
        }

        [Test(Description = "Object.seal - 'O' is a Function object")]
        public void _15_2_3_8_2_c_1()
        {
            RunFile("15.2.3.8-2-c-1.js");
        }

        [Test(Description = "Object.seal - 'O' is an Array object")]
        public void _15_2_3_8_2_c_2()
        {
            RunFile("15.2.3.8-2-c-2.js");
        }

        [Test(Description = "Object.seal - 'O' is a String object")]
        public void _15_2_3_8_2_c_3()
        {
            RunFile("15.2.3.8-2-c-3.js");
        }

        [Test(Description = "Object.seal - 'O' is a Boolean object")]
        public void _15_2_3_8_2_c_4()
        {
            RunFile("15.2.3.8-2-c-4.js");
        }

        [Test(Description = "Object.seal - 'O' is a Number object")]
        public void _15_2_3_8_2_c_5()
        {
            RunFile("15.2.3.8-2-c-5.js");
        }

        [Test(Description = "Object.seal - 'O' is a Date object")]
        public void _15_2_3_8_2_c_6()
        {
            RunFile("15.2.3.8-2-c-6.js");
        }

        [Test(Description = "Object.seal - 'O' is a RegExp object")]
        public void _15_2_3_8_2_c_7()
        {
            RunFile("15.2.3.8-2-c-7.js");
        }

        [Test(Description = "Object.seal - 'O' is an Error object")]
        public void _15_2_3_8_2_c_8()
        {
            RunFile("15.2.3.8-2-c-8.js");
        }

        [Test(Description = "Object.seal - 'O' is an Arguments object")]
        public void _15_2_3_8_2_c_9()
        {
            RunFile("15.2.3.8-2-c-9.js");
        }

        [Test(Description = "Object.seal - returned object is not extensible")]
        public void _15_2_3_8_3_1()
        {
            RunFile("15.2.3.8-3-1.js");
        }

        [Test(Description = "Object.seal - 'O' is sealed already")]
        public void _15_2_3_8_4_1()
        {
            RunFile("15.2.3.8-4-1.js");
        }

        [Test(Description = "Object.seal - 'O' is frozen already")]
        public void _15_2_3_8_4_2()
        {
            RunFile("15.2.3.8-4-2.js");
        }

        [Test(Description = "Object.seal - the extension of 'O' is prevented already")]
        public void _15_2_3_8_4_3()
        {
            RunFile("15.2.3.8-4-3.js");
        }
    }
}
