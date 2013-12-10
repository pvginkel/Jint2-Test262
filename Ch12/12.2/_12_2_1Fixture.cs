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

namespace Jint.Test262.Ch12._12_2
{
    [TestFixture]
    public class _12_2_1Fixture : Test262Fixture
    {
        public _12_2_1Fixture()
            : base("ch12\\12.2\\12.2.1")
        {
        }

        [Test(Description = "eval - a function declaring a var named 'eval' throws SyntaxError in strict mode")]
        public void _12_2_1_1_s()
        {
            RunFile("12.2.1-1-s.js");
        }

        [Test(Description = "Strict Mode: an indirect eval assigning into 'eval' does not throw")]
        public void _12_2_1_10_s()
        {
            RunFile("12.2.1-10-s.js");
        }

        [Test(Description = "arguments as var identifier in eval code is allowed")]
        public void _12_2_1_11()
        {
            RunFile("12.2.1-11.js");
        }

        [Test(Description = "arguments as local var identifier throws SyntaxError in strict mode")]
        public void _12_2_1_12_s()
        {
            RunFile("12.2.1-12-s.js");
        }

        [Test(Description = "arguments as local var identifier is allowed")]
        public void _12_2_1_12()
        {
            RunFile("12.2.1-12.js");
        }

        [Test(Description = "arguments assignment throws SyntaxError in strict mode")]
        public void _12_2_1_13_s()
        {
            RunFile("12.2.1-13-s.js");
        }

        [Test(Description = "arguments - a function expr declaring a var named 'arguments' throws SyntaxError in strict mode")]
        public void _12_2_1_14_s()
        {
            RunFile("12.2.1-14-s.js");
        }

        [Test(Description = "arguments - a function expr assigning into 'arguments' throws a SyntaxError in strict mode")]
        public void _12_2_1_15_s()
        {
            RunFile("12.2.1-15-s.js");
        }

        [Test(Description = "A Function constructor (called as a function) declaring a var named 'arguments' does not throw a SyntaxError in strict mode")]
        public void _12_2_1_16_s()
        {
            RunFile("12.2.1-16-s.js");
        }

        [Test(Description = "A Function constructor (called as a function) assigning into 'arguments' will not throw any error if contained within strict mode and its body does not start with strict mode")]
        public void _12_2_1_17_s()
        {
            RunFile("12.2.1-17-s.js");
        }

        [Test(Description = "A direct eval declaring a var named 'arguments' throws SyntaxError in strict mode")]
        public void _12_2_1_18_s()
        {
            RunFile("12.2.1-18-s.js");
        }

        [Test(Description = "A direct eval assigning into 'arguments' throws SyntaxError in strict mode")]
        public void _12_2_1_19_s()
        {
            RunFile("12.2.1-19-s.js");
        }

        [Test(Description = "Strict Mode - SyntaxError is thrown if a VariableDeclaration occurs within strict code and its Identifier is eval")]
        [ExpectedException]
        public void _12_2_1_1gs()
        {
            RunFile("12.2.1-1gs.js");
        }

        [Test(Description = "eval - a function assigning into 'eval' throws SyntaxError in strict mode")]
        public void _12_2_1_2_s()
        {
            RunFile("12.2.1-2-s.js");
        }

        [Test(Description = "Strict Mode: an indirect eval declaring a var named 'arguments' does not throw")]
        public void _12_2_1_20_s()
        {
            RunFile("12.2.1-20-s.js");
        }

        [Test(Description = "Strict Mode: an indirect eval assigning into 'arguments' does not throw")]
        public void _12_2_1_21_s()
        {
            RunFile("12.2.1-21-s.js");
        }

        [Test(Description = "arguments as global var identifier throws SyntaxError in strict mode")]
        public void _12_2_1_22_s()
        {
            RunFile("12.2.1-22-s.js");
        }

        [Test(Description = "arguments as local var identifier assigned to throws SyntaxError in strict mode")]
        public void _12_2_1_23_s()
        {
            RunFile("12.2.1-23-s.js");
        }

        [Test(Description = "eval as local var identifier assigned to throws SyntaxError in strict mode")]
        public void _12_2_1_24_s()
        {
            RunFile("12.2.1-24-s.js");
        }

        [Test(Description = "arguments as local var identifier throws SyntaxError in strict mode")]
        public void _12_2_1_25_s()
        {
            RunFile("12.2.1-25-s.js");
        }

        [Test(Description = "eval as local var identifier throws SyntaxError in strict mode")]
        public void _12_2_1_26_s()
        {
            RunFile("12.2.1-26-s.js");
        }

        [Test(Description = "eval as local var identifier assigned to throws SyntaxError in strict mode")]
        public void _12_2_1_27_s()
        {
            RunFile("12.2.1-27-s.js");
        }

        [Test(Description = "arguments as local var identifier assigned to throws SyntaxError in strict mode")]
        public void _12_2_1_28_s()
        {
            RunFile("12.2.1-28-s.js");
        }

        [Test(Description = "eval as local var identifier throws SyntaxError in strict mode")]
        public void _12_2_1_29_s()
        {
            RunFile("12.2.1-29-s.js");
        }

        [Test(Description = "eval - a function expr declaring a var named 'eval' throws SyntaxError in strict mode")]
        public void _12_2_1_3_s()
        {
            RunFile("12.2.1-3-s.js");
        }

        [Test(Description = "arguments as local var identifier throws SyntaxError in strict mode")]
        public void _12_2_1_30_s()
        {
            RunFile("12.2.1-30-s.js");
        }

        [Test(Description = "eval as local var identifier defined twice throws SyntaxError in strict mode")]
        public void _12_2_1_31_s()
        {
            RunFile("12.2.1-31-s.js");
        }

        [Test(Description = "arguments as local var identifier defined twice and assigned once throws SyntaxError in strict mode")]
        public void _12_2_1_32_s()
        {
            RunFile("12.2.1-32-s.js");
        }

        [Test(Description = "arguments as local var identifier throws SyntaxError in strict mode")]
        public void _12_2_1_33_s()
        {
            RunFile("12.2.1-33-s.js");
        }

        [Test(Description = "'for(var eval in ...) {...}' throws SyntaxError in strict mode")]
        public void _12_2_1_34_s()
        {
            RunFile("12.2.1-34-s.js");
        }

        [Test(Description = "'for(var eval = 42 in ...) {...}' throws SyntaxError in strict mode")]
        public void _12_2_1_35_s()
        {
            RunFile("12.2.1-35-s.js");
        }

        [Test(Description = "'for(var arguments in ...) {...}' throws SyntaxError in strict mode")]
        public void _12_2_1_36_s()
        {
            RunFile("12.2.1-36-s.js");
        }

        [Test(Description = "'for(var arguments = 42 in ...) {...}' throws SyntaxError in strict mode")]
        public void _12_2_1_37_s()
        {
            RunFile("12.2.1-37-s.js");
        }

        [Test(Description = "eval - a function expr assigning into 'eval' throws a SyntaxError in strict mode")]
        public void _12_2_1_4_s()
        {
            RunFile("12.2.1-4-s.js");
        }

        [Test(Description = "Strict Mode - SyntaxError is thrown if a VariableDeclarationNoIn occurs within strict code and its Identifier is arguments")]
        [ExpectedException]
        public void _12_2_1_4gs()
        {
            RunFile("12.2.1-4gs.js");
        }

        [Test(Description = "Strict Mode - a Function declaring var named 'eval' does not throw SyntaxError")]
        public void _12_2_1_5_s()
        {
            RunFile("12.2.1-5-s.js");
        }

        [Test(Description = "eval - a Function assigning into 'eval' will not throw any error if contained within strict mode and its body does not start with strict mode")]
        public void _12_2_1_6_s()
        {
            RunFile("12.2.1-6-s.js");
        }

        [Test(Description = "eval - a direct eval declaring a var named 'eval' throws SyntaxError in strict mode")]
        public void _12_2_1_7_s()
        {
            RunFile("12.2.1-7-s.js");
        }

        [Test(Description = "eval - a direct eval assigning into 'eval' throws SyntaxError in strict mode")]
        public void _12_2_1_8_s()
        {
            RunFile("12.2.1-8-s.js");
        }

        [Test(Description = "Strict Mode: an indirect eval declaring a var named 'eval' does not throw")]
        public void _12_2_1_9_s()
        {
            RunFile("12.2.1-9-s.js");
        }
    }
}