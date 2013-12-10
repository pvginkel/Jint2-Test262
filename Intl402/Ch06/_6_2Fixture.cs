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

namespace Jint.Test262.Intl402.Ch06
{
    [TestFixture]
    public class _6_2Fixture : Test262Fixture
    {
        public _6_2Fixture()
            : base("intl402\\ch06\\6.2")
        {
        }

        [Test(Description = "Tests that structurally valid language tags are accepted.")]
        public void _6_2_2_a()
        {
            RunFile("6.2.2_a.js");
        }

        [Test(Description = "Tests that language tags with \"_\" are not accepted.")]
        public void _6_2_2_b()
        {
            RunFile("6.2.2_b.js");
        }

        [Test(Description = "Tests that language tags with invalid subtag sequences are not accepted.")]
        public void _6_2_2_c()
        {
            RunFile("6.2.2_c.js");
        }

        [Test(Description = "Tests that language tags are canonicalized in return values.")]
        public void _6_2_3()
        {
            RunFile("6.2.3.js");
        }

        [Test(Description = "Tests that the default locale is a String value representing the")]
        public void _6_2_4()
        {
            RunFile("6.2.4.js");
        }
    }
}