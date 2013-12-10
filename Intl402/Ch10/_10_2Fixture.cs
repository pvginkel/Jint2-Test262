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

namespace Jint.Test262.Intl402.Ch10
{
    [TestFixture]
    public class _10_2Fixture : Test262Fixture
    {
        public _10_2Fixture()
            : base("intl402\\ch10\\10.2")
        {
        }

        [Test(Description = "Tests that Intl.Collator.prototype has the required attributes.")]
        public void _10_2_1()
        {
            RunFile("10.2.1.js");
        }

        [Test(Description = "Tests that Intl.Collator has a supportedLocalesOf")]
        public void _10_2_2_a()
        {
            RunFile("10.2.2_a.js");
        }

        [Test(Description = "Tests that Intl.Collator.supportedLocalesOf")]
        public void _10_2_2_b()
        {
            RunFile("10.2.2_b.js");
        }

        [Test(Description = "Tests that Intl.Collator.supportedLocalesOf")]
        public void _10_2_2_L15()
        {
            RunFile("10.2.2_L15.js");
        }

        [Test(Description = "Tests that Intl.Collator does not accept Unicode locale")]
        public void _10_2_3_b()
        {
            RunFile("10.2.3_b.js");
        }
    }
}
