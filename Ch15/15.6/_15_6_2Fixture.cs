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

namespace Jint.Test262.Ch15._15_6
{
    [TestFixture]
    public class _15_6_2Fixture : Test262Fixture
    {
        public _15_6_2Fixture()
            : base("ch15\\15.6\\15.6.2")
        {
        }

        [Test(Description = "Checking type of the newly created object and it value")]
        public void S15_6_2_1_A1()
        {
            RunFile("S15.6.2.1_A1.js");
        }

        [Test(Description = "Checking prototype property of the newly created object")]
        public void S15_6_2_1_A2()
        {
            RunFile("S15.6.2.1_A2.js");
        }

        [Test(Description = "Checking value of the newly created object")]
        public void S15_6_2_1_A3()
        {
            RunFile("S15.6.2.1_A3.js");
        }

        [Test(Description = "For testing toString function is used")]
        public void S15_6_2_1_A4()
        {
            RunFile("S15.6.2.1_A4.js");
        }
    }
}
