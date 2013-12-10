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

namespace Jint.Test262.Ch08._8_6
{
    [TestFixture]
    public class _8_6_2Fixture : Test262Fixture
    {
        public _8_6_2Fixture()
            : base("ch08\\8.6\\8.6.2")
        {
        }

        [Test(Description = "Check [[Prototype]] property of object")]
        public void S8_6_2_A1()
        {
            RunFile("S8.6.2_A1.js");
        }

        [Test(Description = "Check visibility properties of the child object for the purposes of get access, but not for put access")]
        public void S8_6_2_A2()
        {
            RunFile("S8.6.2_A2.js");
        }

        [Test(Description = "Get [[class]] value except through Object.prototype.toString")]
        public void S8_6_2_A3()
        {
            RunFile("S8.6.2_A3.js");
        }

        [Test(Description = "Check that the obj instance of Object, but not instance")]
        public void S8_6_2_A4()
        {
            RunFile("S8.6.2_A4.js");
        }

        [Test(Description = "Call function-property of object, property defined")]
        public void S8_6_2_A5_T1()
        {
            RunFile("S8.6.2_A5_T1.js");
        }

        [Test(Description = "Call function-property of object, property defined")]
        public void S8_6_2_A5_T2()
        {
            RunFile("S8.6.2_A5_T2.js");
        }

        [Test(Description = "Call function-property of global object, property defined")]
        public void S8_6_2_A5_T3()
        {
            RunFile("S8.6.2_A5_T3.js");
        }

        [Test(Description = "Call function-property of global object, property defined")]
        public void S8_6_2_A5_T4()
        {
            RunFile("S8.6.2_A5_T4.js");
        }

        [Test(Description = "Create a few Objects via the new operator")]
        public void S8_6_2_A6()
        {
            RunFile("S8.6.2_A6.js");
        }

        [Test(Description = "Checking if execution of \"var objMath=new Math\" passes")]
        [ExpectedException]
        public void S8_6_2_A7()
        {
            RunFile("S8.6.2_A7.js");
        }

        [Test(Description = "It should not be possible to change the [[Prototype]]")]
        public void S8_6_2_A8()
        {
            RunFile("S8.6.2_A8.js");
        }
    }
}
