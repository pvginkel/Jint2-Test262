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
    public class _15_10_2_8Fixture : Test262Fixture
    {
        public _15_10_2_8Fixture()
            : base("ch15\\15.10\\15.10.2\\15.10.2.8")
        {
        }

        [Test(Description = "Execute /(?=(a+))/.exec(\"baaabac\") and check results")]
        public void S15_10_2_8_A1_T1()
        {
            RunFile("S15.10.2.8_A1_T1.js");
        }

        [Test(Description = "Execute /(?=(a+))a*b\\1/.exec(\"baaabac\") and check results")]
        public void S15_10_2_8_A1_T2()
        {
            RunFile("S15.10.2.8_A1_T2.js");
        }

        [Test(Description = "Execute /[Jj]ava([Ss]cript)?(?=\\:)/.exec(\"just Javascript: the way af jedi\") and check results")]
        public void S15_10_2_8_A1_T3()
        {
            RunFile("S15.10.2.8_A1_T3.js");
        }

        [Test(Description = "Execute /[Jj]ava([Ss]cript)?(?=\\:)/.exec(\"taste of java: the cookbook \") and check results")]
        public void S15_10_2_8_A1_T4()
        {
            RunFile("S15.10.2.8_A1_T4.js");
        }

        [Test(Description = "Execute /[Jj]ava([Ss]cript)?(?=\\:)/.test(\"rhino is JavaScript engine\") and check results")]
        public void S15_10_2_8_A1_T5()
        {
            RunFile("S15.10.2.8_A1_T5.js");
        }

        [Test(Description = "Execute /(.*?)a(?!(a+)b\\2c)\\2(.*)/.exec(\"baaabaac\") and check results")]
        public void S15_10_2_8_A2_T1()
        {
            RunFile("S15.10.2.8_A2_T1.js");
        }

        [Test(Description = "Execute /(?!a|b)|c/.exec(\"bc\") and check results")]
        public void S15_10_2_8_A2_T10()
        {
            RunFile("S15.10.2.8_A2_T10.js");
        }

        [Test(Description = "Execute /(?!a|b)|c/.exec(\"d\") and check results")]
        public void S15_10_2_8_A2_T11()
        {
            RunFile("S15.10.2.8_A2_T11.js");
        }

        [Test(Description = "Execute /Java(?!Script)([A-Z]\\w*)/.exec(\"using of JavaBeans technology\") and check results")]
        public void S15_10_2_8_A2_T2()
        {
            RunFile("S15.10.2.8_A2_T2.js");
        }

        [Test(Description = "Execute /Java(?!Script)([A-Z]\\w*)/.test(\"using of Java language\") and check results")]
        public void S15_10_2_8_A2_T3()
        {
            RunFile("S15.10.2.8_A2_T3.js");
        }

        [Test(Description = "Execute /Java(?!Script)([A-Z]\\w*)/.test(\"i'm a JavaScripter \") and check results")]
        public void S15_10_2_8_A2_T4()
        {
            RunFile("S15.10.2.8_A2_T4.js");
        }

        [Test(Description = "Execute /Java(?!Script)([A-Z]\\w*)/.exec(\"JavaScr oops ipt \") and check results")]
        public void S15_10_2_8_A2_T5()
        {
            RunFile("S15.10.2.8_A2_T5.js");
        }

        [Test(Description = "Execute /(\\.(?!com|org)|\\/)/.exec(\"ah.info\") and check results")]
        public void S15_10_2_8_A2_T6()
        {
            RunFile("S15.10.2.8_A2_T6.js");
        }

        [Test(Description = "Execute /(\\.(?!com|org)|\\/)/.exec(\"ah/info\") and check results")]
        public void S15_10_2_8_A2_T7()
        {
            RunFile("S15.10.2.8_A2_T7.js");
        }

        [Test(Description = "Execute /(\\.(?!com|org)|\\/)/.test(\"ah.com\") and check results")]
        public void S15_10_2_8_A2_T8()
        {
            RunFile("S15.10.2.8_A2_T8.js");
        }

        [Test(Description = "Execute /(?!a|b)|c/.exec(\"\") and check results")]
        public void S15_10_2_8_A2_T9()
        {
            RunFile("S15.10.2.8_A2_T9.js");
        }

        [Test(Description = "Execute /([Jj]ava([Ss]cript)?)\\sis\\s(fun\\w*)/.exec(\"Learning javaScript is funny, really\") and check results")]
        public void S15_10_2_8_A3_T1()
        {
            RunFile("S15.10.2.8_A3_T1.js");
        }

        [Test(Description = "Execute /(\\d{3})(\\d{3})\\1\\2/.exec(\"123456123456\") and check results")]
        public void S15_10_2_8_A3_T10()
        {
            RunFile("S15.10.2.8_A3_T10.js");
        }

        [Test(Description = "Execute /a(..(..)..)/.exec(\"abcdefgh\") and check results")]
        public void S15_10_2_8_A3_T11()
        {
            RunFile("S15.10.2.8_A3_T11.js");
        }

        [Test(Description = "Execute /(a(b(c)))(d(e(f)))/.exec(\"xabcdefg\") and check results")]
        public void S15_10_2_8_A3_T12()
        {
            RunFile("S15.10.2.8_A3_T12.js");
        }

        [Test(Description = "Execute /(a(b(c)))(d(e(f)))\\2\\5/.exec(\"xabcdefbcefg\") and check results")]
        public void S15_10_2_8_A3_T13()
        {
            RunFile("S15.10.2.8_A3_T13.js");
        }

        [Test(Description = "Execute /a(.?)b\\1c\\1d\\1/.exec(\"abcd\") and check results")]
        public void S15_10_2_8_A3_T14()
        {
            RunFile("S15.10.2.8_A3_T14.js");
        }

        [Test(Description = "see bug http:bugzilla.mozilla.org/show_bug.cgi?id=119909")]
        public void S15_10_2_8_A3_T15()
        {
            RunFile("S15.10.2.8_A3_T15.js");
        }

        [Test(Description = "see bug http:bugzilla.mozilla.org/show_bug.cgi?id=119909")]
        public void S15_10_2_8_A3_T16()
        {
            RunFile("S15.10.2.8_A3_T16.js");
        }

        [Test(Description = "see bug http:bugzilla.mozilla.org/show_bug.cgi?id=169497")]
        public void S15_10_2_8_A3_T17()
        {
            RunFile("S15.10.2.8_A3_T17.js");
        }

        [Test(Description = "see bug  http:bugzilla.mozilla.org/show_bug.cgi?id=169534")]
        public void S15_10_2_8_A3_T18()
        {
            RunFile("S15.10.2.8_A3_T18.js");
        }

        [Test(Description = "Execute /([\\S]+([ \\t]+[\\S]+)*)[ \\t]*=[ \\t]*[\\S]+/.exec(\"Course_Creator = Test\") and check results")]
        public void S15_10_2_8_A3_T19()
        {
            RunFile("S15.10.2.8_A3_T19.js");
        }

        [Test(Description = "Execute /([Jj]ava([Ss]cript)?)\\sis\\s(fun\\w*)/.exec(\"Developing with Java is fun, try it\") and check results")]
        public void S15_10_2_8_A3_T2()
        {
            RunFile("S15.10.2.8_A3_T2.js");
        }

        [Test(Description = "Execute /^(A)?(A.*)$/.exec(\"AAA\") and check results")]
        public void S15_10_2_8_A3_T20()
        {
            RunFile("S15.10.2.8_A3_T20.js");
        }

        [Test(Description = "Execute /^(A)?(A.*)$/.exec(\"AA\") and check results")]
        public void S15_10_2_8_A3_T21()
        {
            RunFile("S15.10.2.8_A3_T21.js");
        }

        [Test(Description = "Execute /^(A)?(A.*)$/.exec(\"A\") and check results")]
        public void S15_10_2_8_A3_T22()
        {
            RunFile("S15.10.2.8_A3_T22.js");
        }

        [Test(Description = "Execute /(A)?(A.*)/.exec(\"zxcasd;fl\\\\\\  ^AAAaaAAaaaf;lrlrzs\") and check results")]
        public void S15_10_2_8_A3_T23()
        {
            RunFile("S15.10.2.8_A3_T23.js");
        }

        [Test(Description = "Execute /(A)?(A.*)/.exec(\"zxcasd;fl\\\\\\  ^AAaaAAaaaf;lrlrzs\") and check results")]
        public void S15_10_2_8_A3_T24()
        {
            RunFile("S15.10.2.8_A3_T24.js");
        }

        [Test(Description = "Execute /(A)?(A.*)/.exec(\"zxcasd;fl\\\\\\  ^AaaAAaaaf;lrlrzs\") and check results")]
        public void S15_10_2_8_A3_T25()
        {
            RunFile("S15.10.2.8_A3_T25.js");
        }

        [Test(Description = "Execute /(a)?a/.exec(\"a\") and check results")]
        public void S15_10_2_8_A3_T26()
        {
            RunFile("S15.10.2.8_A3_T26.js");
        }

        [Test(Description = "Execute /a|(b)/.exec(\"a\") and check results")]
        public void S15_10_2_8_A3_T27()
        {
            RunFile("S15.10.2.8_A3_T27.js");
        }

        [Test(Description = "Execute /(a)?(a)/.exec(\"a\") and check results")]
        public void S15_10_2_8_A3_T28()
        {
            RunFile("S15.10.2.8_A3_T28.js");
        }

        [Test(Description = "See bug http:bugzilla.mozilla.org/show_bug.cgi?id=165353")]
        public void S15_10_2_8_A3_T29()
        {
            RunFile("S15.10.2.8_A3_T29.js");
        }

        [Test(Description = "Execute /([Jj]ava([Ss]cript)?)\\sis\\s(fun\\w*)/.test(\"Developing with JavaScript is dangerous, do not try it without assistance\") and check results")]
        public void S15_10_2_8_A3_T3()
        {
            RunFile("S15.10.2.8_A3_T3.js");
        }

        [Test(Description = "See bug http:bugzilla.mozilla.org/show_bug.cgi?id=165353")]
        public void S15_10_2_8_A3_T30()
        {
            RunFile("S15.10.2.8_A3_T30.js");
        }

        [Test(Description = "See bug http:bugzilla.mozilla.org/show_bug.cgi?id=165353")]
        public void S15_10_2_8_A3_T31()
        {
            RunFile("S15.10.2.8_A3_T31.js");
        }

        [Test(Description = "See bug http:bugzilla.mozilla.org/show_bug.cgi?id=165353")]
        public void S15_10_2_8_A3_T32()
        {
            RunFile("S15.10.2.8_A3_T32.js");
        }

        [Test(Description = "See bug http:bugzilla.mozilla.org/show_bug.cgi?id=165353")]
        public void S15_10_2_8_A3_T33()
        {
            RunFile("S15.10.2.8_A3_T33.js");
        }

        [Test(Description = "Execute /(abc)/.exec(\"abc\") and check results")]
        public void S15_10_2_8_A3_T4()
        {
            RunFile("S15.10.2.8_A3_T4.js");
        }

        [Test(Description = "Execute /a(bc)d(ef)g/.exec(\"abcdefg\") and check results")]
        public void S15_10_2_8_A3_T5()
        {
            RunFile("S15.10.2.8_A3_T5.js");
        }

        [Test(Description = "Execute /(.{3})(.{4})/.exec(\"abcdefgh\") and check results")]
        public void S15_10_2_8_A3_T6()
        {
            RunFile("S15.10.2.8_A3_T6.js");
        }

        [Test(Description = "Execute /(aa)bcd\\1/.exec(\"aabcdaabcd\") and check results")]
        public void S15_10_2_8_A3_T7()
        {
            RunFile("S15.10.2.8_A3_T7.js");
        }

        [Test(Description = "Execute /(aa).+\\1/.exec(\"aabcdaabcd\") and check results")]
        public void S15_10_2_8_A3_T8()
        {
            RunFile("S15.10.2.8_A3_T8.js");
        }

        [Test(Description = "Execute /(.{2}).+\\1/.exec(\"aabcdaabcd\") and check results")]
        public void S15_10_2_8_A3_T9()
        {
            RunFile("S15.10.2.8_A3_T9.js");
        }

        [Test(Description = "Execute /ab.de/.exec(\"abcde\") and check results")]
        public void S15_10_2_8_A4_T1()
        {
            RunFile("S15.10.2.8_A4_T1.js");
        }

        [Test(Description = "Execute /.+/.exec(\"line 1\\nline 2\") and check results")]
        public void S15_10_2_8_A4_T2()
        {
            RunFile("S15.10.2.8_A4_T2.js");
        }

        [Test(Description = "Execute /.*a.* /.exec(\"this is a test\") and check results")]
        public void S15_10_2_8_A4_T3()
        {
            RunFile("S15.10.2.8_A4_T3.js");
        }

        [Test(Description = "Execute /.+/.exec(\"this is a *&^%$# test\") and check results")]
        public void S15_10_2_8_A4_T4()
        {
            RunFile("S15.10.2.8_A4_T4.js");
        }

        [Test(Description = "Execute /.+/.exec(\"....\") and check results")]
        public void S15_10_2_8_A4_T5()
        {
            RunFile("S15.10.2.8_A4_T5.js");
        }

        [Test(Description = "Execute /.+/.exec(\"abcdefghijklmnopqrstuvwxyz\") and check results")]
        public void S15_10_2_8_A4_T6()
        {
            RunFile("S15.10.2.8_A4_T6.js");
        }

        [Test(Description = "Execute /.+/.exec(\"ABCDEFGHIJKLMNOPQRSTUVWXYZ\") and check results")]
        public void S15_10_2_8_A4_T7()
        {
            RunFile("S15.10.2.8_A4_T7.js");
        }

        [Test(Description = "Execute /.+/.exec(\"`1234567890-=~!@#$%^&*()_+\") and check results")]
        public void S15_10_2_8_A4_T8()
        {
            RunFile("S15.10.2.8_A4_T8.js");
        }

        [Test(Description = "Execute /.+/.exec(\"|\\\\[{]};:\\\"\\',<>.?/\") and check results")]
        public void S15_10_2_8_A4_T9()
        {
            RunFile("S15.10.2.8_A4_T9.js");
        }

        [Test(Description = "Execute /[a-z]+/ig.exec(\"ABC def ghi\") and check results")]
        public void S15_10_2_8_A5_T1()
        {
            RunFile("S15.10.2.8_A5_T1.js");
        }

        [Test(Description = "Execute /[a-z]+/.exec(\"ABC def ghi\") and check results")]
        public void S15_10_2_8_A5_T2()
        {
            RunFile("S15.10.2.8_A5_T2.js");
        }
    }
}
