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
    public class _15_5_4_5Fixture : Test262Fixture
    {
        public _15_5_4_5Fixture()
            : base("ch15\\15.5\\15.5.4\\15.5.4.5")
        {
        }

        [Test(Description = "Checking by using eval")]
        public void S15_5_4_5_A1_1()
        {
            RunFile("S15.5.4.5_A1.1.js");
        }

        [Test(Description = "Checking if varying the String.prototype.charCodeAt.length property fails")]
        public void S15_5_4_5_A10()
        {
            RunFile("S15.5.4.5_A10.js");
        }

        [Test(Description = "Checking String.prototype.charCodeAt.length")]
        public void S15_5_4_5_A11()
        {
            RunFile("S15.5.4.5_A11.js");
        }

        [Test(Description = "pos is false and true, and instance is object")]
        public void S15_5_4_5_A1_T1()
        {
            RunFile("S15.5.4.5_A1_T1.js");
        }

        [Test(Description = "Call charCodeAt() function with object argument")]
        public void S15_5_4_5_A1_T10()
        {
            RunFile("S15.5.4.5_A1_T10.js");
        }

        [Test(Description = "pos is equation with false and true, and instance is Boolean object")]
        public void S15_5_4_5_A1_T2()
        {
            RunFile("S15.5.4.5_A1_T2.js");
        }

        [Test(Description = "Call charCodeAt() function without argument of string object")]
        public void S15_5_4_5_A1_T4()
        {
            RunFile("S15.5.4.5_A1_T4.js");
        }

        [Test(Description = "Call charCodeAt() function with null argument of function object")]
        public void S15_5_4_5_A1_T5()
        {
            RunFile("S15.5.4.5_A1_T5.js");
        }

        [Test(Description = "Call charCodeAt() function with x argument of new String object, where x is undefined variable")]
        public void S15_5_4_5_A1_T6()
        {
            RunFile("S15.5.4.5_A1_T6.js");
        }

        [Test(Description = "Call charCodeAt() function with undefined argument of string object")]
        public void S15_5_4_5_A1_T7()
        {
            RunFile("S15.5.4.5_A1_T7.js");
        }

        [Test(Description = "Call charCodeAt() function with void 0 argument of string object")]
        public void S15_5_4_5_A1_T8()
        {
            RunFile("S15.5.4.5_A1_T8.js");
        }

        [Test(Description = "Call charCodeAt() function with function(){}() argument of string object")]
        public void S15_5_4_5_A1_T9()
        {
            RunFile("S15.5.4.5_A1_T9.js");
        }

        [Test(Description = "Call charCodeAt(pos) with negative pos")]
        public void S15_5_4_5_A2()
        {
            RunFile("S15.5.4.5_A2.js");
        }

        [Test(Description = "pos is bigger of string length")]
        public void S15_5_4_5_A3()
        {
            RunFile("S15.5.4.5_A3.js");
        }

        [Test(Description = "Change toString function, it trow exception, and call charCodeAt()")]
        public void S15_5_4_5_A4()
        {
            RunFile("S15.5.4.5_A4.js");
        }

        [Test(Description = "Checking String.prototype.charCodeAt.prototype")]
        public void S15_5_4_5_A6()
        {
            RunFile("S15.5.4.5_A6.js");
        }

        [Test(Description = "Checking if creating the String.prototype.charCodeAt object fails")]
        public void S15_5_4_5_A7()
        {
            RunFile("S15.5.4.5_A7.js");
        }

        [Test(Description = "Checking if enumerating the String.prototype.charCodeAt.length property fails")]
        public void S15_5_4_5_A8()
        {
            RunFile("S15.5.4.5_A8.js");
        }

        [Test(Description = "Checking if deleting the String.prototype.charCodeAt.length property fails")]
        public void S15_5_4_5_A9()
        {
            RunFile("S15.5.4.5_A9.js");
        }
    }
}
