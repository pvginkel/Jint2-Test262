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

namespace Jint.Test262.Ch15._15_8._15_8_2
{
    [TestFixture]
    public class _15_8_2_14Fixture : Test262Fixture
    {
        public _15_8_2_14Fixture()
            : base("ch15\\15.8\\15.8.2\\15.8.2.14")
        {
        }

        [Test(Description = "Checking if Math.random() is a number between 0 and 1, calling Math.random() 100 times")]
        public void S15_8_2_14_A1()
        {
            RunFile("S15.8.2.14_A1.js");
        }
    }
}
