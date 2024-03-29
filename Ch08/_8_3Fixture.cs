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

namespace Jint.Test262.Ch08
{
    [TestFixture]
    public class _8_3Fixture : Test262Fixture
    {
        public _8_3Fixture()
            : base("ch08\\8.3")
        {
        }

        [Test(Description = "Assign true and false to variables")]
        public void S8_3_A1_T1()
        {
            RunFile("S8.3_A1_T1.js");
        }

        [Test(Description = "Check type of true/false and it`s equality")]
        public void S8_3_A1_T2()
        {
            RunFile("S8.3_A1_T2.js");
        }

        [Test(Description = "Checking if execution of \"true=1\" fails")]
        [ExpectedException]
        public void S8_3_A2_1()
        {
            RunFile("S8.3_A2.1.js");
        }

        [Test(Description = "Checking if execution of \"false=0\" fails")]
        [ExpectedException]
        public void S8_3_A2_2()
        {
            RunFile("S8.3_A2.2.js");
        }

        [Test(Description = "Check not false equals true, not true equals false")]
        public void S8_3_A3()
        {
            RunFile("S8.3_A3.js");
        }
    }
}
