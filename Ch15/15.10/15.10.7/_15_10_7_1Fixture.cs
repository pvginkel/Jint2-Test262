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

namespace Jint.Test262.Ch15._15_10._15_10_7
{
    [TestFixture]
    public class _15_10_7_1Fixture : Test262Fixture
    {
        public _15_10_7_1Fixture()
            : base("ch15\\15.10\\15.10.7\\15.10.7.1")
        {
        }

        [Test(Description = "RegExp.prototype.source is of type String")]
        public void _15_10_7_1_1()
        {
            RunFile("15.10.7.1-1.js");
        }

        [Test(Description = "RegExp.prototype.source is a data property with default attribute values (false)")]
        public void _15_10_7_1_2()
        {
            RunFile("15.10.7.1-2.js");
        }

        [Test(Description = "Checking if varying the source property fails")]
        public void S15_10_7_1_A10()
        {
            RunFile("S15.10.7.1_A10.js");
        }

        [Test(Description = "Checking if enumerating the source property of RegExp instance fails")]
        public void S15_10_7_1_A8()
        {
            RunFile("S15.10.7.1_A8.js");
        }

        [Test(Description = "Checking if deleting the source property fails")]
        public void S15_10_7_1_A9()
        {
            RunFile("S15.10.7.1_A9.js");
        }
    }
}
