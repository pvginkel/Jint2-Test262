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

namespace Jint.Test262.Ch11
{
    [TestFixture]
    public class _11_14Fixture : Test262Fixture
    {
        public _11_14Fixture()
            : base("ch11\\11.14")
        {
        }

        [Test(Description = "Checking by using eval")]
        public void S11_14_A1()
        {
            RunFile("S11.14_A1.js");
        }

        [Test(Description = "Either Expression is not Reference or GetBase is not null")]
        public void S11_14_A2_1_T1()
        {
            RunFile("S11.14_A2.1_T1.js");
        }

        [Test(Description = "If GetBase(Expression) is null, throw ReferenceError")]
        public void S11_14_A2_1_T2()
        {
            RunFile("S11.14_A2.1_T2.js");
        }

        [Test(Description = "If GetBase(AssigmentExpression) is null, throw ReferenceError")]
        public void S11_14_A2_1_T3()
        {
            RunFile("S11.14_A2.1_T3.js");
        }

        [Test(Description = "Checking with \"=\"")]
        public void S11_14_A3()
        {
            RunFile("S11.14_A3.js");
        }
    }
}
