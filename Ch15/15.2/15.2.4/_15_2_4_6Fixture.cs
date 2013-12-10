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
    public class _15_2_4_6Fixture : Test262Fixture
    {
        public _15_2_4_6Fixture()
            : base("ch15\\15.2\\15.2.4\\15.2.4.6")
        {
        }

        [Test(Description = "Creating two objects with the same prototype")]
        public void S15_2_4_6_A1()
        {
            RunFile("S15.2.4.6_A1.js");
        }

        [Test(Description = "Checking if varying the Object.prototype.isPrototypeOf.length property fails")]
        public void S15_2_4_6_A10()
        {
            RunFile("S15.2.4.6_A10.js");
        }

        [Test(Description = "Checking the Object.prototype.hasOwnProperty.length")]
        public void S15_2_4_6_A11()
        {
            RunFile("S15.2.4.6_A11.js");
        }

        [Test(Description = "Let O be the result of calling ToObject passing the this value as the argument.")]
        [ExpectedException]
        public void S15_2_4_6_A12()
        {
            RunFile("S15.2.4.6_A12.js");
        }

        [Test(Description = "Let O be the result of calling ToObject passing the this value as the argument.")]
        [ExpectedException]
        public void S15_2_4_6_A13()
        {
            RunFile("S15.2.4.6_A13.js");
        }

        [Test(Description = "Checking if obtaining the prototype property of Object.prototype.isPrototypeOf fails")]
        public void S15_2_4_6_A6()
        {
            RunFile("S15.2.4.6_A6.js");
        }

        [Test(Description = "Checking if creating new \"Object.prototype.isPrototypeOf\" fails")]
        public void S15_2_4_6_A7()
        {
            RunFile("S15.2.4.6_A7.js");
        }

        [Test(Description = "Checknig if enumerating the Object.prototype.isPrototypeOf.length property fails")]
        public void S15_2_4_6_A8()
        {
            RunFile("S15.2.4.6_A8.js");
        }

        [Test(Description = "Checking deleting the Object.prototype.isPrototypeOf.length property fails")]
        public void S15_2_4_6_A9()
        {
            RunFile("S15.2.4.6_A9.js");
        }
    }
}