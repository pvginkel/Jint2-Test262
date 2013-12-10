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

namespace Jint.Test262.Ch15._15_10._15_10_2
{
    [TestFixture]
    public class _15_10_2_13Fixture : Test262Fixture
    {
        public _15_10_2_13Fixture()
            : base("ch15\\15.10\\15.10.2\\15.10.2.13")
        {
        }

        [Test(Description = "Execute /[]a/.test(\"\\0a\\0a\") and check results")]
        public void S15_10_2_13_A1_T1()
        {
            RunFile("S15.10.2.13_A1_T1.js");
        }

        [Test(Description = "Execute /[a-c\\d]+/.exec(\"\\n\\n\\abc324234\\n\") and check results")]
        public void S15_10_2_13_A1_T10()
        {
            RunFile("S15.10.2.13_A1_T10.js");
        }

        [Test(Description = "Execute /ab[.]?c/.exec(\"abc\") and check results")]
        public void S15_10_2_13_A1_T11()
        {
            RunFile("S15.10.2.13_A1_T11.js");
        }

        [Test(Description = "Execute /a[b]c/.exec(\"abc\") and check results")]
        public void S15_10_2_13_A1_T12()
        {
            RunFile("S15.10.2.13_A1_T12.js");
        }

        [Test(Description = "Execute /[a-z][^1-9][a-z]/.exec(\"a1b  b2c  c3d  def  f4g\") and check results")]
        public void S15_10_2_13_A1_T13()
        {
            RunFile("S15.10.2.13_A1_T13.js");
        }

        [Test(Description = "Execute /[*&$]{3}/.exec(\"123*&$abc\") and check results")]
        public void S15_10_2_13_A1_T14()
        {
            RunFile("S15.10.2.13_A1_T14.js");
        }

        [Test(Description = "Execute /[\\d][\\n][^\\d]/.exec(\"line1\\nline2\") and check results")]
        public void S15_10_2_13_A1_T15()
        {
            RunFile("S15.10.2.13_A1_T15.js");
        }

        [Test(Description = "Execute /[\\d][\\12-\\14]{1,}[^\\d]/.exec(\"line1\\n\\n\\n\\n\\nline2\") and check results")]
        public void S15_10_2_13_A1_T16()
        {
            RunFile("S15.10.2.13_A1_T16.js");
        }

        [Test(Description = "Execute /[]/.exec(\"a[b\\n[]\\tc]d\") and check results")]
        public void S15_10_2_13_A1_T17()
        {
            RunFile("S15.10.2.13_A1_T17.js");
        }

        [Test(Description = "Execute /a[]/.test(\"\\0a\\0a\") and check results")]
        public void S15_10_2_13_A1_T2()
        {
            RunFile("S15.10.2.13_A1_T2.js");
        }

        [Test(Description = "Execute /q[ax-zb](?=\\s+)/.exec(\"qYqy \") and check results")]
        public void S15_10_2_13_A1_T3()
        {
            RunFile("S15.10.2.13_A1_T3.js");
        }

        [Test(Description = "Execute /q[ax-zb](?=\\s+)/.exec(\"tqaqy \") and check results")]
        public void S15_10_2_13_A1_T4()
        {
            RunFile("S15.10.2.13_A1_T4.js");
        }

        [Test(Description = "Execute /q[ax-zb](?=\\s+)/.exec(\"tqa\\t  qy \") and check results")]
        public void S15_10_2_13_A1_T5()
        {
            RunFile("S15.10.2.13_A1_T5.js");
        }

        [Test(Description = "Execute /ab[ercst]de/.exec(\"abcde\") and check results")]
        public void S15_10_2_13_A1_T6()
        {
            RunFile("S15.10.2.13_A1_T6.js");
        }

        [Test(Description = "Execute /ab[erst]de/.test(\"abcde\") and check results")]
        public void S15_10_2_13_A1_T7()
        {
            RunFile("S15.10.2.13_A1_T7.js");
        }

        [Test(Description = "Execute /[d-h]+/.exec(\"abcdefghijkl\") and check results")]
        public void S15_10_2_13_A1_T8()
        {
            RunFile("S15.10.2.13_A1_T8.js");
        }

        [Test(Description = "Execute /[1234567].{2}/.exec(\"abc6defghijkl\") and check results")]
        public void S15_10_2_13_A1_T9()
        {
            RunFile("S15.10.2.13_A1_T9.js");
        }

        [Test(Description = "Execute /[^]a/m.exec(\"a\\naba\") and check results")]
        public void S15_10_2_13_A2_T1()
        {
            RunFile("S15.10.2.13_A2_T1.js");
        }

        [Test(Description = "Execute /a[^]/.exec(\"   a\\t\\n\") and check results")]
        public void S15_10_2_13_A2_T2()
        {
            RunFile("S15.10.2.13_A2_T2.js");
        }

        [Test(Description = "Execute /a[^b-z]\\s+/.exec(\"ab an az aY n\") and check results")]
        public void S15_10_2_13_A2_T3()
        {
            RunFile("S15.10.2.13_A2_T3.js");
        }

        [Test(Description = "Execute /[^\\b]+/g.exec(\"easy\\bto\\u0008ride\") and check results")]
        public void S15_10_2_13_A2_T4()
        {
            RunFile("S15.10.2.13_A2_T4.js");
        }

        [Test(Description = "Execute /a[^1-9]c/.exec(\"abc\") and check results")]
        public void S15_10_2_13_A2_T5()
        {
            RunFile("S15.10.2.13_A2_T5.js");
        }

        [Test(Description = "Execute /a[^b]c/.test(\"abc\") and check results")]
        public void S15_10_2_13_A2_T6()
        {
            RunFile("S15.10.2.13_A2_T6.js");
        }

        [Test(Description = "Execute /[^a-z]{4}/.exec(\"abc#$%def%&*@ghi\") and check results")]
        public void S15_10_2_13_A2_T7()
        {
            RunFile("S15.10.2.13_A2_T7.js");
        }

        [Test(Description = "Execute /[^]/.exec(\"abc#$%def%&*@ghi\") and check results")]
        public void S15_10_2_13_A2_T8()
        {
            RunFile("S15.10.2.13_A2_T8.js");
        }

        [Test(Description = "Execute /.[\\b]./.exec(\"abc\\bdef\") and check results")]
        public void S15_10_2_13_A3_T1()
        {
            RunFile("S15.10.2.13_A3_T1.js");
        }

        [Test(Description = "Execute /c[\\b]{3}d/.exec(\"abc\\b\\b\\bdef\") and check results")]
        public void S15_10_2_13_A3_T2()
        {
            RunFile("S15.10.2.13_A3_T2.js");
        }

        [Test(Description = "Execute /[^\\[\\b\\]]+/.exec(\"abc\\bdef\") and check results")]
        public void S15_10_2_13_A3_T3()
        {
            RunFile("S15.10.2.13_A3_T3.js");
        }

        [Test(Description = "Execute /[^\\[\\b\\]]+/.exec(\"abcdef\") and check results")]
        public void S15_10_2_13_A3_T4()
        {
            RunFile("S15.10.2.13_A3_T4.js");
        }
    }
}