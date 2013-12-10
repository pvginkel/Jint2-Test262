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

namespace Jint.Test262.Ch15._15_2._15_2_4
{
    [TestFixture]
    public class _15_2_4_2Fixture : Test262Fixture
    {
        public _15_2_4_2Fixture()
            : base("ch15\\15.2\\15.2.4\\15.2.4.2")
        {
        }

        [Test(Description = "Object.prototype.toString - '[object Undefined]' will be returned when 'this' value is undefined")]
        public void _15_2_4_2_1_1()
        {
            RunFile("15.2.4.2-1-1.js");
        }

        [Test(Description = "Object.prototype.toString - '[object Undefined]' will be returned when 'this' value is undefined")]
        public void _15_2_4_2_1_2()
        {
            RunFile("15.2.4.2-1-2.js");
        }

        [Test(Description = "Object.prototype.toString - '[object Null]' will be returned when 'this' value is null")]
        public void _15_2_4_2_2_1()
        {
            RunFile("15.2.4.2-2-1.js");
        }

        [Test(Description = "Object.prototype.toString - '[object Null]' will be returned when 'this' value is null")]
        public void _15_2_4_2_2_2()
        {
            RunFile("15.2.4.2-2-2.js");
        }

        [Test(Description = "Checking the type of Object.prototype.toString and the returned result")]
        public void S15_2_4_2_A1()
        {
            RunFile("S15.2.4.2_A1.js");
        }

        [Test(Description = "Checking if varying the Object.prototype.toString.length property fails")]
        public void S15_2_4_2_A10()
        {
            RunFile("S15.2.4.2_A10.js");
        }

        [Test(Description = "Checking the Object.prototype.toString.length property")]
        public void S15_2_4_2_A11()
        {
            RunFile("S15.2.4.2_A11.js");
        }

        [Test(Description = "If the this value is undefined, return \"[object Undefined]\".")]
        public void S15_2_4_2_A12()
        {
            RunFile("S15.2.4.2_A12.js");
        }

        [Test(Description = "If the this value is null, return \"[object Null]\".")]
        public void S15_2_4_2_A13()
        {
            RunFile("S15.2.4.2_A13.js");
        }

        [Test(Description = "Let O be the result of calling ToObject passing the this value as the argument.")]
        public void S15_2_4_2_A14()
        {
            RunFile("S15.2.4.2_A14.js");
        }

        [Test(Description = "Let O be the result of calling ToObject passing the this value as the argument.")]
        public void S15_2_4_2_A15()
        {
            RunFile("S15.2.4.2_A15.js");
        }

        [Test(Description = "Let O be the result of calling ToObject passing the this value as the argument.")]
        public void S15_2_4_2_A16()
        {
            RunFile("S15.2.4.2_A16.js");
        }

        [Test(Description = "Checking if obtaining the prototype property of Object.prototype.toString fails")]
        public void S15_2_4_2_A6()
        {
            RunFile("S15.2.4.2_A6.js");
        }

        [Test(Description = "Checking if creating \"new Object.prototype.toString\" fails")]
        public void S15_2_4_2_A7()
        {
            RunFile("S15.2.4.2_A7.js");
        }

        [Test(Description = "Checking if enumerating the Object.prototype.toString.length property fails")]
        public void S15_2_4_2_A8()
        {
            RunFile("S15.2.4.2_A8.js");
        }

        [Test(Description = "Checknig if deleting of the Object.prototype.toString.length property fails")]
        public void S15_2_4_2_A9()
        {
            RunFile("S15.2.4.2_A9.js");
        }
    }
}
