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

namespace Jint.Test262.Ch15._15_6._15_6_3
{
    [TestFixture]
    public class _15_6_3_1Fixture : Test262Fixture
    {
        public _15_6_3_1Fixture()
            : base("ch15\\15.6\\15.6.3\\15.6.3.1")
        {
        }

        [Test(Description = "Checking Boolean.prototype property")]
        public void S15_6_3_1_A1()
        {
            RunFile("S15.6.3.1_A1.js");
        }

        [Test(Description = "Checking if varying the Boolean.prototype property fails")]
        public void S15_6_3_1_A2()
        {
            RunFile("S15.6.3.1_A2.js");
        }

        [Test(Description = "Checking if deleting the Boolean.prototype property fails")]
        public void S15_6_3_1_A3()
        {
            RunFile("S15.6.3.1_A3.js");
        }

        [Test(Description = "Checking if enumerating the Boolean.prototype property fails")]
        public void S15_6_3_1_A4()
        {
            RunFile("S15.6.3.1_A4.js");
        }
    }
}
