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

namespace Jint.Test262.Ch12
{
    [TestFixture]
    public class _12_13Fixture : Test262Fixture
    {
        public _12_13Fixture()
            : base("ch12\\12.13")
        {
        }

        [Test(Description = "Trying to throw exception with \"throw\"")]
        [ExpectedException]
        public void S12_13_A1()
        {
            RunFile("S12.13_A1.js");
        }

        [Test(Description = "Throwing undefined")]
        public void S12_13_A2_T1()
        {
            RunFile("S12.13_A2_T1.js");
        }

        [Test(Description = "Throwing null")]
        public void S12_13_A2_T2()
        {
            RunFile("S12.13_A2_T2.js");
        }

        [Test(Description = "Throwing boolean")]
        public void S12_13_A2_T3()
        {
            RunFile("S12.13_A2_T3.js");
        }

        [Test(Description = "Throwing string")]
        public void S12_13_A2_T4()
        {
            RunFile("S12.13_A2_T4.js");
        }

        [Test(Description = "Throwing number")]
        public void S12_13_A2_T5()
        {
            RunFile("S12.13_A2_T5.js");
        }

        [Test(Description = "Throwing object")]
        public void S12_13_A2_T6()
        {
            RunFile("S12.13_A2_T6.js");
        }

        [Test(Description = "Throwing Array")]
        public void S12_13_A2_T7()
        {
            RunFile("S12.13_A2_T7.js");
        }

        [Test(Description = "Evaluating boolean expression")]
        public void S12_13_A3_T1()
        {
            RunFile("S12.13_A3_T1.js");
        }

        [Test(Description = "Evaluating string expression")]
        public void S12_13_A3_T2()
        {
            RunFile("S12.13_A3_T2.js");
        }

        [Test(Description = "Evaluating number expression")]
        public void S12_13_A3_T3()
        {
            RunFile("S12.13_A3_T3.js");
        }

        [Test(Description = "Evaluating array expression")]
        public void S12_13_A3_T4()
        {
            RunFile("S12.13_A3_T4.js");
        }

        [Test(Description = "Evaluating equation expression")]
        public void S12_13_A3_T5()
        {
            RunFile("S12.13_A3_T5.js");
        }

        [Test(Description = "Evaluating functions")]
        public void S12_13_A3_T6()
        {
            RunFile("S12.13_A3_T6.js");
        }
    }
}