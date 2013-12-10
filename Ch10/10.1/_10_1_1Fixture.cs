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

namespace Jint.Test262.Ch10._10_1
{
    [TestFixture]
    public class _10_1_1Fixture : Test262Fixture
    {
        public _10_1_1Fixture()
            : base("ch10\\10.1\\10.1.1")
        {
        }

        [Test(Description = "Strict Mode - Use Strict Directive Prologue is 'use  strict'; which contains two space between 'use' and 'strict'")]
        public void _10_1_1_1_s()
        {
            RunFile("10.1.1-1-s.js");
        }

        [Test(Description = "Strict Mode - Use Strict Directive Prologue is ''USE STRICT';' in which all characters are uppercase")]
        public void _10_1_1_10_s()
        {
            RunFile("10.1.1-10-s.js");
        }

        [Test(Description = "Strict Mode - Eval code is strict code with a Use Strict Directive at the beginning of the block")]
        public void _10_1_1_11_s()
        {
            RunFile("10.1.1-11-s.js");
        }

        [Test(Description = "Strict Mode - Eval code is strict eval code with a Use Strict Directive in the middle of the block")]
        public void _10_1_1_12_s()
        {
            RunFile("10.1.1-12-s.js");
        }

        [Test(Description = "Strict Mode - Eval code is strict eval code with a Use Strict Directive at the end of the block")]
        public void _10_1_1_13_s()
        {
            RunFile("10.1.1-13-s.js");
        }

        [Test(Description = "Strict Mode - The call to eval function is contained in a Strict Mode block")]
        public void _10_1_1_14_s()
        {
            RunFile("10.1.1-14-s.js");
        }

        [Test(Description = "Strict Mode - Function code that is part of a FunctionDeclaration is strict function code if FunctionDeclaration is contained in use strict")]
        public void _10_1_1_15_s()
        {
            RunFile("10.1.1-15-s.js");
        }

        [Test(Description = "Strict Mode - Function code that is part of a FunctionExpression is strict function code if FunctionExpression is contained in use strict")]
        public void _10_1_1_16_s()
        {
            RunFile("10.1.1-16-s.js");
        }

        [Test(Description = "Strict Mode - Function code that is part of a Accessor PropertyAssignment is in Strict Mode if Accessor PropertyAssignment is contained in use strict(getter)")]
        public void _10_1_1_17_s()
        {
            RunFile("10.1.1-17-s.js");
        }

        [Test(Description = "Strict Mode - Function code that is part of a Accessor PropertyAssignment is in Strict Mode if Accessor PropertyAssignment is contained in use strict(setter)")]
        public void _10_1_1_18_s()
        {
            RunFile("10.1.1-18-s.js");
        }

        [Test(Description = "Strict Mode - Function code of a FunctionDeclaration contains Use Strict Directive which appears at the start of the block")]
        public void _10_1_1_19_s()
        {
            RunFile("10.1.1-19-s.js");
        }

        [Test(Description = "Strict Mode - Use Strict Directive Prologue is ''use strict'' which lost the last character ';'")]
        public void _10_1_1_2_s()
        {
            RunFile("10.1.1-2-s.js");
        }

        [Test(Description = "Strict Mode - Function code of a FunctionDeclaration contains Use Strict Directive which appears in the middle of the block")]
        public void _10_1_1_20_s()
        {
            RunFile("10.1.1-20-s.js");
        }

        [Test(Description = "Strict Mode - Function code of a FunctionDeclaration contains Use Strict Directive which appears at the end of the block")]
        public void _10_1_1_21_s()
        {
            RunFile("10.1.1-21-s.js");
        }

        [Test(Description = "Strict Mode - Function code of a FunctionExpression contains Use Strict Directive which appears at the start of the block")]
        public void _10_1_1_22_s()
        {
            RunFile("10.1.1-22-s.js");
        }

        [Test(Description = "Strict Mode - Function code of a FunctionExpression contains Use Strict Directive which appears in the middle of the block")]
        public void _10_1_1_23_s()
        {
            RunFile("10.1.1-23-s.js");
        }

        [Test(Description = "Strict Mode - Function code of a FunctionExpression contains Use Strict Directive which appears at the end of the block")]
        public void _10_1_1_24_s()
        {
            RunFile("10.1.1-24-s.js");
        }

        [Test(Description = "Strict Mode - Function code of Accessor PropertyAssignment contains Use Strict Directive which appears at the start of the block(getter)")]
        public void _10_1_1_25_s()
        {
            RunFile("10.1.1-25-s.js");
        }

        [Test(Description = "Strict Mode - Function code of Accessor PropertyAssignment contains Use Strict Directive which appears at the start of the block(setter)")]
        public void _10_1_1_26_s()
        {
            RunFile("10.1.1-26-s.js");
        }

        [Test(Description = "Strict Mode - Function code of Accessor PropertyAssignment contains Use Strict Directive which appears in the middle of the block(getter)")]
        public void _10_1_1_27_s()
        {
            RunFile("10.1.1-27-s.js");
        }

        [Test(Description = "Strict Mode - Function code of Accessor PropertyAssignment contains Use Strict Directive which appears at the end of the block(setter)")]
        public void _10_1_1_28_s()
        {
            RunFile("10.1.1-28-s.js");
        }

        [Test(Description = "Strict Mode - The built-in Function constructor is contained in use strict code")]
        public void _10_1_1_29_s()
        {
            RunFile("10.1.1-29-s.js");
        }

        [Test(Description = "Strict Mode - Use Strict Directive Prologue is ''use strict'' which lost the last character ';'")]
        [ExpectedException]
        public void _10_1_1_2gs()
        {
            RunFile("10.1.1-2gs.js");
        }

        [Test(Description = "Strict Mode - Use Strict Directive Prologue is '' use strict';' which the first character is space")]
        public void _10_1_1_3_s()
        {
            RunFile("10.1.1-3-s.js");
        }

        [Test(Description = "Strict Mode - Function code of built-in Function constructor contains Use Strict Directive which appears at the start of the block")]
        public void _10_1_1_30_s()
        {
            RunFile("10.1.1-30-s.js");
        }

        [Test(Description = "Strict Mode - Function code of built-in Function constructor contains Use Strict Directive which appears in the middle of the block")]
        public void _10_1_1_31_s()
        {
            RunFile("10.1.1-31-s.js");
        }

        [Test(Description = "Strict Mode - Function code of built-in Function constructor contains Use Strict Directive which appears at the end of the block")]
        public void _10_1_1_32_s()
        {
            RunFile("10.1.1-32-s.js");
        }

        [Test(Description = "Strict Mode - Use Strict Directive Prologue is ''use strict ';' which the last character is space")]
        public void _10_1_1_4_s()
        {
            RunFile("10.1.1-4-s.js");
        }

        [Test(Description = "Strict Mode - Use Strict Directive Prologue is ''use strict';' which appears at the beginning of the block")]
        public void _10_1_1_5_s()
        {
            RunFile("10.1.1-5-s.js");
        }

        [Test(Description = "Strict Mode - Use Strict Directive Prologue is ''use strict';' which appears at the start of the code")]
        [ExpectedException]
        public void _10_1_1_5gs()
        {
            RunFile("10.1.1-5gs.js");
        }

        [Test(Description = "Strict Mode - Use Strict Directive Prologue is ''use strict';' which appears in the middle of the block")]
        public void _10_1_1_6_s()
        {
            RunFile("10.1.1-6-s.js");
        }

        [Test(Description = "Strict Mode - Use Strict Directive Prologue is ''use strict';' which appears at the end of the block")]
        public void _10_1_1_7_s()
        {
            RunFile("10.1.1-7-s.js");
        }

        [Test(Description = "Strict Mode - Use Strict Directive Prologue is ''use strict';' which appears twice in the directive prologue")]
        public void _10_1_1_8_s()
        {
            RunFile("10.1.1-8-s.js");
        }

        [Test(Description = "Strict Mode - Use Strict Directive Prologue is ''use strict';' which appears twice in the code")]
        [ExpectedException]
        public void _10_1_1_8gs()
        {
            RunFile("10.1.1-8gs.js");
        }

        [Test(Description = "Strict Mode - Use Strict Directive Prologue is ''Use strict';' in which the first character is uppercase")]
        public void _10_1_1_9_s()
        {
            RunFile("10.1.1-9-s.js");
        }
    }
}