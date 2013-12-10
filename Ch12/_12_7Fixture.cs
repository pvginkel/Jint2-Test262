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
    public class _12_7Fixture : Test262Fixture
    {
        public _12_7Fixture()
            : base("ch12\\12.7")
        {
        }

        [Test(Description = "The continue Statement - a continue statement without an identifier may have a LineTerminator before the semi-colon")]
        public void _12_7_1()
        {
            RunFile("12.7-1.js");
        }

        [Test(Description = "Checking if execution of single \"continue\" without any IterationStatement fails")]
        [ExpectedException]
        public void S12_7_A1_T1()
        {
            RunFile("S12.7_A1_T1.js");
        }

        [Test(Description = "Checking if single \"continue\" with Label but without any IterationStatement fails")]
        [ExpectedException]
        public void S12_7_A1_T2()
        {
            RunFile("S12.7_A1_T2.js");
        }

        [Test(Description = "Checking if laballed \"continue\" with no IterationStatement, placed into a block, fails")]
        [ExpectedException]
        public void S12_7_A1_T3()
        {
            RunFile("S12.7_A1_T3.js");
        }

        [Test(Description = "Checking if execution of \"continue\" with no IterationStatement, placed into a block, fails")]
        [ExpectedException]
        public void S12_7_A1_T4()
        {
            RunFile("S12.7_A1_T4.js");
        }

        [Test(Description = "Checking by using eval, inserting LineTerminator between continue and Identifier")]
        public void S12_7_A2()
        {
            RunFile("S12.7_A2.js");
        }

        [Test(Description = "Trying to continue another labeled loop")]
        [ExpectedException]
        public void S12_7_A5_T1()
        {
            RunFile("S12.7_A5_T1.js");
        }

        [Test(Description = "Identifier is a function name")]
        [ExpectedException]
        public void S12_7_A5_T2()
        {
            RunFile("S12.7_A5_T2.js");
        }

        [Test(Description = "Identifier is within loop label")]
        [ExpectedException]
        public void S12_7_A5_T3()
        {
            RunFile("S12.7_A5_T3.js");
        }

        [Test(Description = "Using labaled \"continue Identifier\" within a function body")]
        [ExpectedException]
        public void S12_7_A6()
        {
            RunFile("S12.7_A6.js");
        }

        [Test(Description = "Using eval \"eval(\"continue LABEL1\")\"")]
        public void S12_7_A7()
        {
            RunFile("S12.7_A7.js");
        }

        [Test(Description = "Checking if execution of \"continue Identifier\" within catch Block fails")]
        [ExpectedException]
        public void S12_7_A8_T1()
        {
            RunFile("S12.7_A8_T1.js");
        }

        [Test(Description = "Checking if execution of \"continue\" within catch Block fails")]
        [ExpectedException]
        public void S12_7_A8_T2()
        {
            RunFile("S12.7_A8_T2.js");
        }

        [Test(Description = "Using \"continue Identifier\" within catch Block that is within a loop")]
        public void S12_7_A9_T1()
        {
            RunFile("S12.7_A9_T1.js");
        }

        [Test(Description = "Using \"continue\" within catch Block that is within a loop")]
        public void S12_7_A9_T2()
        {
            RunFile("S12.7_A9_T2.js");
        }
    }
}