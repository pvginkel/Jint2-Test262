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
    public class _15_10_2_6Fixture : Test262Fixture
    {
        public _15_10_2_6Fixture()
            : base("ch15\\15.10\\15.10.2\\15.10.2.6")
        {
        }

        [Test(Description = "Execute /s$/.test(\"pairs\\nmakes\\tdouble\") and check results")]
        public void S15_10_2_6_A1_T1()
        {
            RunFile("S15.10.2.6_A1_T1.js");
        }

        [Test(Description = "Execute /e$/.exec(\"pairs\\nmakes\\tdouble\") and check results")]
        public void S15_10_2_6_A1_T2()
        {
            RunFile("S15.10.2.6_A1_T2.js");
        }

        [Test(Description = "Execute /s$/m.exec(\"pairs\\nmakes\\tdouble\") and check results")]
        public void S15_10_2_6_A1_T3()
        {
            RunFile("S15.10.2.6_A1_T3.js");
        }

        [Test(Description = "Execute /[^e]$/mg.exec(\"pairs\\nmakes\\tdouble\") and check results")]
        public void S15_10_2_6_A1_T4()
        {
            RunFile("S15.10.2.6_A1_T4.js");
        }

        [Test(Description = "Execute /es$/mg.exec(\"pairs\\nmakes\\tdoubl\\u0065s\") and check results")]
        public void S15_10_2_6_A1_T5()
        {
            RunFile("S15.10.2.6_A1_T5.js");
        }

        [Test(Description = "Execute /^m/.test(\"pairs\\nmakes\\tdouble\") and check results")]
        public void S15_10_2_6_A2_T1()
        {
            RunFile("S15.10.2.6_A2_T1.js");
        }

        [Test(Description = "Execute /^\\d+/m.exec(\"abc\\n123xyz\") and check results")]
        public void S15_10_2_6_A2_T10()
        {
            RunFile("S15.10.2.6_A2_T10.js");
        }

        [Test(Description = "Execute /^m/m.exec(\"pairs\\nmakes\\tdouble\") and check results")]
        public void S15_10_2_6_A2_T2()
        {
            RunFile("S15.10.2.6_A2_T2.js");
        }

        [Test(Description = "Execute /^p[a-z]/.exec(\"pairs\\nmakes\\tdouble\\npesos\") and check results")]
        public void S15_10_2_6_A2_T3()
        {
            RunFile("S15.10.2.6_A2_T3.js");
        }

        [Test(Description = "Execute /^p[a-z]/m.exec(\"pairs\\nmakes\\tdouble\\npesos\") and check results")]
        public void S15_10_2_6_A2_T4()
        {
            RunFile("S15.10.2.6_A2_T4.js");
        }

        [Test(Description = "Execute /^[^p]/m.exec(\"pairs\\nmakes\\tdouble\\npesos\") and check results")]
        public void S15_10_2_6_A2_T5()
        {
            RunFile("S15.10.2.6_A2_T5.js");
        }

        [Test(Description = "Execute /^ab/.exec(\"abcde\") and check results")]
        public void S15_10_2_6_A2_T6()
        {
            RunFile("S15.10.2.6_A2_T6.js");
        }

        [Test(Description = "Execute /^..^e/.test(\"ab\\ncde\") and check results")]
        public void S15_10_2_6_A2_T7()
        {
            RunFile("S15.10.2.6_A2_T7.js");
        }

        [Test(Description = "Execute /^xxx/.test(\"yyyyy\") and check results")]
        public void S15_10_2_6_A2_T8()
        {
            RunFile("S15.10.2.6_A2_T8.js");
        }

        [Test(Description = "Execute /^\\^+/.exec(\"^^^x\") and check results")]
        public void S15_10_2_6_A2_T9()
        {
            RunFile("S15.10.2.6_A2_T9.js");
        }

        [Test(Description = "Execute /\\bp/.exec(\"pilot\\nsoviet robot\\topenoffice\") and check results")]
        public void S15_10_2_6_A3_T1()
        {
            RunFile("S15.10.2.6_A3_T1.js");
        }

        [Test(Description = "Execute /\\brobot\\b/.exec(\"pilot\\nsoviet robot\\topenoffice\") and check results")]
        public void S15_10_2_6_A3_T10()
        {
            RunFile("S15.10.2.6_A3_T10.js");
        }

        [Test(Description = "Execute /\\b\\w{5}\\b/.exec(\"pilot\\nsoviet robot\\topenoffice\") and check results")]
        public void S15_10_2_6_A3_T11()
        {
            RunFile("S15.10.2.6_A3_T11.js");
        }

        [Test(Description = "Execute /\\bop/.exec(\"pilot\\nsoviet robot\\topenoffice\") and check results")]
        public void S15_10_2_6_A3_T12()
        {
            RunFile("S15.10.2.6_A3_T12.js");
        }

        [Test(Description = "Execute /op\\b/.test(\"pilot\\nsoviet robot\\topenoffice\") and check results")]
        public void S15_10_2_6_A3_T13()
        {
            RunFile("S15.10.2.6_A3_T13.js");
        }

        [Test(Description = "Execute /e\\b/.exec(\"pilot\\nsoviet robot\\topenoffic\\u0065\") and check results")]
        public void S15_10_2_6_A3_T14()
        {
            RunFile("S15.10.2.6_A3_T14.js");
        }

        [Test(Description = "Execute /\\be/.test(\"pilot\\nsoviet robot\\topenoffic\\u0065\") and check results")]
        public void S15_10_2_6_A3_T15()
        {
            RunFile("S15.10.2.6_A3_T15.js");
        }

        [Test(Description = "Execute /ot\\b/.exec(\"pilot\\nsoviet robot\\topenoffice\") and check results")]
        public void S15_10_2_6_A3_T2()
        {
            RunFile("S15.10.2.6_A3_T2.js");
        }

        [Test(Description = "Execute /\\bot/.test(\"pilot\\nsoviet robot\\topenoffice\") and check results")]
        public void S15_10_2_6_A3_T3()
        {
            RunFile("S15.10.2.6_A3_T3.js");
        }

        [Test(Description = "Execute /\\bso/.exec(\"pilot\\nsoviet robot\\topenoffice\") and check results")]
        public void S15_10_2_6_A3_T4()
        {
            RunFile("S15.10.2.6_A3_T4.js");
        }

        [Test(Description = "Execute /so\\b/.test(\"pilot\\nsoviet robot\\topenoffice\") and check results")]
        public void S15_10_2_6_A3_T5()
        {
            RunFile("S15.10.2.6_A3_T5.js");
        }

        [Test(Description = "Execute /[^o]t\\b/.exec(\"pilOt\\nsoviet robot\\topenoffice\") and check results")]
        public void S15_10_2_6_A3_T6()
        {
            RunFile("S15.10.2.6_A3_T6.js");
        }

        [Test(Description = "Execute /[^o]t\\b/i.exec(\"pilOt\\nsoviet robot\\topenoffice\") and check results")]
        public void S15_10_2_6_A3_T7()
        {
            RunFile("S15.10.2.6_A3_T7.js");
        }

        [Test(Description = "Execute /\\bro/.exec(\"pilot\\nsoviet robot\\topenoffice\") and check results")]
        public void S15_10_2_6_A3_T8()
        {
            RunFile("S15.10.2.6_A3_T8.js");
        }

        [Test(Description = "Execute /r\\b/.exec(\"pilot\\nsoviet robot\\topenoffice\") and check results")]
        public void S15_10_2_6_A3_T9()
        {
            RunFile("S15.10.2.6_A3_T9.js");
        }

        [Test(Description = "Execute /\\Bevil\\B/.exec(\"devils arise\\tfor\\nevil\") and check results")]
        public void S15_10_2_6_A4_T1()
        {
            RunFile("S15.10.2.6_A4_T1.js");
        }

        [Test(Description = "Execute /[f-z]e\\B/.exec(\"devils arise\\tfor\\nevil\") and check results")]
        public void S15_10_2_6_A4_T2()
        {
            RunFile("S15.10.2.6_A4_T2.js");
        }

        [Test(Description = "Execute /\\Bo\\B/.exec(\"devils arise\\tfor\\nevil\") and check results")]
        public void S15_10_2_6_A4_T3()
        {
            RunFile("S15.10.2.6_A4_T3.js");
        }

        [Test(Description = "Execute /\\B\\w\\B/.exec(\"devils arise\\tfor\\nevil\") and check results")]
        public void S15_10_2_6_A4_T4()
        {
            RunFile("S15.10.2.6_A4_T4.js");
        }

        [Test(Description = "Execute /\\w\\B/.exec(\"devils arise\\tfor\\nevil\") and check results")]
        public void S15_10_2_6_A4_T5()
        {
            RunFile("S15.10.2.6_A4_T5.js");
        }

        [Test(Description = "Execute /\\B\\w/.exec(\"devils arise\\tfor\\nevil\") and check results")]
        public void S15_10_2_6_A4_T6()
        {
            RunFile("S15.10.2.6_A4_T6.js");
        }

        [Test(Description = "Execute /\\B\\[^z]{4}\\B/.test(\"devil arise\\tforzzx\\nevils\") and check results")]
        public void S15_10_2_6_A4_T7()
        {
            RunFile("S15.10.2.6_A4_T7.js");
        }

        [Test(Description = "Execute /\\B\\w{4}\\B/.exec(\"devil arise\\tforzzx\\nevils\") and check results")]
        public void S15_10_2_6_A4_T8()
        {
            RunFile("S15.10.2.6_A4_T8.js");
        }

        [Test(Description = "Execute /^^^^^^^robot$$$$/.exec(\"robot\") and check results")]
        public void S15_10_2_6_A5_T1()
        {
            RunFile("S15.10.2.6_A5_T1.js");
        }

        [Test(Description = "Execute /\\B\\B\\B\\B\\B\\Bbot\\b\\b\\b\\b\\b\\b\\b/.exec(\"robot wall-e\") and check results")]
        public void S15_10_2_6_A5_T2()
        {
            RunFile("S15.10.2.6_A5_T2.js");
        }

        [Test(Description = "while asterix is non greedy it is run till the end because of dollar assertion")]
        public void S15_10_2_6_A6_T1()
        {
            RunFile("S15.10.2.6_A6_T1.js");
        }

        [Test(Description = "Execute /^.*?/.exec(\"Hello World\") and check results")]
        public void S15_10_2_6_A6_T2()
        {
            RunFile("S15.10.2.6_A6_T2.js");
        }

        [Test(Description = "while asterix is non greedy it is run till matches end or colon")]
        public void S15_10_2_6_A6_T3()
        {
            RunFile("S15.10.2.6_A6_T3.js");
        }

        [Test(Description = "Execute /^.*(:|$)/.exec(\"Hello: World\") and check results")]
        public void S15_10_2_6_A6_T4()
        {
            RunFile("S15.10.2.6_A6_T4.js");
        }
    }
}
