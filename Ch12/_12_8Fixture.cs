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
    public class _12_8Fixture : Test262Fixture
    {
        public _12_8Fixture()
            : base("ch12\\12.8")
        {
        }

        [Test(Description = "The break Statement - a break statement without an identifier may have a LineTerminator before the semi-colon")]
        public void _12_8_1()
        {
            RunFile("12.8-1.js");
        }

        [Test(Description = "Checking if break statement with no loop fails")]
        [ExpectedException]
        public void S12_8_A1_T1()
        {
            RunFile("S12.8_A1_T1.js");
        }

        [Test(Description = "Checking if break Identifier with no loop fails")]
        [ExpectedException]
        public void S12_8_A1_T2()
        {
            RunFile("S12.8_A1_T2.js");
        }

        [Test(Description = "Checking if break statement with no loop, placed into a block, fails")]
        [ExpectedException]
        public void S12_8_A1_T3()
        {
            RunFile("S12.8_A1_T3.js");
        }

        [Test(Description = "Checking if break Identifier with no loop, placed into a  block, fails")]
        [ExpectedException]
        public void S12_8_A1_T4()
        {
            RunFile("S12.8_A1_T4.js");
        }

        [Test(Description = "Checking by using eval, inserting LineTerminator between break and Identifier")]
        public void S12_8_A2()
        {
            RunFile("S12.8_A2.js");
        }

        [Test(Description = "Using \"break\" without Identifier within labeled loop")]
        public void S12_8_A3()
        {
            RunFile("S12.8_A3.js");
        }

        [Test(Description = "Using \"break Identifier\" within labaeled loop")]
        public void S12_8_A4_T1()
        {
            RunFile("S12.8_A4_T1.js");
        }

        [Test(Description = "Using embedded and labeled loops, breaking to nested loop")]
        public void S12_8_A4_T2()
        {
            RunFile("S12.8_A4_T2.js");
        }

        [Test(Description = "Using embedded and labeled loops, breaking to outer loop")]
        public void S12_8_A4_T3()
        {
            RunFile("S12.8_A4_T3.js");
        }

        [Test(Description = "Checking if breaking another labeled loop fails")]
        [ExpectedException]
        public void S12_8_A5_T1()
        {
            RunFile("S12.8_A5_T1.js");
        }

        [Test(Description = "Checking if using function name as an Identifier appears to be invalid")]
        [ExpectedException]
        public void S12_8_A5_T2()
        {
            RunFile("S12.8_A5_T2.js");
        }

        [Test(Description = "Checking if using internal loop label as an Identifier appears to be invalid")]
        [ExpectedException]
        public void S12_8_A5_T3()
        {
            RunFile("S12.8_A5_T3.js");
        }

        [Test(Description = "Checking if using \"break Identifier\" within a function body appears to be invalid")]
        [ExpectedException]
        public void S12_8_A6()
        {
            RunFile("S12.8_A6.js");
        }

        [Test(Description = "Using eval \"eval(\"break LABEL1\")\"")]
        public void S12_8_A7()
        {
            RunFile("S12.8_A7.js");
        }

        [Test(Description = "Checking if using \"break Identifier\" from within catch Block appears to be invalid")]
        [ExpectedException]
        public void S12_8_A8_T1()
        {
            RunFile("S12.8_A8_T1.js");
        }

        [Test(Description = "Checking if using \"break Identifier\" from within catch Block appears to be invalid")]
        [ExpectedException]
        public void S12_8_A8_T2()
        {
            RunFile("S12.8_A8_T2.js");
        }

        [Test(Description = "Using \"continue Identifier\" within \"catch\" statement")]
        public void S12_8_A9_T1()
        {
            RunFile("S12.8_A9_T1.js");
        }

        [Test(Description = "Using \"continue Identifier\" within \"catch\" statement")]
        public void S12_8_A9_T2()
        {
            RunFile("S12.8_A9_T2.js");
        }
    }
}
