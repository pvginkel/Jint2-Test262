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

namespace Jint.Test262.Ch10
{
    [TestFixture]
    public class _10_1Fixture : Test262Fixture
    {
        public _10_1Fixture()
            : base("ch10\\10.1")
        {
        }

        [Test(Description = "Defining function by a FunctionDeclaration")]
        public void S10_1_1_A1_T1()
        {
            RunFile("S10.1.1_A1_T1.js");
        }

        [Test(Description = "Creating function dynamically by using a FunctionExpression")]
        public void S10_1_1_A1_T2()
        {
            RunFile("S10.1.1_A1_T2.js");
        }

        [Test(Description = "Creating function dynamically by using the built-in Function object as a constructor")]
        public void S10_1_1_A1_T3()
        {
            RunFile("S10.1.1_A1_T3.js");
        }

        [Test(Description = "Checking types of parseInt and Math.exp")]
        public void S10_1_1_A2_T1()
        {
            RunFile("S10.1.1_A2_T1.js");
        }

        [Test(Description = "Checking if deleting function parameter is possible")]
        public void S10_1_6_A1_T1()
        {
            RunFile("S10.1.6_A1_T1.js");
        }

        [Test(Description = "Checking funtion which returns property \"arguments\"")]
        public void S10_1_6_A1_T2()
        {
            RunFile("S10.1.6_A1_T2.js");
        }

        [Test(Description = "Checking function which returns \"this\"")]
        public void S10_1_6_A1_T3()
        {
            RunFile("S10.1.6_A1_T3.js");
        }

        [Test(Description = "Checking if deleting \"this\" fails")]
        public void S10_1_7_A1_T1()
        {
            RunFile("S10.1.7_A1_T1.js");
        }
    }
}
