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
    public class _8_12_5Fixture : Test262Fixture
    {
        public _8_12_5Fixture()
            : base("ch08\\8.12\\8.12.5")
        {
        }

        [Test(Description = "Changing the value of a data property should not affect it's non-value property descriptor attributes.")]
        public void _8_12_5_3_b_1()
        {
            RunFile("8.12.5-3-b_1.js");
        }

        [Test(Description = "Changing the value of a data property should not affect it's non-value property descriptor attributes.")]
        public void _8_12_5_3_b_2()
        {
            RunFile("8.12.5-3-b_2.js");
        }

        [Test(Description = "Changing the value of an accessor property should not affect it's property descriptor attributes.")]
        public void _8_12_5_5_b_1()
        {
            RunFile("8.12.5-5-b_1.js");
        }

        [Test(Description = "Put to not existent properties")]
        public void S8_12_5_A1()
        {
            RunFile("S8.12.5_A1.js");
        }

        [Test(Description = "Put to existent properties")]
        public void S8_12_5_A2()
        {
            RunFile("S8.12.5_A2.js");
        }
    }
}