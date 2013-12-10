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
    public class _15_5_4_4Fixture : Test262Fixture
    {
        public _15_5_4_4Fixture()
            : base("ch15\\15.5\\15.5.4\\15.5.4.4")
        {
        }

        [Test(Description = "Checking by using eval")]
        public void S15_5_4_4_A1_1()
        {
            RunFile("S15.5.4.4_A1.1.js");
        }

        [Test(Description = "Checking if varying the String.prototype.charAt.length property fails")]
        public void S15_5_4_4_A10()
        {
            RunFile("S15.5.4.4_A10.js");
        }

        [Test(Description = "Checking String.prototype.charAt.length")]
        public void S15_5_4_4_A11()
        {
            RunFile("S15.5.4.4_A11.js");
        }

        [Test(Description = "pos is false and true, and instance is object")]
        public void S15_5_4_4_A1_T1()
        {
            RunFile("S15.5.4.4_A1_T1.js");
        }

        [Test(Description = "Call charAt() function with object argument")]
        public void S15_5_4_4_A1_T10()
        {
            RunFile("S15.5.4.4_A1_T10.js");
        }

        [Test(Description = "pos is equation with false and true, and instance is Boolean object")]
        public void S15_5_4_4_A1_T2()
        {
            RunFile("S15.5.4.4_A1_T2.js");
        }

        [Test(Description = "Call charAt() function without argument of string object")]
        public void S15_5_4_4_A1_T4()
        {
            RunFile("S15.5.4.4_A1_T4.js");
        }

        [Test(Description = "Call charAt() function with null argument of function object")]
        public void S15_5_4_4_A1_T5()
        {
            RunFile("S15.5.4.4_A1_T5.js");
        }

        [Test(Description = "Call charAt() function with x argument of new String object, where x is undefined variable")]
        public void S15_5_4_4_A1_T6()
        {
            RunFile("S15.5.4.4_A1_T6.js");
        }

        [Test(Description = "Call charAt() function with undefined argument of string object")]
        public void S15_5_4_4_A1_T7()
        {
            RunFile("S15.5.4.4_A1_T7.js");
        }

        [Test(Description = "Call charAt() function with void 0 argument of string object")]
        public void S15_5_4_4_A1_T8()
        {
            RunFile("S15.5.4.4_A1_T8.js");
        }

        [Test(Description = "Call charAt() function with function(){}() argument of string object")]
        public void S15_5_4_4_A1_T9()
        {
            RunFile("S15.5.4.4_A1_T9.js");
        }

        [Test(Description = "Call charAt(pos) with negative pos")]
        public void S15_5_4_4_A2()
        {
            RunFile("S15.5.4.4_A2.js");
        }

        [Test(Description = "pos is bigger of string length")]
        public void S15_5_4_4_A3()
        {
            RunFile("S15.5.4.4_A3.js");
        }

        [Test(Description = "Compare results of x.charAt(pos) and x.substring(pos, pos+1)")]
        public void S15_5_4_4_A4_T1()
        {
            RunFile("S15.5.4.4_A4_T1.js");
        }

        [Test(Description = "Compare results of x.charAt(pos) and x.substring(pos, pos+1), wheb pos is smaller of zero")]
        public void S15_5_4_4_A4_T2()
        {
            RunFile("S15.5.4.4_A4_T2.js");
        }

        [Test(Description = "Compare results of x.charAt(pos) and x.substring(pos, pos+1), wheb pos is bigger string length")]
        public void S15_5_4_4_A4_T3()
        {
            RunFile("S15.5.4.4_A4_T3.js");
        }

        [Test(Description = "Change toString function, it trow exception, and call charAt()")]
        public void S15_5_4_4_A5()
        {
            RunFile("S15.5.4.4_A5.js");
        }

        [Test(Description = "Checking String.prototype.charAt.prototype")]
        public void S15_5_4_4_A6()
        {
            RunFile("S15.5.4.4_A6.js");
        }

        [Test(Description = "Checking if creating the String.prototype.charAt object fails")]
        public void S15_5_4_4_A7()
        {
            RunFile("S15.5.4.4_A7.js");
        }

        [Test(Description = "Checking if enumerating the String.prototype.charAt.length property fails")]
        public void S15_5_4_4_A8()
        {
            RunFile("S15.5.4.4_A8.js");
        }

        [Test(Description = "Checking if deleting the String.prototype.charAt.length property fails")]
        public void S15_5_4_4_A9()
        {
            RunFile("S15.5.4.4_A9.js");
        }
    }
}
