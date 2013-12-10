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

namespace Jint.Test262.Ch09
{
    [TestFixture]
    public class _9_1Fixture : Test262Fixture
    {
        public _9_1Fixture()
            : base("ch09\\9.1")
        {
        }

        [Test(Description = "Using operator Number. The operator calls ToPrimitive with hint Number")]
        public void S9_1_A1_T1()
        {
            RunFile("S9.1_A1_T1.js");
        }

        [Test(Description = "Using operator Number. This operator calls ToPrimitive with hint Number")]
        public void S9_1_A1_T2()
        {
            RunFile("S9.1_A1_T2.js");
        }

        [Test(Description = "Using operator \"+\". This operator firstly calls ToPrimitive and then calls ToString or ToNumber")]
        public void S9_1_A1_T3()
        {
            RunFile("S9.1_A1_T3.js");
        }

        [Test(Description = "Using operator \"<\". The operator firstly calls ToPrimitive and then calls ToString or ToNumber")]
        public void S9_1_A1_T4()
        {
            RunFile("S9.1_A1_T4.js");
        }
    }
}