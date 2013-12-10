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

namespace Jint.Test262.Ch08
{
    [TestFixture]
    public class _8_8Fixture : Test262Fixture
    {
        public _8_8Fixture()
            : base("ch08\\8.8")
        {
        }

        [Test(Description = "Call function __mFunc(1,2,3) with 3 arguments")]
        public void S8_8_A2_T1()
        {
            RunFile("S8.8_A2_T1.js");
        }

        [Test(Description = "Call function __mFunc([,,]) with 1 arguments")]
        public void S8_8_A2_T2()
        {
            RunFile("S8.8_A2_T2.js");
        }

        [Test(Description = "Call function, that concatenate all it`s arguments")]
        public void S8_8_A2_T3()
        {
            RunFile("S8.8_A2_T3.js");
        }
    }
}
