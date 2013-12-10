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

namespace Jint.Test262.Ch12._12_6
{
    [TestFixture]
    public class _12_6_2Fixture : Test262Fixture
    {
        public _12_6_2Fixture()
            : base("ch12\\12.6\\12.6.2")
        {
        }

        [Test(Description = "Evaluating various Expressions")]
        public void S12_6_2_A1()
        {
            RunFile("S12.6.2_A1.js");
        }

        [Test(Description = "Testing FunctionExpression too")]
        public void S12_6_2_A10()
        {
            RunFile("S12.6.2_A10.js");
        }

        [Test(Description = "Checking if execution of \"while({}){}\" passes")]
        public void S12_6_2_A11()
        {
            RunFile("S12.6.2_A11.js");
        }

        [Test(Description = "Using \"function __func(){return 0;}\" as an Expression")]
        public void S12_6_2_A14_T1()
        {
            RunFile("S12.6.2_A14_T1.js");
        }

        [Test(Description = "Using function call as an Expression")]
        public void S12_6_2_A14_T2()
        {
            RunFile("S12.6.2_A14_T2.js");
        }

        [Test(Description = "Expression is \"{0}\"")]
        [ExpectedException]
        public void S12_6_2_A15()
        {
            RunFile("S12.6.2_A15.js");
        }

        [Test(Description = "Evaluating Statement with error Expression")]
        public void S12_6_2_A2()
        {
            RunFile("S12.6.2_A2.js");
        }

        [Test(Description = "Using eval")]
        public void S12_6_2_A3()
        {
            RunFile("S12.6.2_A3.js");
        }

        [Test(Description = "\"break\" within a \"while\" Statement")]
        public void S12_6_2_A4_T1()
        {
            RunFile("S12.6.2_A4_T1.js");
        }

        [Test(Description = "\"break\" and VariableDeclaration within a \"while\" Statement")]
        public void S12_6_2_A4_T2()
        {
            RunFile("S12.6.2_A4_T2.js");
        }

        [Test(Description = "\"break\" and VariableDeclaration within a \"while\" Statement")]
        public void S12_6_2_A4_T3()
        {
            RunFile("S12.6.2_A4_T3.js");
        }

        [Test(Description = "\"break\" and VariableDeclaration within a \"while\" Statement")]
        public void S12_6_2_A4_T4()
        {
            RunFile("S12.6.2_A4_T4.js");
        }

        [Test(Description = "Using labeled \"break\" in order to continue a \"while\" loop")]
        public void S12_6_2_A4_T5()
        {
            RunFile("S12.6.2_A4_T5.js");
        }

        [Test(Description = "Using eval")]
        public void S12_6_2_A5()
        {
            RunFile("S12.6.2_A5.js");
        }

        [Test(Description = "Checking if execution of \"while 1 break\" fails")]
        [ExpectedException]
        public void S12_6_2_A6_T1()
        {
            RunFile("S12.6.2_A6_T1.js");
        }

        [Test(Description = "Checking if execution of \"while 0 break\" fails")]
        [ExpectedException]
        public void S12_6_2_A6_T2()
        {
            RunFile("S12.6.2_A6_T2.js");
        }

        [Test(Description = "Checking if execution of \"while true break\" fails")]
        [ExpectedException]
        public void S12_6_2_A6_T3()
        {
            RunFile("S12.6.2_A6_T3.js");
        }

        [Test(Description = "Checking if execution of \"while false break\" fails")]
        [ExpectedException]
        public void S12_6_2_A6_T4()
        {
            RunFile("S12.6.2_A6_T4.js");
        }

        [Test(Description = "Checking if execution of \"while '' break\" fails")]
        [ExpectedException]
        public void S12_6_2_A6_T5()
        {
            RunFile("S12.6.2_A6_T5.js");
        }

        [Test(Description = "Checking if execution of \"while 'hood' break\" fails")]
        [ExpectedException]
        public void S12_6_2_A6_T6()
        {
            RunFile("S12.6.2_A6_T6.js");
        }

        [Test(Description = "using eval")]
        public void S12_6_2_A7()
        {
            RunFile("S12.6.2_A7.js");
        }

        [Test(Description = "using eval")]
        public void S12_6_2_A8()
        {
            RunFile("S12.6.2_A8.js");
        }

        [Test(Description = "Throwing system exception inside \"while\" loop")]
        public void S12_6_2_A9()
        {
            RunFile("S12.6.2_A9.js");
        }
    }
}
