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

namespace Jint.Test262.Intl402.Ch12
{
    [TestFixture]
    public class _12_1Fixture : Test262Fixture
    {
        public _12_1Fixture()
            : base("intl402\\ch12\\12.1")
        {
        }

        [Test(Description = "Tests that an object can't be re-initialized as a DateTimeFormat.")]
        public void _12_1_1_1()
        {
            RunFile("12.1.1_1.js");
        }

        [Test(Description = "Tests that the option hour12 is processed correctly.")]
        public void _12_1_1_18()
        {
            RunFile("12.1.1_18.js");
        }

        [Test(Description = "Tests that the behavior of a Record is not affected by adversarial")]
        public void _12_1_1_22()
        {
            RunFile("12.1.1_22.js");
        }

        [Test(Description = "Tests that the options for the date and time components are processed correctly.")]
        public void _12_1_1_23()
        {
            RunFile("12.1.1_23.js");
        }

        [Test(Description = "Tests that the option formatMatcher is processed correctly.")]
        public void _12_1_1_25()
        {
            RunFile("12.1.1_25.js");
        }

        [Test(Description = "Tests that the behavior of a Record is not affected by adversarial")]
        public void _12_1_1_5()
        {
            RunFile("12.1.1_5.js");
        }

        [Test(Description = "Tests that the option localeMatcher is processed correctly.")]
        public void _12_1_1_6()
        {
            RunFile("12.1.1_6.js");
        }

        [Test(Description = "Tests that constructing a DateTimeFormat doesn't create or modify")]
        public void _12_1_1_a()
        {
            RunFile("12.1.1_a.js");
        }

        [Test(Description = "Tests that the set of options for the date and time components is processed correctly.")]
        public void _12_1_1_TDTO()
        {
            RunFile("12.1.1_TDTO.js");
        }

        [Test(Description = "Tests that for non-object values passed as this to DateTimeFormat a")]
        public void _12_1_2_1_4()
        {
            RunFile("12.1.2.1_4.js");
        }

        [Test(Description = "Tests that Intl.DateTimeFormat can be subclassed.")]
        public void _12_1_2()
        {
            RunFile("12.1.2.js");
        }

        [Test(Description = "Tests that objects constructed by Intl.DateTimeFormat have the specified internal properties.")]
        public void _12_1_3()
        {
            RunFile("12.1.3.js");
        }

        [Test(Description = "Tests that Intl.DateTimeFormat")]
        public void _12_1_L15()
        {
            RunFile("12.1_L15.js");
        }
    }
}
