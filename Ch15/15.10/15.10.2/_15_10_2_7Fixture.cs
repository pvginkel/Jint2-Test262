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
    public class _15_10_2_7Fixture : Test262Fixture
    {
        public _15_10_2_7Fixture()
            : base("ch15\\15.10\\15.10.2\\15.10.2.7")
        {
        }

        [Test(Description = "Execute /\\d{2,4}/.exec(\"the answer is 42\") and check results")]
        public void S15_10_2_7_A1_T1()
        {
            RunFile("S15.10.2.7_A1_T1.js");
        }

        [Test(Description = "Execute /b{0,93}c/.exec(\"aaabbbbcccddeeeefffff\") and check results")]
        public void S15_10_2_7_A1_T10()
        {
            RunFile("S15.10.2.7_A1_T10.js");
        }

        [Test(Description = "Execute /bx{0,93}c/.exec(\"aaabbbbcccddeeeefffff\") and check results")]
        public void S15_10_2_7_A1_T11()
        {
            RunFile("S15.10.2.7_A1_T11.js");
        }

        [Test(Description = "Execute /.{0,93}/.exec(\"weirwerdf\") and check results")]
        public void S15_10_2_7_A1_T12()
        {
            RunFile("S15.10.2.7_A1_T12.js");
        }

        [Test(Description = "Execute /\\d{2,4}/.test(\"the 7 movie\") and check results")]
        public void S15_10_2_7_A1_T2()
        {
            RunFile("S15.10.2.7_A1_T2.js");
        }

        [Test(Description = "Execute /\\d{2,4}/.exec(\"the 20000 Leagues Under the Sea book\") and check results")]
        public void S15_10_2_7_A1_T3()
        {
            RunFile("S15.10.2.7_A1_T3.js");
        }

        [Test(Description = "Execute /\\d{2,4}/.exec(\"the Fahrenheit 451 book\") and check results")]
        public void S15_10_2_7_A1_T4()
        {
            RunFile("S15.10.2.7_A1_T4.js");
        }

        [Test(Description = "Execute /\\d{2,4}/.exec(\"the 1984 novel\") and check results")]
        public void S15_10_2_7_A1_T5()
        {
            RunFile("S15.10.2.7_A1_T5.js");
        }

        [Test(Description = "Execute /\\d{2,4}/.exec(\"0a0\\u0031\\u0031b\") and check results")]
        public void S15_10_2_7_A1_T6()
        {
            RunFile("S15.10.2.7_A1_T6.js");
        }

        [Test(Description = "Execute /\\d{2,4}/.exec(\"0a0\\u0031\\u003122b\") and check results")]
        public void S15_10_2_7_A1_T7()
        {
            RunFile("S15.10.2.7_A1_T7.js");
        }

        [Test(Description = "Execute /b{2,3}c/.exec(\"aaabbbbcccddeeeefffff\") and check results")]
        public void S15_10_2_7_A1_T8()
        {
            RunFile("S15.10.2.7_A1_T8.js");
        }

        [Test(Description = "Execute /b{42,93}c/.exec(\"aaabbbbcccddeeeefffff\") and check results")]
        public void S15_10_2_7_A1_T9()
        {
            RunFile("S15.10.2.7_A1_T9.js");
        }

        [Test(Description = "Execute /\\w{3}\\d?/.exec(\"CE\\uFFFFL\\uFFDDbox127\") and check results")]
        public void S15_10_2_7_A2_T1()
        {
            RunFile("S15.10.2.7_A2_T1.js");
        }

        [Test(Description = "Execute /\\w{3}\\d?/.exec(\"CELL\\uFFDDbox127\") and check results")]
        public void S15_10_2_7_A2_T2()
        {
            RunFile("S15.10.2.7_A2_T2.js");
        }

        [Test(Description = "Execute /b{2}c/.exec(\"aaabbbbcccddeeeefffff\") and check results")]
        public void S15_10_2_7_A2_T3()
        {
            RunFile("S15.10.2.7_A2_T3.js");
        }

        [Test(Description = "Execute /b{8}c/.test(\"aaabbbbcccddeeeefffff\") and check results")]
        public void S15_10_2_7_A2_T4()
        {
            RunFile("S15.10.2.7_A2_T4.js");
        }

        [Test(Description = "Execute /\\s+java\\s+/.exec(\"language  java\\n\") and check results")]
        public void S15_10_2_7_A3_T1()
        {
            RunFile("S15.10.2.7_A3_T1.js");
        }

        [Test(Description = "Execute /o+/.test(\"abcdefg\") and check results")]
        public void S15_10_2_7_A3_T10()
        {
            RunFile("S15.10.2.7_A3_T10.js");
        }

        [Test(Description = "Execute /d+/.exec(\"abcdefg\") and check results")]
        public void S15_10_2_7_A3_T11()
        {
            RunFile("S15.10.2.7_A3_T11.js");
        }

        [Test(Description = "Execute /(b+)(b+)(b+)/.exec(\"abbbbbbbc\") and check results")]
        public void S15_10_2_7_A3_T12()
        {
            RunFile("S15.10.2.7_A3_T12.js");
        }

        [Test(Description = "Execute /(b+)(b*)/.exec(\"abbbbbbbc\") and check results")]
        public void S15_10_2_7_A3_T13()
        {
            RunFile("S15.10.2.7_A3_T13.js");
        }

        [Test(Description = "Execute /b*b+/.exec(\"abbbbbbbc\") and check results")]
        public void S15_10_2_7_A3_T14()
        {
            RunFile("S15.10.2.7_A3_T14.js");
        }

        [Test(Description = "Execute /\\s+java\\s+/.exec(\"\\t java object\") and check results")]
        public void S15_10_2_7_A3_T2()
        {
            RunFile("S15.10.2.7_A3_T2.js");
        }

        [Test(Description = "Execute /\\s+java\\s+/.test(\"\\t javax package\") and check results")]
        public void S15_10_2_7_A3_T3()
        {
            RunFile("S15.10.2.7_A3_T3.js");
        }

        [Test(Description = "Execute /\\s+java\\s+/.test(\"java\\n\\nobject\") and check results")]
        public void S15_10_2_7_A3_T4()
        {
            RunFile("S15.10.2.7_A3_T4.js");
        }

        [Test(Description = "Execute /[a-z]+\\d+/.exec(\"x 2 ff 55 x2 as1 z12 abc12.0\") and check results")]
        public void S15_10_2_7_A3_T5()
        {
            RunFile("S15.10.2.7_A3_T5.js");
        }

        [Test(Description = "Execute /[a-z]+\\d+/.exec(\"__abc123.0\") and check results")]
        public void S15_10_2_7_A3_T6()
        {
            RunFile("S15.10.2.7_A3_T6.js");
        }

        [Test(Description = "Execute /[a-z]+(\\d+)/.exec(\"x 2 ff 55 x2 as1 z12 abc12.0\") and check results")]
        public void S15_10_2_7_A3_T7()
        {
            RunFile("S15.10.2.7_A3_T7.js");
        }

        [Test(Description = "Execute /[a-z]+(\\d+)/.exec(\"__abc123.0\") and check results")]
        public void S15_10_2_7_A3_T8()
        {
            RunFile("S15.10.2.7_A3_T8.js");
        }

        [Test(Description = "Execute /d+/.exec(\"abcdddddefg\") and check results")]
        public void S15_10_2_7_A3_T9()
        {
            RunFile("S15.10.2.7_A3_T9.js");
        }

        [Test(Description = "Execute /[^\"]* /.exec('\"beast\"-nickname') and check results")]
        public void S15_10_2_7_A4_T1()
        {
            RunFile("S15.10.2.7_A4_T1.js");
        }

        [Test(Description = "Execute /d* /.exec('abcddddefg') and check results")]
        public void S15_10_2_7_A4_T10()
        {
            RunFile("S15.10.2.7_A4_T10.js");
        }

        [Test(Description = "Execute /cd* /.exec('abcddddefg') and check results")]
        public void S15_10_2_7_A4_T11()
        {
            RunFile("S15.10.2.7_A4_T11.js");
        }

        [Test(Description = "Execute /cx*d/.exec('abcdefg') and check results")]
        public void S15_10_2_7_A4_T12()
        {
            RunFile("S15.10.2.7_A4_T12.js");
        }

        [Test(Description = "Execute /(x*)(x+)/.exec('xxxxxxx') and check results")]
        public void S15_10_2_7_A4_T13()
        {
            RunFile("S15.10.2.7_A4_T13.js");
        }

        [Test(Description = "Execute /(\\d*)(\\d+)/.exec('1234567890') and check results")]
        public void S15_10_2_7_A4_T14()
        {
            RunFile("S15.10.2.7_A4_T14.js");
        }

        [Test(Description = "Execute /(\\d*)\\d(\\d+)/.exec('1234567890') and check results")]
        public void S15_10_2_7_A4_T15()
        {
            RunFile("S15.10.2.7_A4_T15.js");
        }

        [Test(Description = "Execute /(x+)(x*)/.exec('xxxxxxx') and check results")]
        public void S15_10_2_7_A4_T16()
        {
            RunFile("S15.10.2.7_A4_T16.js");
        }

        [Test(Description = "Execute /x*y+$/.exec('xxxxxxyyyyyy') and check results")]
        public void S15_10_2_7_A4_T17()
        {
            RunFile("S15.10.2.7_A4_T17.js");
        }

        [Test(Description = "Execute /[\\d]*[\\s]*bc./.exec('abcdef') and check results")]
        public void S15_10_2_7_A4_T18()
        {
            RunFile("S15.10.2.7_A4_T18.js");
        }

        [Test(Description = "Execute /bc..[\\d]*[\\s]* /.exec('abcdef') and check results")]
        public void S15_10_2_7_A4_T19()
        {
            RunFile("S15.10.2.7_A4_T19.js");
        }

        [Test(Description = "Execute /[^\"]* /.exec('alice said: \"don\\'t\"') and check results")]
        public void S15_10_2_7_A4_T2()
        {
            RunFile("S15.10.2.7_A4_T2.js");
        }

        [Test(Description = "Execute /.* /.exec('a1b2c3') and check results")]
        public void S15_10_2_7_A4_T20()
        {
            RunFile("S15.10.2.7_A4_T20.js");
        }

        [Test(Description = "Execute /[xyz]*1/.test('a0.b2.c3') and check results")]
        public void S15_10_2_7_A4_T21()
        {
            RunFile("S15.10.2.7_A4_T21.js");
        }

        [Test(Description = "Execute /[^\"]* /.exec(\"before\\'i\\'start\") and check results")]
        public void S15_10_2_7_A4_T3()
        {
            RunFile("S15.10.2.7_A4_T3.js");
        }

        [Test(Description = "Execute /[^\"]* /.exec('alice \\\"sweep\\\": \"don\\'t\"') and check results")]
        public void S15_10_2_7_A4_T4()
        {
            RunFile("S15.10.2.7_A4_T4.js");
        }

        [Test(Description = "Execute /[^\"]* /.exec('alice \\u0022sweep\\u0022: \"don\\'t\"') and check results")]
        public void S15_10_2_7_A4_T5()
        {
            RunFile("S15.10.2.7_A4_T5.js");
        }

        [Test(Description = "Execute /[\"'][^\"']*[\"']/.exec('alice \\u0022sweep\\u0022: \"don\\'t\"') and check results")]
        public void S15_10_2_7_A4_T6()
        {
            RunFile("S15.10.2.7_A4_T6.js");
        }

        [Test(Description = "Execute /[\"'][^\"']*[\"']/.exec('alice cries out: \\'don\\'t\\'') and check results")]
        public void S15_10_2_7_A4_T7()
        {
            RunFile("S15.10.2.7_A4_T7.js");
        }

        [Test(Description = "Execute /[\"'][^\"']*[\"']/.test('alice cries out: don\\'t') and check results")]
        public void S15_10_2_7_A4_T8()
        {
            RunFile("S15.10.2.7_A4_T8.js");
        }

        [Test(Description = "Execute /[\"'][^\"']*[\"']/.exec('alice cries out:\\\"\\\"') and check results")]
        public void S15_10_2_7_A4_T9()
        {
            RunFile("S15.10.2.7_A4_T9.js");
        }

        [Test(Description = "Execute /java(script)?/.exec(\"state: javascript is extension of ecma script\") and check results")]
        public void S15_10_2_7_A5_T1()
        {
            RunFile("S15.10.2.7_A5_T1.js");
        }

        [Test(Description = "Execute /ab?c?d?x?y?z/.exec(\"123az789\") and check results")]
        public void S15_10_2_7_A5_T10()
        {
            RunFile("S15.10.2.7_A5_T10.js");
        }

        [Test(Description = "Execute /\\??\\??\\??\\??\\??/.exec(\"?????\") and check results")]
        public void S15_10_2_7_A5_T11()
        {
            RunFile("S15.10.2.7_A5_T11.js");
        }

        [Test(Description = "Execute /.?.?.?.?.?.?.?/.exec(\"test\") and check results")]
        public void S15_10_2_7_A5_T12()
        {
            RunFile("S15.10.2.7_A5_T12.js");
        }

        [Test(Description = "Execute /java(script)?/.exec(\"state: java and javascript are vastly different\") and check results")]
        public void S15_10_2_7_A5_T2()
        {
            RunFile("S15.10.2.7_A5_T2.js");
        }

        [Test(Description = "Execute /java(script)?/.test(\"state: both Java and JavaScript used in web development\") and check results")]
        public void S15_10_2_7_A5_T3()
        {
            RunFile("S15.10.2.7_A5_T3.js");
        }

        [Test(Description = "Execute /cd?e/.exec(\"abcdef\") and check results")]
        public void S15_10_2_7_A5_T4()
        {
            RunFile("S15.10.2.7_A5_T4.js");
        }

        [Test(Description = "Execute /cdx?e/.exec(\"abcdef\") and check results")]
        public void S15_10_2_7_A5_T5()
        {
            RunFile("S15.10.2.7_A5_T5.js");
        }

        [Test(Description = "Execute /o?pqrst/.exec(\"pqrstuvw\") and check results")]
        public void S15_10_2_7_A5_T6()
        {
            RunFile("S15.10.2.7_A5_T6.js");
        }

        [Test(Description = "Execute /x?y?z?/.exec(\"abcd\") and check results")]
        public void S15_10_2_7_A5_T7()
        {
            RunFile("S15.10.2.7_A5_T7.js");
        }

        [Test(Description = "Execute /x?ay?bz?c/.exec(\"abcd\") and check results")]
        public void S15_10_2_7_A5_T8()
        {
            RunFile("S15.10.2.7_A5_T8.js");
        }

        [Test(Description = "Execute /b?b?b?b/.exec(\"abbbbc\") and check results")]
        public void S15_10_2_7_A5_T9()
        {
            RunFile("S15.10.2.7_A5_T9.js");
        }

        [Test(Description = "Execute /b{2,}c/.exec(\"aaabbbbcccddeeeefffff\") and check results")]
        public void S15_10_2_7_A6_T1()
        {
            RunFile("S15.10.2.7_A6_T1.js");
        }

        [Test(Description = "Execute /b{8,}c/.test(\"aaabbbbcccddeeeefffff\") and check results")]
        public void S15_10_2_7_A6_T2()
        {
            RunFile("S15.10.2.7_A6_T2.js");
        }

        [Test(Description = "Execute /\\d{1,}/.exec(\"wqe456646dsff\") and check results")]
        public void S15_10_2_7_A6_T3()
        {
            RunFile("S15.10.2.7_A6_T3.js");
        }

        [Test(Description = "Execute /(123){1,}/.exec(\"123123\") and check results")]
        public void S15_10_2_7_A6_T4()
        {
            RunFile("S15.10.2.7_A6_T4.js");
        }

        [Test(Description = "Execute /(123){1,}x\\1/.exec(\"123123x123\") and check results")]
        public void S15_10_2_7_A6_T5()
        {
            RunFile("S15.10.2.7_A6_T5.js");
        }

        [Test(Description = "Execute /x{1,2}x{1,}/.exec(\"xxxxxxx\") and check results")]
        public void S15_10_2_7_A6_T6()
        {
            RunFile("S15.10.2.7_A6_T6.js");
        }
    }
}
