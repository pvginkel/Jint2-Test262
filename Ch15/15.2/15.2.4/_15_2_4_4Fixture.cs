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
    public class _15_2_4_4Fixture : Test262Fixture
    {
        public _15_2_4_4Fixture()
            : base("ch15\\15.2\\15.2.4\\15.2.4.4")
        {
        }

        [Test(Description = "Object.prototype.valueOf - typeof Object.prototype.valueOf.call(true)===\"object\"")]
        public void _15_2_4_4_1()
        {
            RunFile("15.2.4.4-1.js");
        }

        [Test(Description = "Object.prototype.valueOf - typeof Object.prototype.valueOf.call(false)===\"object\"")]
        public void _15_2_4_4_2()
        {
            RunFile("15.2.4.4-2.js");
        }

        [Test(Description = "Checking if varying the Object.prototype.valueOf.length property fails")]
        public void S15_2_4_4_A10()
        {
            RunFile("S15.2.4.4_A10.js");
        }

        [Test(Description = "Checking the Object.prototype.valueOf.length")]
        public void S15_2_4_4_A11()
        {
            RunFile("S15.2.4.4_A11.js");
        }

        [Test(Description = "Checking Object.prototype.valueOf invoked by the 'call' property.")]
        [ExpectedException]
        public void S15_2_4_4_A12()
        {
            RunFile("S15.2.4.4_A12.js");
        }

        [Test(Description = "Checking Object.prototype.valueOf invoked by the 'call' property.")]
        [ExpectedException]
        public void S15_2_4_4_A13()
        {
            RunFile("S15.2.4.4_A13.js");
        }

        [Test(Description = "Checking Object.prototype.valueOf invoked by the 'call' property.")]
        [ExpectedException]
        public void S15_2_4_4_A14()
        {
            RunFile("S15.2.4.4_A14.js");
        }

        [Test(Description = "Checking Object.prototype.valueOf when called as a global function.")]
        [ExpectedException]
        public void S15_2_4_4_A15()
        {
            RunFile("S15.2.4.4_A15.js");
        }

        [Test(Description = "\"this\" value is a number")]
        public void S15_2_4_4_A1_T1()
        {
            RunFile("S15.2.4.4_A1_T1.js");
        }

        [Test(Description = "\"this\" value is a boolean")]
        public void S15_2_4_4_A1_T2()
        {
            RunFile("S15.2.4.4_A1_T2.js");
        }

        [Test(Description = "\"this\" value is a string")]
        public void S15_2_4_4_A1_T3()
        {
            RunFile("S15.2.4.4_A1_T3.js");
        }

        [Test(Description = "\"this\" value is an object")]
        public void S15_2_4_4_A1_T4()
        {
            RunFile("S15.2.4.4_A1_T4.js");
        }

        [Test(Description = "\"this\" value is \"null\"")]
        public void S15_2_4_4_A1_T5()
        {
            RunFile("S15.2.4.4_A1_T5.js");
        }

        [Test(Description = "\"this\" value is \"undefined\"")]
        public void S15_2_4_4_A1_T6()
        {
            RunFile("S15.2.4.4_A1_T6.js");
        }

        [Test(Description = "\"this\" value is \"void 0\"")]
        public void S15_2_4_4_A1_T7()
        {
            RunFile("S15.2.4.4_A1_T7.js");
        }

        [Test(Description = "Checking if obtaining the prototype property of Object.prototype.valueOf fails")]
        public void S15_2_4_4_A6()
        {
            RunFile("S15.2.4.4_A6.js");
        }

        [Test(Description = "Checking if creating \"new Object.prototype.valueOf\" fails")]
        public void S15_2_4_4_A7()
        {
            RunFile("S15.2.4.4_A7.js");
        }

        [Test(Description = "Checking if enumerating the Object.prototype.valueOf.length property fails")]
        public void S15_2_4_4_A8()
        {
            RunFile("S15.2.4.4_A8.js");
        }

        [Test(Description = "Checknig if deleting of the Object.prototype.valueOf.length property fails")]
        public void S15_2_4_4_A9()
        {
            RunFile("S15.2.4.4_A9.js");
        }
    }
}
