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

namespace Jint.Test262.Ch07
{
    [TestFixture]
    public class _7_9Fixture : Test262Fixture
    {
        public _7_9Fixture()
            : base("ch07\\7.9")
        {
        }

        [Test(Description = "Try use continue \\n Label construction")]
        public void S7_9_A1()
        {
            RunFile("S7.9_A1.js");
        }

        [Test(Description = "Checking if execution of \"1 * {}\" passes")]
        public void S7_9_A10_T1()
        {
            RunFile("S7.9_A10_T1.js");
        }

        [Test(Description = "Checking if execution of \"{a:1 \\n} 3\" passes")]
        public void S7_9_A10_T10()
        {
            RunFile("S7.9_A10_T10.js");
        }

        [Test(Description = "Checking if execution of \"{a:1 \\n} \\n 3\" passes")]
        public void S7_9_A10_T11()
        {
            RunFile("S7.9_A10_T11.js");
        }

        [Test(Description = "Checking if execution of \"{ \\n a: \\n 1 \\n } \\n 3\" passes")]
        public void S7_9_A10_T12()
        {
            RunFile("S7.9_A10_T12.js");
        }

        [Test(Description = "Checking if execution of \"{}*1\" fails")]
        [ExpectedException]
        public void S7_9_A10_T2()
        {
            RunFile("S7.9_A10_T2.js");
        }

        [Test(Description = "Checking if execution of \"({}) * 1\" passes")]
        public void S7_9_A10_T3()
        {
            RunFile("S7.9_A10_T3.js");
        }

        [Test(Description = "Checking if execution of \"({};)*1\" fails")]
        [ExpectedException]
        public void S7_9_A10_T4()
        {
            RunFile("S7.9_A10_T4.js");
        }

        [Test(Description = "Checking if execution of \"( \\n {} \\n ) * 1\" passes")]
        public void S7_9_A10_T5()
        {
            RunFile("S7.9_A10_T5.js");
        }

        [Test(Description = "Checking if execution of \"{} \\n * 1\" fails")]
        [ExpectedException]
        public void S7_9_A10_T6()
        {
            RunFile("S7.9_A10_T6.js");
        }

        [Test(Description = "Checking if execution of \"{1} 2\" passes")]
        public void S7_9_A10_T7()
        {
            RunFile("S7.9_A10_T7.js");
        }

        [Test(Description = "Checking if execution of \"{1 2} 3\" fails")]
        [ExpectedException]
        public void S7_9_A10_T8()
        {
            RunFile("S7.9_A10_T8.js");
        }

        [Test(Description = "Checking if execution of \"{1 \\n 2} 3\" passes")]
        public void S7_9_A10_T9()
        {
            RunFile("S7.9_A10_T9.js");
        }

        [Test(Description = "Use if (false) x = 1 (without semicolon) and check x")]
        public void S7_9_A11_T1()
        {
            RunFile("S7.9_A11_T1.js");
        }

        [Test(Description = "Use if (false) {x = 1} else {x=-1} and check x")]
        public void S7_9_A11_T10()
        {
            RunFile("S7.9_A11_T10.js");
        }

        [Test(Description = "Use if (false) {{x = 1};} \\n else x=-1 and check x")]
        public void S7_9_A11_T11()
        {
            RunFile("S7.9_A11_T11.js");
        }

        [Test(Description = "Use if (false) \\n x = 1 and check x")]
        public void S7_9_A11_T2()
        {
            RunFile("S7.9_A11_T2.js");
        }

        [Test(Description = "Use if (false);\\n x = 1 and check x")]
        public void S7_9_A11_T3()
        {
            RunFile("S7.9_A11_T3.js");
        }

        [Test(Description = "Checking if execution of \"if (false) x = 1 else x = -1\" fails")]
        [ExpectedException]
        public void S7_9_A11_T4()
        {
            RunFile("S7.9_A11_T4.js");
        }

        [Test(Description = "Use if (false) x = 1; else x=-1 and check x")]
        public void S7_9_A11_T5()
        {
            RunFile("S7.9_A11_T5.js");
        }

        [Test(Description = "Use if (false) x = 1 \\n else x=-1 and check x")]
        public void S7_9_A11_T6()
        {
            RunFile("S7.9_A11_T6.js");
        }

        [Test(Description = "Use if (false) x = 1; \\n else x=-1 and check x")]
        public void S7_9_A11_T7()
        {
            RunFile("S7.9_A11_T7.js");
        }

        [Test(Description = "Use if (false) {x = 1}; \\n else x=-1 and check x")]
        [ExpectedException]
        public void S7_9_A11_T8()
        {
            RunFile("S7.9_A11_T8.js");
        }

        [Test(Description = "Use if (false) {x = 1} \\n else x=-1 and check x")]
        public void S7_9_A11_T9()
        {
            RunFile("S7.9_A11_T9.js");
        }

        [Test(Description = "Try use break \\n Label construction")]
        public void S7_9_A2()
        {
            RunFile("S7.9_A2.js");
        }

        [Test(Description = "Try use return \\n Expression construction")]
        public void S7_9_A3()
        {
            RunFile("S7.9_A3.js");
        }

        [Test(Description = "Try use Throw \\n Expression construction")]
        [ExpectedException]
        public void S7_9_A4()
        {
            RunFile("S7.9_A4.js");
        }

        [Test(Description = "Try use Variable \\n ++ construction")]
        [ExpectedException]
        public void S7_9_A5_1_T1()
        {
            RunFile("S7.9_A5.1_T1.js");
        }

        [Test(Description = "Try use Variable1 \\n ++Variable2 construction")]
        public void S7_9_A5_2_T1()
        {
            RunFile("S7.9_A5.2_T1.js");
        }

        [Test(Description = "Try use Variable \\n -- construction")]
        [ExpectedException]
        public void S7_9_A5_3_T1()
        {
            RunFile("S7.9_A5.3_T1.js");
        }

        [Test(Description = "Try use Variable1 \\n --Variable2 construction")]
        public void S7_9_A5_4_T1()
        {
            RunFile("S7.9_A5.4_T1.js");
        }

        [Test(Description = "Try use 1 + function_name\\n(2 + 3) construction")]
        public void S7_9_A5_5_T1()
        {
            RunFile("S7.9_A5.5_T1.js");
        }

        [Test(Description = "Try use function f(o) {o.x = 1; return o;}; \\n (new Object()).x; construction")]
        public void S7_9_A5_5_T2()
        {
            RunFile("S7.9_A5.5_T2.js");
        }

        [Test(Description = "Try use function f(o) {o.x = 1; return o;} \\n (new Object()).x; construction")]
        public void S7_9_A5_5_T3()
        {
            RunFile("S7.9_A5.5_T3.js");
        }

        [Test(Description = "Insert some LineTerminators into function body")]
        public void S7_9_A5_5_T4()
        {
            RunFile("S7.9_A5.5_T4.js");
        }

        [Test(Description = "Insert some LineTerminators into rerutn expression;")]
        public void S7_9_A5_5_T5()
        {
            RunFile("S7.9_A5.5_T5.js");
        }

        [Test(Description = "Try use Variable1 \\n ++ \\n Variable2 construction")]
        public void S7_9_A5_6_T1()
        {
            RunFile("S7.9_A5.6_T1.js");
        }

        [Test(Description = "Try use Variable1 \\n -- \\n Variable2 construction")]
        public void S7_9_A5_6_T2()
        {
            RunFile("S7.9_A5.6_T2.js");
        }

        [Test(Description = "Try use Variable1 \\n ++ \\n ++ \\n Variable2 construction")]
        [ExpectedException]
        public void S7_9_A5_7_T1()
        {
            RunFile("S7.9_A5.7_T1.js");
        }

        [Test(Description = "Try use Variable1 \\n + \\n ++ \\n Variable2 construction")]
        public void S7_9_A5_8_T1()
        {
            RunFile("S7.9_A5.8_T1.js");
        }

        [Test(Description = "Try use Variable1 (different combinations of three +) Variable2 construction")]
        public void S7_9_A5_9_T1()
        {
            RunFile("S7.9_A5.9_T1.js");
        }

        [Test(Description = "for( Empty two semicolons and \\n)")]
        public void S7_9_A6_1_T1()
        {
            RunFile("S7.9_A6.1_T1.js");
        }

        [Test(Description = "for (false \\n two semicolons false \\n)")]
        public void S7_9_A6_1_T10()
        {
            RunFile("S7.9_A6.1_T10.js");
        }

        [Test(Description = "for (false \\n semicolon \\n semicolon \\n)")]
        public void S7_9_A6_1_T11()
        {
            RunFile("S7.9_A6.1_T11.js");
        }

        [Test(Description = "for (false \\n semicolon false \\n semicolon \\n)")]
        public void S7_9_A6_1_T12()
        {
            RunFile("S7.9_A6.1_T12.js");
        }

        [Test(Description = "for (false \\n semicolon false \\n semicolon false \\n)")]
        public void S7_9_A6_1_T13()
        {
            RunFile("S7.9_A6.1_T13.js");
        }

        [Test(Description = "for (semicolon \\n semicolon \\n)")]
        public void S7_9_A6_1_T2()
        {
            RunFile("S7.9_A6.1_T2.js");
        }

        [Test(Description = "for (\\n two semicolons \\n)")]
        public void S7_9_A6_1_T3()
        {
            RunFile("S7.9_A6.1_T3.js");
        }

        [Test(Description = "for( \\n semicolon \\n semicolon \\n)")]
        public void S7_9_A6_1_T4()
        {
            RunFile("S7.9_A6.1_T4.js");
        }

        [Test(Description = "for ( \\n semicolon \\n\\n semicolon \\n)")]
        public void S7_9_A6_1_T5()
        {
            RunFile("S7.9_A6.1_T5.js");
        }

        [Test(Description = "for(false semicolon false semicolon false \\n)")]
        public void S7_9_A6_1_T6()
        {
            RunFile("S7.9_A6.1_T6.js");
        }

        [Test(Description = "for (false semicolon false \\n semicolon \\n)")]
        public void S7_9_A6_1_T7()
        {
            RunFile("S7.9_A6.1_T7.js");
        }

        [Test(Description = "for (false semicolon false \\n semicolon false \\n)")]
        public void S7_9_A6_1_T8()
        {
            RunFile("S7.9_A6.1_T8.js");
        }

        [Test(Description = "for (false \\n two semicolons \\n)")]
        public void S7_9_A6_1_T9()
        {
            RunFile("S7.9_A6.1_T9.js");
        }

        [Test(Description = "For header is (semicolon \\n)")]
        [ExpectedException]
        public void S7_9_A6_2_T1()
        {
            RunFile("S7.9_A6.2_T1.js");
        }

        [Test(Description = "For header is (\\n false \\n semicolon)")]
        [ExpectedException]
        public void S7_9_A6_2_T10()
        {
            RunFile("S7.9_A6.2_T10.js");
        }

        [Test(Description = "For header is (\\n semicolon \\n)")]
        [ExpectedException]
        public void S7_9_A6_2_T2()
        {
            RunFile("S7.9_A6.2_T2.js");
        }

        [Test(Description = "For header is (\\n semicolon)")]
        [ExpectedException]
        public void S7_9_A6_2_T3()
        {
            RunFile("S7.9_A6.2_T3.js");
        }

        [Test(Description = "For header is (\\n \\n semicolon)")]
        [ExpectedException]
        public void S7_9_A6_2_T4()
        {
            RunFile("S7.9_A6.2_T4.js");
        }

        [Test(Description = "For header is (false semicolon false\\n)")]
        [ExpectedException]
        public void S7_9_A6_2_T5()
        {
            RunFile("S7.9_A6.2_T5.js");
        }

        [Test(Description = "For header is (false semicolon \\n false)")]
        [ExpectedException]
        public void S7_9_A6_2_T6()
        {
            RunFile("S7.9_A6.2_T6.js");
        }

        [Test(Description = "For header is (false \\n semicolon \\n)")]
        [ExpectedException]
        public void S7_9_A6_2_T7()
        {
            RunFile("S7.9_A6.2_T7.js");
        }

        [Test(Description = "For header is (false \\n semicolon false \\n)")]
        [ExpectedException]
        public void S7_9_A6_2_T8()
        {
            RunFile("S7.9_A6.2_T8.js");
        }

        [Test(Description = "For header is (\\n semicolon false)")]
        [ExpectedException]
        public void S7_9_A6_2_T9()
        {
            RunFile("S7.9_A6.2_T9.js");
        }

        [Test(Description = "For header is (\\n)")]
        [ExpectedException]
        public void S7_9_A6_3_T1()
        {
            RunFile("S7.9_A6.3_T1.js");
        }

        [Test(Description = "For header is (\\n \\n)")]
        [ExpectedException]
        public void S7_9_A6_3_T2()
        {
            RunFile("S7.9_A6.3_T2.js");
        }

        [Test(Description = "For header is (\\n \\n \\n)")]
        [ExpectedException]
        public void S7_9_A6_3_T3()
        {
            RunFile("S7.9_A6.3_T3.js");
        }

        [Test(Description = "For header is (\\n false \\n)")]
        [ExpectedException]
        public void S7_9_A6_3_T4()
        {
            RunFile("S7.9_A6.3_T4.js");
        }

        [Test(Description = "For header is (false \\n false \\n)")]
        [ExpectedException]
        public void S7_9_A6_3_T5()
        {
            RunFile("S7.9_A6.3_T5.js");
        }

        [Test(Description = "For header is (\\n false \\n false \\n)")]
        [ExpectedException]
        public void S7_9_A6_3_T6()
        {
            RunFile("S7.9_A6.3_T6.js");
        }

        [Test(Description = "For header is (\\n false \\n false \\n false \\n)")]
        [ExpectedException]
        public void S7_9_A6_3_T7()
        {
            RunFile("S7.9_A6.3_T7.js");
        }

        [Test(Description = "Three semicolons. For header is (false semicolon false semicolon false semicolon)")]
        [ExpectedException]
        public void S7_9_A6_4_T1()
        {
            RunFile("S7.9_A6.4_T1.js");
        }

        [Test(Description = "Three semicolons. For header is (false semicolon false two semicolons false)")]
        [ExpectedException]
        public void S7_9_A6_4_T2()
        {
            RunFile("S7.9_A6.4_T2.js");
        }

        [Test(Description = "Checking if execution of \"var x \\n = 1\" passes")]
        public void S7_9_A7_T1()
        {
            RunFile("S7.9_A7_T1.js");
        }

        [Test(Description = "Checking if execution of \"var x = \\n 1\" passes")]
        public void S7_9_A7_T2()
        {
            RunFile("S7.9_A7_T2.js");
        }

        [Test(Description = "Checking if execution of \"var x \\n x = 1\" passes")]
        public void S7_9_A7_T3()
        {
            RunFile("S7.9_A7_T3.js");
        }

        [Test(Description = "Checking if execution of \"var \\n x\" passes")]
        public void S7_9_A7_T4()
        {
            RunFile("S7.9_A7_T4.js");
        }

        [Test(Description = "Checking if execution of \"var \\n x \\n = \\n 1\" passes")]
        public void S7_9_A7_T5()
        {
            RunFile("S7.9_A7_T5.js");
        }

        [Test(Description = "Checking if execution of \"var x, \\n y\" passes")]
        public void S7_9_A7_T6()
        {
            RunFile("S7.9_A7_T6.js");
        }

        [Test(Description = "Checking if execution of \"var x \\n y\" passes")]
        [ExpectedException]
        public void S7_9_A7_T7()
        {
            RunFile("S7.9_A7_T7.js");
        }

        [Test(Description = "Checking if execution of \"var x \\n ,y\" passes")]
        public void S7_9_A7_T8()
        {
            RunFile("S7.9_A7_T8.js");
        }

        [Test(Description = "Checking if execution of \"var x \\n ,y = 1\" passes")]
        public void S7_9_A7_T9()
        {
            RunFile("S7.9_A7_T9.js");
        }

        [Test(Description = "Checking if execution of one semicolon passes")]
        public void S7_9_A8_T1()
        {
            RunFile("S7.9_A8_T1.js");
        }

        [Test(Description = "Checking if execution of some semicolons with LineTerminators pases")]
        public void S7_9_A8_T2()
        {
            RunFile("S7.9_A8_T2.js");
        }

        [Test(Description = "Checking if execution of some semicolons without LineTerminators passes")]
        public void S7_9_A8_T3()
        {
            RunFile("S7.9_A8_T3.js");
        }

        [Test(Description = "Checking if execution of some semicolons with LineTerminators and numbers passes")]
        public void S7_9_A8_T4()
        {
            RunFile("S7.9_A8_T4.js");
        }

        [Test(Description = "Checking if execution of some semicolons without LineTerminators but with numbers passes")]
        public void S7_9_A8_T5()
        {
            RunFile("S7.9_A8_T5.js");
        }

        [Test(Description = "Execute do { \\n }while(false)")]
        public void S7_9_A9_T1()
        {
            RunFile("S7.9_A9_T1.js");
        }

        [Test(Description = "Execute do; while(false) \\n true")]
        public void S7_9_A9_T2()
        {
            RunFile("S7.9_A9_T2.js");
        }

        [Test(Description = "Execute do { \\n ; \\n }while((false) \\n )")]
        public void S7_9_A9_T5()
        {
            RunFile("S7.9_A9_T5.js");
        }

        [Test(Description = "Execute do \\n while(false)")]
        [ExpectedException]
        public void S7_9_A9_T6()
        {
            RunFile("S7.9_A9_T6.js");
        }

        [Test(Description = "Execute do \\n\\n while(false)")]
        [ExpectedException]
        public void S7_9_A9_T7()
        {
            RunFile("S7.9_A9_T7.js");
        }

        [Test(Description = "Execute do {}; \\n while(false)")]
        [ExpectedException]
        public void S7_9_A9_T8()
        {
            RunFile("S7.9_A9_T8.js");
        }

        [Test(Description = "Execute do {} \\n while(false)")]
        public void S7_9_A9_T9()
        {
            RunFile("S7.9_A9_T9.js");
        }
    }
}
