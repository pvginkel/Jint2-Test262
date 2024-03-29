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
    public class _15_4_3_1Fixture : Test262Fixture
    {
        public _15_4_3_1Fixture()
            : base("ch15\\15.4\\15.4.3\\15.4.3.1")
        {
        }

        [Test(Description = "Checking use hasOwnProperty")]
        public void S15_4_3_1_A1()
        {
            RunFile("S15.4.3.1_A1.js");
        }

        [Test(Description = "Checking if enumerating the Array.prototype property fails")]
        public void S15_4_3_1_A2()
        {
            RunFile("S15.4.3.1_A2.js");
        }

        [Test(Description = "Checking if deleting the Array.prototype property fails")]
        public void S15_4_3_1_A3()
        {
            RunFile("S15.4.3.1_A3.js");
        }

        [Test(Description = "Checking if varying the Array.prototype property fails")]
        public void S15_4_3_1_A4()
        {
            RunFile("S15.4.3.1_A4.js");
        }

        [Test(Description = "Array.prototype.length === 0")]
        public void S15_4_3_1_A5()
        {
            RunFile("S15.4.3.1_A5.js");
        }
    }
}
