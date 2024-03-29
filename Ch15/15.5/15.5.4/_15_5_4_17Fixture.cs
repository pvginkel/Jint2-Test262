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
    public class _15_5_4_17Fixture : Test262Fixture
    {
        public _15_5_4_17Fixture()
            : base("ch15\\15.5\\15.5.4\\15.5.4.17")
        {
        }

        [Test(Description = "Checking if varying the String.prototype.toLocaleLowerCase.length property fails")]
        public void S15_5_4_17_A10()
        {
            RunFile("S15.5.4.17_A10.js");
        }

        [Test(Description = "Checking String.prototype.toLocaleLowerCase.length")]
        public void S15_5_4_17_A11()
        {
            RunFile("S15.5.4.17_A11.js");
        }

        [Test(Description = "Arguments is true, and instance is object")]
        public void S15_5_4_17_A1_T1()
        {
            RunFile("S15.5.4.17_A1_T1.js");
        }

        [Test(Description = "Call toLocaleLowerCase() function of object with overrode toString function")]
        public void S15_5_4_17_A1_T10()
        {
            RunFile("S15.5.4.17_A1_T10.js");
        }

        [Test(Description = "Override toString function, toString throw exception, then call toLocaleLowerCase() function for this object")]
        public void S15_5_4_17_A1_T11()
        {
            RunFile("S15.5.4.17_A1_T11.js");
        }

        [Test(Description = "Override toString and valueOf functions, valueOf throw exception, then call toLocaleLowerCase() function for this object")]
        public void S15_5_4_17_A1_T12()
        {
            RunFile("S15.5.4.17_A1_T12.js");
        }

        [Test(Description = "Override toString and valueOf functions, then call toLocaleLowerCase() function for this object")]
        public void S15_5_4_17_A1_T13()
        {
            RunFile("S15.5.4.17_A1_T13.js");
        }

        [Test(Description = "Call toLocaleLowerCase() function for RegExp object")]
        public void S15_5_4_17_A1_T14()
        {
            RunFile("S15.5.4.17_A1_T14.js");
        }

        [Test(Description = "Instance is Boolean object")]
        public void S15_5_4_17_A1_T2()
        {
            RunFile("S15.5.4.17_A1_T2.js");
        }

        [Test(Description = "Checking by using eval")]
        public void S15_5_4_17_A1_T3()
        {
            RunFile("S15.5.4.17_A1_T3.js");
        }

        [Test(Description = "Call toLocaleLowerCase() function without arguments of string and from empty string")]
        public void S15_5_4_17_A1_T4()
        {
            RunFile("S15.5.4.17_A1_T4.js");
        }

        [Test(Description = "Call toLocaleLowerCase() function for function call")]
        public void S15_5_4_17_A1_T5()
        {
            RunFile("S15.5.4.17_A1_T5.js");
        }

        [Test(Description = "Call toLocaleLowerCase() function of Number.NEGATIVE_INFINITY")]
        public void S15_5_4_17_A1_T6()
        {
            RunFile("S15.5.4.17_A1_T6.js");
        }

        [Test(Description = "Call toLocaleLowerCase() function of NaN")]
        public void S15_5_4_17_A1_T7()
        {
            RunFile("S15.5.4.17_A1_T7.js");
        }

        [Test(Description = "Call toLocaleLowerCase() function of Infinity")]
        public void S15_5_4_17_A1_T8()
        {
            RunFile("S15.5.4.17_A1_T8.js");
        }

        [Test(Description = "Call toLocaleLowerCase() function of string object")]
        public void S15_5_4_17_A1_T9()
        {
            RunFile("S15.5.4.17_A1_T9.js");
        }

        [Test(Description = "Checking returned result")]
        public void S15_5_4_17_A2_T1()
        {
            RunFile("S15.5.4.17_A2_T1.js");
        }

        [Test(Description = "Checking String.prototype.toLocaleLowerCase.prototype")]
        public void S15_5_4_17_A6()
        {
            RunFile("S15.5.4.17_A6.js");
        }

        [Test(Description = "Checking if creating the String.prototype.toLocaleLowerCase object fails")]
        public void S15_5_4_17_A7()
        {
            RunFile("S15.5.4.17_A7.js");
        }

        [Test(Description = "Checking if enumerating the String.prototype.toLocaleLowerCase.length property fails")]
        public void S15_5_4_17_A8()
        {
            RunFile("S15.5.4.17_A8.js");
        }

        [Test(Description = "Checking if deleting the String.prototype.toLocaleLowerCase.length property fails")]
        public void S15_5_4_17_A9()
        {
            RunFile("S15.5.4.17_A9.js");
        }
    }
}
