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

namespace Jint.Test262.Intl402.Ch13
{
    [TestFixture]
    public class _13_2Fixture : Test262Fixture
    {
        public _13_2Fixture()
            : base("intl402\\ch13\\13.2")
        {
        }

        [Test(Description = "Tests that toLocaleString handles \"this Number value\" correctly.")]
        public void _13_2_1_1()
        {
            RunFile("13.2.1_1.js");
        }

        [Test(Description = "Tests that Number.prototype.toLocaleString throws the same exceptions as Intl.NumberFormat.")]
        public void _13_2_1_4_1()
        {
            RunFile("13.2.1_4_1.js");
        }

        [Test(Description = "Tests that Number.prototype.toLocaleString uses the standard")]
        public void _13_2_1_4_2()
        {
            RunFile("13.2.1_4_2.js");
        }

        [Test(Description = "Tests that Number.prototype.toLocaleString produces the same results as Intl.NumberFormat.")]
        public void _13_2_1_5()
        {
            RunFile("13.2.1_5.js");
        }

        [Test(Description = "Tests that Number.prototype.toLocaleString")]
        public void _13_2_1_L15()
        {
            RunFile("13.2.1_L15.js");
        }
    }
}