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

namespace Jint.Test262.Ch11._11_8
{
    [TestFixture]
    public class _11_8_4Fixture : Test262Fixture
    {
        public _11_8_4Fixture()
            : base("ch11\\11.8\\11.8.4")
        {
        }

        [Test(Description = "Checking by using eval")]
        public void S11_8_4_A1()
        {
            RunFile("S11.8.4_A1.js");
        }

        [Test(Description = "Either Type is not Reference or GetBase is not null")]
        public void S11_8_4_A2_1_T1()
        {
            RunFile("S11.8.4_A2.1_T1.js");
        }

        [Test(Description = "If GetBase(x) is null, throw ReferenceError")]
        public void S11_8_4_A2_1_T2()
        {
            RunFile("S11.8.4_A2.1_T2.js");
        }

        [Test(Description = "If GetBase(y) is null, throw ReferenceError")]
        public void S11_8_4_A2_1_T3()
        {
            RunFile("S11.8.4_A2.1_T3.js");
        }

        [Test(Description = "If Type(value) is Object, evaluate ToPrimitive(value, Number)")]
        public void S11_8_4_A2_2_T1()
        {
            RunFile("S11.8.4_A2.2_T1.js");
        }

        [Test(Description = "Checking with \"throw\"")]
        public void S11_8_4_A2_3_T1()
        {
            RunFile("S11.8.4_A2.3_T1.js");
        }

        [Test(Description = "Checking with \"=\"")]
        public void S11_8_4_A2_4_T1()
        {
            RunFile("S11.8.4_A2.4_T1.js");
        }

        [Test(Description = "Checking with \"throw\"")]
        public void S11_8_4_A2_4_T2()
        {
            RunFile("S11.8.4_A2.4_T2.js");
        }

        [Test(Description = "Checking with undeclarated variables")]
        public void S11_8_4_A2_4_T3()
        {
            RunFile("S11.8.4_A2.4_T3.js");
        }

        [Test(Description = "Type(Primitive(x)) and Type(Primitive(y)) vary between primitive boolean and Boolean object")]
        public void S11_8_4_A3_1_T1_1()
        {
            RunFile("S11.8.4_A3.1_T1.1.js");
        }

        [Test(Description = "Type(Primitive(x)) and Type(Primitive(y)) vary between primitive number and Number object")]
        public void S11_8_4_A3_1_T1_2()
        {
            RunFile("S11.8.4_A3.1_T1.2.js");
        }

        [Test(Description = "Type(Primitive(x)) and Type(Primitive(y)) vary between Null and Undefined")]
        public void S11_8_4_A3_1_T1_3()
        {
            RunFile("S11.8.4_A3.1_T1.3.js");
        }

        [Test(Description = "Type(Primitive(x)) is different from Type(Primitive(y)) and both types vary between Number (primitive or object) and Boolean (primitive and object)")]
        public void S11_8_4_A3_1_T2_1()
        {
            RunFile("S11.8.4_A3.1_T2.1.js");
        }

        [Test(Description = "Type(Primitive(x)) is different from Type(Primitive(y)) and both types vary between Number (primitive or object) and String (primitive and object)")]
        public void S11_8_4_A3_1_T2_2()
        {
            RunFile("S11.8.4_A3.1_T2.2.js");
        }

        [Test(Description = "Type(Primitive(x)) is different from Type(Primitive(y)) and both types vary between Number (primitive or object) and Null")]
        public void S11_8_4_A3_1_T2_3()
        {
            RunFile("S11.8.4_A3.1_T2.3.js");
        }

        [Test(Description = "Type(Primitive(x)) is different from Type(Primitive(y)) and both types vary between Number (primitive or object) and Undefined")]
        public void S11_8_4_A3_1_T2_4()
        {
            RunFile("S11.8.4_A3.1_T2.4.js");
        }

        [Test(Description = "Type(Primitive(x)) is different from Type(Primitive(y)) and both types vary between String (primitive or object) and Boolean (primitive and object)")]
        public void S11_8_4_A3_1_T2_5()
        {
            RunFile("S11.8.4_A3.1_T2.5.js");
        }

        [Test(Description = "Type(Primitive(x)) is different from Type(Primitive(y)) and both types vary between String (primitive or object) and Undefined")]
        public void S11_8_4_A3_1_T2_6()
        {
            RunFile("S11.8.4_A3.1_T2.6.js");
        }

        [Test(Description = "Type(Primitive(x)) is different from Type(Primitive(y)) and both types vary between String (primitive or object) and Null")]
        public void S11_8_4_A3_1_T2_7()
        {
            RunFile("S11.8.4_A3.1_T2.7.js");
        }

        [Test(Description = "Type(Primitive(x)) is different from Type(Primitive(y)) and both types vary between Boolean (primitive or object) and Undefined")]
        public void S11_8_4_A3_1_T2_8()
        {
            RunFile("S11.8.4_A3.1_T2.8.js");
        }

        [Test(Description = "Type(Primitive(x)) is different from Type(Primitive(y)) and both types vary between Boolean (primitive or object) and Null")]
        public void S11_8_4_A3_1_T2_9()
        {
            RunFile("S11.8.4_A3.1_T2.9.js");
        }

        [Test(Description = "Type(Primitive(x)) and Type(Primitive(y)) vary between primitive string and String object")]
        public void S11_8_4_A3_2_T1_1()
        {
            RunFile("S11.8.4_A3.2_T1.1.js");
        }

        [Test(Description = "Type(Primitive(x)) and Type(Primitive(y)) vary between Object object and Function object")]
        public void S11_8_4_A3_2_T1_2()
        {
            RunFile("S11.8.4_A3.2_T1.2.js");
        }

        [Test(Description = "y is number primitive")]
        public void S11_8_4_A4_1()
        {
            RunFile("S11.8.4_A4.1.js");
        }

        [Test(Description = "x and y are string primitives")]
        public void S11_8_4_A4_10()
        {
            RunFile("S11.8.4_A4.10.js");
        }

        [Test(Description = "x and y are string primitives")]
        public void S11_8_4_A4_11()
        {
            RunFile("S11.8.4_A4.11.js");
        }

        [Test(Description = "x and y are string primitives")]
        public void S11_8_4_A4_12_T1()
        {
            RunFile("S11.8.4_A4.12_T1.js");
        }

        [Test(Description = "x and y are string primitives")]
        public void S11_8_4_A4_12_T2()
        {
            RunFile("S11.8.4_A4.12_T2.js");
        }

        [Test(Description = "x is number primitive")]
        public void S11_8_4_A4_2()
        {
            RunFile("S11.8.4_A4.2.js");
        }

        [Test(Description = "x and y are number primitives")]
        public void S11_8_4_A4_3()
        {
            RunFile("S11.8.4_A4.3.js");
        }

        [Test(Description = "Checking all combinations")]
        public void S11_8_4_A4_4()
        {
            RunFile("S11.8.4_A4.4.js");
        }

        [Test(Description = "y is number primitive")]
        public void S11_8_4_A4_5()
        {
            RunFile("S11.8.4_A4.5.js");
        }

        [Test(Description = "x is number primitive")]
        public void S11_8_4_A4_6()
        {
            RunFile("S11.8.4_A4.6.js");
        }

        [Test(Description = "y is number primitive")]
        public void S11_8_4_A4_7()
        {
            RunFile("S11.8.4_A4.7.js");
        }

        [Test(Description = "x is number primitive")]
        public void S11_8_4_A4_8()
        {
            RunFile("S11.8.4_A4.8.js");
        }

        [Test(Description = "x and y are number primitives")]
        public void S11_8_4_A4_9()
        {
            RunFile("S11.8.4_A4.9.js");
        }
    }
}