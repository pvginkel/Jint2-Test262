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

namespace Jint.Test262.Ch15._15_9._15_9_5
{
    [TestFixture]
    public class _15_9_5_43Fixture : Test262Fixture
    {
        public _15_9_5_43Fixture()
            : base("ch15\\15.9\\15.9.5\\15.9.5.43")
        {
        }

        [Test(Description = "Date.prototype.toISOString - RangeError is not thrown when value of date is Date(1970, 0, -99999999, 0, 0, 0, 1), the time zone is UTC(0)")]
        public void _15_9_5_43_0_10()
        {
            RunFile("15.9.5.43-0-10.js");
        }

        [Test(Description = "Date.prototype.toISOString - RangeError is not thrown when value of date is Date(1970, 0, 100000001, 0, 0, 0, -1), the time zone is UTC(0)")]
        public void _15_9_5_43_0_11()
        {
            RunFile("15.9.5.43-0-11.js");
        }

        [Test(Description = "Date.prototype.toISOString - RangeError is not thrown when value of date is Date(1970, 0, 100000001, 0, 0, 0, 0), the time zone is UTC(0)")]
        public void _15_9_5_43_0_12()
        {
            RunFile("15.9.5.43-0-12.js");
        }

        [Test(Description = "Date.prototype.toISOString - RangeError is thrown when value of date is Date(1970, 0, 100000001, 0, 0, 0, 1), the time zone is UTC(0)")]
        public void _15_9_5_43_0_13()
        {
            RunFile("15.9.5.43-0-13.js");
        }

        [Test(Description = "Date.prototype.toISOString - when value of year is -Infinity Date.prototype.toISOString throw the RangeError")]
        public void _15_9_5_43_0_14()
        {
            RunFile("15.9.5.43-0-14.js");
        }

        [Test(Description = "Date.prototype.toISOString - value of year is Infinity Date.prototype.toISOString throw the RangeError")]
        public void _15_9_5_43_0_15()
        {
            RunFile("15.9.5.43-0-15.js");
        }

        [Test(Description = "Date.prototype.toISOString - when this is a String object that value format is 'YYYY-MM-DDTHH:mm:ss.sssZ' Date.prototype.toISOString throw the TypeError")]
        public void _15_9_5_43_0_16()
        {
            RunFile("15.9.5.43-0-16.js");
        }

        [Test(Description = "Date.prototype.toISOString must exist as a function taking 0 parameters")]
        public void _15_9_5_43_0_2()
        {
            RunFile("15.9.5.43-0-2.js");
        }

        [Test(Description = "Date.prototype.toISOString must exist as a function")]
        public void _15_9_5_43_0_3()
        {
            RunFile("15.9.5.43-0-3.js");
        }

        [Test(Description = "Date.prototype.toISOString - format of returned string is 'YYYY-MM-DDTHH:mm:ss.sssZ', the time zone is UTC(0)")]
        public void _15_9_5_43_0_4()
        {
            RunFile("15.9.5.43-0-4.js");
        }

        [Test(Description = "Date.prototype.toISOString - The returned string is the UTC time zone(0)")]
        public void _15_9_5_43_0_5()
        {
            RunFile("15.9.5.43-0-5.js");
        }

        [Test(Description = "Date.prototype.toISOString - TypeError is thrown when this is any other objects instead of Date object")]
        public void _15_9_5_43_0_6()
        {
            RunFile("15.9.5.43-0-6.js");
        }

        [Test(Description = "Date.prototype.toISOString - TypeError is thrown when this is any primitive values")]
        public void _15_9_5_43_0_7()
        {
            RunFile("15.9.5.43-0-7.js");
        }

        [Test(Description = "Date.prototype.toISOString - RangeError is thrown when value of date is Date(1970, 0, -99999999, 0, 0, 0, -1), the time zone is UTC(0)")]
        public void _15_9_5_43_0_8()
        {
            RunFile("15.9.5.43-0-8.js");
        }

        [Test(Description = "Date.prototype.toISOString - RangeError is not thrown when value of date is Date(1970, 0, -99999999, 0, 0, 0, 0), the time zone is UTC(0)")]
        public void _15_9_5_43_0_9()
        {
            RunFile("15.9.5.43-0-9.js");
        }
    }
}
