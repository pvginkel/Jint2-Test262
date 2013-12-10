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

namespace Jint.Test262.Ch08._8_12
{
    [TestFixture]
    public class _8_12_3Fixture : Test262Fixture
    {
        public _8_12_3Fixture()
            : base("ch08\\8.12\\8.12.3")
        {
        }

        [Test(Description = "Try to get P when property P does not exist in instance but prototype contain it")]
        public void S8_12_3_A1()
        {
            RunFile("S8.12.3_A1.js");
        }

        [Test(Description = "Try to get P when property P does not exist both in instance and prototype")]
        public void S8_12_3_A2()
        {
            RunFile("S8.12.3_A2.js");
        }

        [Test(Description = "Try to get P property P exist in instance")]
        public void S8_12_3_A3()
        {
            RunFile("S8.12.3_A3.js");
        }
    }
}