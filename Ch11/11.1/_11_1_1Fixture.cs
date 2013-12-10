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

namespace Jint.Test262.Ch11._11_1
{
    [TestFixture]
    public class _11_1_1Fixture : Test262Fixture
    {
        public _11_1_1Fixture()
            : base("ch11\\11.1\\11.1.1")
        {
        }

        [Test(Description = "Strict Mode - 'this' object at the global scope is not undefined")]
        public void _11_1_1_1gs()
        {
            RunFile("11.1.1-1gs.js");
        }

        [Test(Description = "Checking if execution of \"this=1\" fails")]
        [ExpectedException]
        public void S11_1_1_A1()
        {
            RunFile("S11.1.1_A1.js");
        }

        [Test(Description = "Creating function which returns \"this\" or eval(\"this\")")]
        public void S11_1_1_A3_1()
        {
            RunFile("S11.1.1_A3.1.js");
        }

        [Test(Description = "Create function. It have property, that returned \"this\"")]
        public void S11_1_1_A3_2()
        {
            RunFile("S11.1.1_A3.2.js");
        }

        [Test(Description = "Creating function with new Function() constructor")]
        public void S11_1_1_A4_1()
        {
            RunFile("S11.1.1_A4.1.js");
        }

        [Test(Description = "Creating function by using new Function() constructor. It has the property, which returns \"this\"")]
        public void S11_1_1_A4_2()
        {
            RunFile("S11.1.1_A4.2.js");
        }
    }
}
