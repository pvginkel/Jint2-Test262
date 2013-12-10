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

namespace Jint.Test262.Intl402.Ch11
{
    [TestFixture]
    public class _11_3Fixture : Test262Fixture
    {
        public _11_3Fixture()
            : base("intl402\\ch11\\11.3")
        {
        }

        [Test(Description = "Tests that Intl.NumberFormat.prototype.constructor is the")]
        public void _11_3_1()
        {
            RunFile("11.3.1.js");
        }

        [Test(Description = "Tests that Intl.NumberFormat.prototype.format")]
        public void _11_3_2_1_a_ii()
        {
            RunFile("11.3.2_1_a_ii.js");
        }

        [Test(Description = "Tests that the function returned by Intl.NumberFormat.prototype.format")]
        public void _11_3_2_1_a_L15()
        {
            RunFile("11.3.2_1_a_L15.js");
        }

        [Test(Description = "Tests that format function is bound to its Intl.NumberFormat.")]
        public void _11_3_2_1_c()
        {
            RunFile("11.3.2_1_c.js");
        }

        [Test(Description = "Tests that Intl.NumberFormat.prototype.format")]
        public void _11_3_2_FN_1()
        {
            RunFile("11.3.2_FN_1.js");
        }

        [Test(Description = "Tests that Intl.NumberFormat.prototype.format")]
        public void _11_3_2_FN_2()
        {
            RunFile("11.3.2_FN_2.js");
        }

        [Test(Description = "Tests that Intl.NumberFormat.prototype.format")]
        public void _11_3_2_FN_3_b()
        {
            RunFile("11.3.2_FN_3_b.js");
        }

        [Test(Description = "Tests that Intl.NumberFormat.prototype.format")]
        public void _11_3_2_FN_3_e()
        {
            RunFile("11.3.2_FN_3_e.js");
        }

        [Test(Description = "Tests that the getter for Intl.NumberFormat.prototype.format")]
        public void _11_3_2_L15()
        {
            RunFile("11.3.2_L15.js");
        }

        [Test(Description = "Tests that the digits are determined correctly when specifying pre/post decimal digits.")]
        public void _11_3_2_TRF()
        {
            RunFile("11.3.2_TRF.js");
        }

        [Test(Description = "Tests that the digits are determined correctly when specifying significant digits.")]
        public void _11_3_2_TRP()
        {
            RunFile("11.3.2_TRP.js");
        }

        [Test(Description = "Tests that the object returned by Intl.NumberFormat.prototype.resolvedOptions")]
        public void _11_3_3()
        {
            RunFile("11.3.3.js");
        }

        [Test(Description = "Tests that Intl.NumberFormat.prototype.resolvedOptions")]
        public void _11_3_3_L15()
        {
            RunFile("11.3.3_L15.js");
        }

        [Test(Description = "Tests that Intl.NumberFormat.prototype is an object that")]
        public void _11_3_a()
        {
            RunFile("11.3_a.js");
        }

        [Test(Description = "Tests that Intl.NumberFormat.prototype functions throw a")]
        public void _11_3_b()
        {
            RunFile("11.3_b.js");
        }

        [Test(Description = "Tests that Intl.NumberFormat.prototype")]
        public void _11_3_L15()
        {
            RunFile("11.3_L15.js");
        }
    }
}