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

namespace Jint.Test262.Ch15
{
    [TestFixture]
    public class _15_3Fixture : Test262Fixture
    {
        public _15_3Fixture()
            : base("ch15\\15.3")
        {
        }

        [Test(Description = "Create simple functions and check returned values")]
        public void S15_3_1_A1_T1()
        {
            RunFile("S15.3.1_A1_T1.js");
        }

        [Test(Description = "Compare Function with this.Function")]
        public void S15_3_A1()
        {
            RunFile("S15.3_A1.js");
        }

        [Test(Description = "Checking if executing \"Function.call(this, \"var x / = 1;\")\" fails")]
        public void S15_3_A2_T1()
        {
            RunFile("S15.3_A2_T1.js");
        }

        [Test(Description = "Checking if executing \"Function.call(this, \"var #x  = 1;\")\" fails")]
        public void S15_3_A2_T2()
        {
            RunFile("S15.3_A2_T2.js");
        }

        [Test(Description = "First argument is object")]
        public void S15_3_A3_T1()
        {
            RunFile("S15.3_A3_T1.js");
        }

        [Test(Description = "First argument is string and null")]
        public void S15_3_A3_T2()
        {
            RunFile("S15.3_A3_T2.js");
        }

        [Test(Description = "First argument is this, and this don`t have needed variable")]
        public void S15_3_A3_T3()
        {
            RunFile("S15.3_A3_T3.js");
        }

        [Test(Description = "First argument is this, and this have needed variable")]
        public void S15_3_A3_T4()
        {
            RunFile("S15.3_A3_T4.js");
        }

        [Test(Description = "First argument is this, and this don`t have needed variable. Function return this.var_name")]
        public void S15_3_A3_T5()
        {
            RunFile("S15.3_A3_T5.js");
        }

        [Test(Description = "First argument is this, and this have needed variable. Function return this.var_name")]
        public void S15_3_A3_T6()
        {
            RunFile("S15.3_A3_T6.js");
        }
    }
}
