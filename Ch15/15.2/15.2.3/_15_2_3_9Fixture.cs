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
    public class _15_2_3_9Fixture : Test262Fixture
    {
        public _15_2_3_9Fixture()
            : base("ch15\\15.2\\15.2.3\\15.2.3.9")
        {
        }

        [Test(Description = "Object.freeze must exist as a function")]
        public void _15_2_3_9_0_1()
        {
            RunFile("15.2.3.9-0-1.js");
        }

        [Test(Description = "Object.freeze must exist as a function taking 1 parameter")]
        public void _15_2_3_9_0_2()
        {
            RunFile("15.2.3.9-0-2.js");
        }

        [Test(Description = "Object.freeze throws TypeError if type of first param is undefined")]
        public void _15_2_3_9_1_1()
        {
            RunFile("15.2.3.9-1-1.js");
        }

        [Test(Description = "Object.freeze throws TypeError if type of first param is null")]
        public void _15_2_3_9_1_2()
        {
            RunFile("15.2.3.9-1-2.js");
        }

        [Test(Description = "Object.freeze throws TypeError if type of first param is boolean primitive")]
        public void _15_2_3_9_1_3()
        {
            RunFile("15.2.3.9-1-3.js");
        }

        [Test(Description = "Object.freeze throws TypeError if type of first param is string primitive")]
        public void _15_2_3_9_1_4()
        {
            RunFile("15.2.3.9-1-4.js");
        }

        [Test(Description = "Object.freeze throws TypeError if type of first param is not Object")]
        public void _15_2_3_9_1()
        {
            RunFile("15.2.3.9-1.js");
        }

        [Test(Description = "Object.freeze - extensible of 'O' is set as false even if 'O' has no own property")]
        public void _15_2_3_9_2_1()
        {
            RunFile("15.2.3.9-2-1.js");
        }

        [Test(Description = "Object.freeze - inherited data properties are not frozen")]
        public void _15_2_3_9_2_2()
        {
            RunFile("15.2.3.9-2-2.js");
        }

        [Test(Description = "Object.freeze - inherited accessor properties are not frozen")]
        public void _15_2_3_9_2_3()
        {
            RunFile("15.2.3.9-2-3.js");
        }

        [Test(Description = "Object.freeze - Non-enumerable own properties of 'O' are frozen")]
        public void _15_2_3_9_2_4()
        {
            RunFile("15.2.3.9-2-4.js");
        }

        [Test(Description = "Object.freeze - 'P' is own data property")]
        public void _15_2_3_9_2_a_1()
        {
            RunFile("15.2.3.9-2-a-1.js");
        }

        [Test(Description = "Object.freeze - 'P' is own named property of an Array object that uses Object's [[GetOwnProperty]]")]
        public void _15_2_3_9_2_a_10()
        {
            RunFile("15.2.3.9-2-a-10.js");
        }

        [Test(Description = "Object.freeze - 'P' is own index property of the Arguments object that implements its own [[GetOwnProperty]]")]
        public void _15_2_3_9_2_a_11()
        {
            RunFile("15.2.3.9-2-a-11.js");
        }

        [Test(Description = "Object.freeze - 'P' is own index property of a String object that implements its own [[GetOwnProperty]]")]
        public void _15_2_3_9_2_a_12()
        {
            RunFile("15.2.3.9-2-a-12.js");
        }

        [Test(Description = "Object.freeze - 'P' is own index property of the Object")]
        public void _15_2_3_9_2_a_13()
        {
            RunFile("15.2.3.9-2-a-13.js");
        }

        [Test(Description = "Object.freeze - 'P' is own index property of an Array object that uses Object's [[GetOwnProperty]]")]
        public void _15_2_3_9_2_a_14()
        {
            RunFile("15.2.3.9-2-a-14.js");
        }

        [Test(Description = "Object.freeze - 'P' is own data property that overrides an inherited data property")]
        public void _15_2_3_9_2_a_2()
        {
            RunFile("15.2.3.9-2-a-2.js");
        }

        [Test(Description = "Object.freeze - 'P' is own data property that overrides an inherited accessor property")]
        public void _15_2_3_9_2_a_3()
        {
            RunFile("15.2.3.9-2-a-3.js");
        }

        [Test(Description = "Object.freeze - 'P' is own accessor property")]
        public void _15_2_3_9_2_a_4()
        {
            RunFile("15.2.3.9-2-a-4.js");
        }

        [Test(Description = "Object.freeze - 'P' is own accessor property that overrides an inherited data property")]
        public void _15_2_3_9_2_a_5()
        {
            RunFile("15.2.3.9-2-a-5.js");
        }

        [Test(Description = "Object.freeze - 'P' is own accessor property that overrides an inherited accessor property")]
        public void _15_2_3_9_2_a_6()
        {
            RunFile("15.2.3.9-2-a-6.js");
        }

        [Test(Description = "Object.freeze - 'P' is own named property of an Arguments object that implements its own [[GetOwnProperty]]")]
        public void _15_2_3_9_2_a_7()
        {
            RunFile("15.2.3.9-2-a-7.js");
        }

        [Test(Description = "Object.freeze - 'P' is own named property of the String object that implements its own [[GetOwnProperty]]")]
        public void _15_2_3_9_2_a_8()
        {
            RunFile("15.2.3.9-2-a-8.js");
        }

        [Test(Description = "Object.freeze - 'P' is own property of the Function object that uses Object's [[GetOwnProperty]]")]
        public void _15_2_3_9_2_a_9()
        {
            RunFile("15.2.3.9-2-a-9.js");
        }

        [Test(Description = "Object.freeze - The [[Wrtiable]] attribute of own data property of 'O' is set to false while other attributes are unchanged")]
        public void _15_2_3_9_2_b_i_1()
        {
            RunFile("15.2.3.9-2-b-i-1.js");
        }

        [Test(Description = "Object.freeze - The [[Wrtiable]] attribute of all own data property of 'O' is set to false while other attributes are unchanged")]
        public void _15_2_3_9_2_b_i_2()
        {
            RunFile("15.2.3.9-2-b-i-2.js");
        }

        [Test(Description = "Object.freeze - The [[Configurable]] attribute of own data property of 'O' is set to false while other attributes are unchanged")]
        public void _15_2_3_9_2_c_1()
        {
            RunFile("15.2.3.9-2-c-1.js");
        }

        [Test(Description = "Object.freeze - The [[Configurable]] attribute of own accessor property of 'O' is set to false while other attributes are unchanged")]
        public void _15_2_3_9_2_c_2()
        {
            RunFile("15.2.3.9-2-c-2.js");
        }

        [Test(Description = "Object.freeze - The [[Configurable]] attribute of all own data property of 'O' is set to false while other attributes are unchanged")]
        public void _15_2_3_9_2_c_3()
        {
            RunFile("15.2.3.9-2-c-3.js");
        }

        [Test(Description = "Object.freeze - all own properties of 'O' are not writable and not configurable")]
        public void _15_2_3_9_2_c_4()
        {
            RunFile("15.2.3.9-2-c-4.js");
        }

        [Test(Description = "Object.freeze - 'O' is a Function object")]
        public void _15_2_3_9_2_d_1()
        {
            RunFile("15.2.3.9-2-d-1.js");
        }

        [Test(Description = "Object.freeze - 'O' is an Array object")]
        public void _15_2_3_9_2_d_2()
        {
            RunFile("15.2.3.9-2-d-2.js");
        }

        [Test(Description = "Object.freeze - 'O' is a String object")]
        public void _15_2_3_9_2_d_3()
        {
            RunFile("15.2.3.9-2-d-3.js");
        }

        [Test(Description = "Object.freeze - 'O' is a Boolean object")]
        public void _15_2_3_9_2_d_4()
        {
            RunFile("15.2.3.9-2-d-4.js");
        }

        [Test(Description = "Object.freeze - 'O' is a Number object")]
        public void _15_2_3_9_2_d_5()
        {
            RunFile("15.2.3.9-2-d-5.js");
        }

        [Test(Description = "Object.freeze - 'O' is a Date object")]
        public void _15_2_3_9_2_d_6()
        {
            RunFile("15.2.3.9-2-d-6.js");
        }

        [Test(Description = "Object.freeze - 'O' is a RegExp object")]
        public void _15_2_3_9_2_d_7()
        {
            RunFile("15.2.3.9-2-d-7.js");
        }

        [Test(Description = "Object.freeze - 'O' is an Error object")]
        public void _15_2_3_9_2_d_8()
        {
            RunFile("15.2.3.9-2-d-8.js");
        }

        [Test(Description = "Object.freeze - 'O' is the Arguments object")]
        public void _15_2_3_9_2_d_9()
        {
            RunFile("15.2.3.9-2-d-9.js");
        }

        [Test(Description = "Object.freeze - returned object is not extensible")]
        public void _15_2_3_9_3_1()
        {
            RunFile("15.2.3.9-3-1.js");
        }

        [Test(Description = "Object.freeze - 'O' is sealed already")]
        public void _15_2_3_9_4_1()
        {
            RunFile("15.2.3.9-4-1.js");
        }

        [Test(Description = "Object.freeze - 'O' is frozen already")]
        public void _15_2_3_9_4_2()
        {
            RunFile("15.2.3.9-4-2.js");
        }

        [Test(Description = "Object.freeze - the extensions of 'O' is prevented already")]
        public void _15_2_3_9_4_3()
        {
            RunFile("15.2.3.9-4-3.js");
        }
    }
}