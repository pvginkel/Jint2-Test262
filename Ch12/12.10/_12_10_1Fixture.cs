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

namespace Jint.Test262.Ch12._12_10
{
    [TestFixture]
    public class _12_10_1Fixture : Test262Fixture
    {
        public _12_10_1Fixture()
            : base("ch12\\12.10\\12.10.1")
        {
        }

        [Test(Description = "with statement in strict mode throws SyntaxError (strict function)")]
        public void _12_10_1_1_s()
        {
            RunFile("12.10.1-1-s.js");
        }

        [Test(Description = "with statement in strict mode throws SyntaxError (eval, where the container function is strict)")]
        public void _12_10_1_10_s()
        {
            RunFile("12.10.1-10-s.js");
        }

        [Test(Description = "Strict Mode - SyntaxError is thrown when using WithStatement in strict mode code")]
        public void _12_10_1_11_s()
        {
            RunFile("12.10.1-11-s.js");
        }

        [Test(Description = "Strict Mode - SyntaxError is thrown when using with statement")]
        [ExpectedException]
        public void _12_10_1_11gs()
        {
            RunFile("12.10.1-11gs.js");
        }

        [Test(Description = "with statement in strict mode throws SyntaxError (strict eval)")]
        public void _12_10_1_12_s()
        {
            RunFile("12.10.1-12-s.js");
        }

        [Test(Description = "Strict Mode - SyntaxError isn't thrown when WithStatement body is in strict mode code")]
        public void _12_10_1_13_s()
        {
            RunFile("12.10.1-13-s.js");
        }

        [Test(Description = "Strict Mode - SyntaxError is thrown when the getter of a literal object utilizes WithStatement")]
        public void _12_10_1_14_s()
        {
            RunFile("12.10.1-14-s.js");
        }

        [Test(Description = "Strict Mode - SyntaxError is thrown when the RHS of a dot property assignment utilizes WithStatement")]
        public void _12_10_1_15_s()
        {
            RunFile("12.10.1-15-s.js");
        }

        [Test(Description = "Strict Mode - SyntaxError is thrown when the RHS of an object indexer assignment utilizes WithStatement")]
        public void _12_10_1_16_s()
        {
            RunFile("12.10.1-16-s.js");
        }

        [Test(Description = "with statement in strict mode throws SyntaxError (nested function where container is strict)")]
        public void _12_10_1_2_s()
        {
            RunFile("12.10.1-2-s.js");
        }

        [Test(Description = "with statement in strict mode throws SyntaxError (nested strict function)")]
        public void _12_10_1_3_s()
        {
            RunFile("12.10.1-3-s.js");
        }

        [Test(Description = "with statement in strict mode throws SyntaxError (strict Function)")]
        public void _12_10_1_4_s()
        {
            RunFile("12.10.1-4-s.js");
        }

        [Test(Description = "with statement allowed in nested Function even if its container Function is strict)")]
        public void _12_10_1_5_s()
        {
            RunFile("12.10.1-5-s.js");
        }

        [Test(Description = "with statement in strict mode throws SyntaxError (function expression, where the container function is directly evaled from strict code)")]
        public void _12_10_1_7_s()
        {
            RunFile("12.10.1-7-s.js");
        }

        [Test(Description = "with statement in strict mode throws SyntaxError (function expression, where the container Function is strict)")]
        public void _12_10_1_8_s()
        {
            RunFile("12.10.1-8-s.js");
        }

        [Test(Description = "with statement in strict mode throws SyntaxError (strict function expression)")]
        public void _12_10_1_9_s()
        {
            RunFile("12.10.1-9-s.js");
        }
    }
}