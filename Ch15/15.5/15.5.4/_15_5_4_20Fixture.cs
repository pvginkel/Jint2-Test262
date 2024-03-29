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

namespace Jint.Test262.Ch15._15_5._15_5_4
{
    [TestFixture]
    public class _15_5_4_20Fixture : Test262Fixture
    {
        public _15_5_4_20Fixture()
            : base("ch15\\15.5\\15.5.4\\15.5.4.20")
        {
        }

        [Test(Description = "String.prototype.trim must exist as a function")]
        public void _15_5_4_20_0_1()
        {
            RunFile("15.5.4.20-0-1.js");
        }

        [Test(Description = "String.prototype.trim must exist as a function taking 0 parameters")]
        public void _15_5_4_20_0_2()
        {
            RunFile("15.5.4.20-0-2.js");
        }

        [Test(Description = "String.prototype.trim throws TypeError when string is undefined")]
        public void _15_5_4_20_1_1()
        {
            RunFile("15.5.4.20-1-1.js");
        }

        [Test(Description = "String.prototype.trim throws TypeError when string is null")]
        public void _15_5_4_20_1_2()
        {
            RunFile("15.5.4.20-1-2.js");
        }

        [Test(Description = "String.prototype.trim works for primitive type boolean")]
        public void _15_5_4_20_1_3()
        {
            RunFile("15.5.4.20-1-3.js");
        }

        [Test(Description = "String.prototype.trim works for primitive type number")]
        public void _15_5_4_20_1_4()
        {
            RunFile("15.5.4.20-1-4.js");
        }

        [Test(Description = "String.prototype.trim works for an Object")]
        public void _15_5_4_20_1_5()
        {
            RunFile("15.5.4.20-1-5.js");
        }

        [Test(Description = "String.prototype.trim works for an String")]
        public void _15_5_4_20_1_6()
        {
            RunFile("15.5.4.20-1-6.js");
        }

        [Test(Description = "String.prototype.trim works for a primitive string")]
        public void _15_5_4_20_1_7()
        {
            RunFile("15.5.4.20-1-7.js");
        }

        [Test(Description = "String.prototype.trim works for a primitive string (value is '    abc') ")]
        public void _15_5_4_20_1_8()
        {
            RunFile("15.5.4.20-1-8.js");
        }

        [Test(Description = "String.prototype.trim works for a String object which value is undefined")]
        public void _15_5_4_20_1_9()
        {
            RunFile("15.5.4.20-1-9.js");
        }

        [Test(Description = "String.prototype.trim - argument 'this' is a boolean whose value is false")]
        public void _15_5_4_20_2_1()
        {
            RunFile("15.5.4.20-2-1.js");
        }

        [Test(Description = "String.prototype.trim - argument 'this' is a number that converts to a string (value is +Infinity)")]
        public void _15_5_4_20_2_10()
        {
            RunFile("15.5.4.20-2-10.js");
        }

        [Test(Description = "String.prototype.trim - argument 'this' is a number that converts to a string (value is -Infinity)")]
        public void _15_5_4_20_2_11()
        {
            RunFile("15.5.4.20-2-11.js");
        }

        [Test(Description = "String.prototype.trim - argument 'this' is a number that converts to a string (value is 1(following 20 zeros))")]
        public void _15_5_4_20_2_12()
        {
            RunFile("15.5.4.20-2-12.js");
        }

        [Test(Description = "String.prototype.trim - argument 'this' is a number that converts to a string (value is 1(following 21 zeros))")]
        public void _15_5_4_20_2_13()
        {
            RunFile("15.5.4.20-2-13.js");
        }

        [Test(Description = "String.prototype.trim - argument 'this' is a number that converts to a string (value is 1(following 22 zeros))")]
        public void _15_5_4_20_2_14()
        {
            RunFile("15.5.4.20-2-14.js");
        }

        [Test(Description = "String.prototype.trim - argument 'this' is a number that converts to a string (value is 1e+20)")]
        public void _15_5_4_20_2_15()
        {
            RunFile("15.5.4.20-2-15.js");
        }

        [Test(Description = "String.prototype.trim - argument 'this' is a number that converts to string (value is 1e+21)")]
        public void _15_5_4_20_2_16()
        {
            RunFile("15.5.4.20-2-16.js");
        }

        [Test(Description = "String.prototype.trim - argument 'this' is a number that converts to string (value is 1e+22)")]
        public void _15_5_4_20_2_17()
        {
            RunFile("15.5.4.20-2-17.js");
        }

        [Test(Description = "String.prototype.trim - argument 'this' is a number that converts to a string (value is 0.000001)")]
        public void _15_5_4_20_2_18()
        {
            RunFile("15.5.4.20-2-18.js");
        }

        [Test(Description = "String.prototype.trim - argument argument 'this' is a number that converts to a string (value is 0.0000001)")]
        public void _15_5_4_20_2_19()
        {
            RunFile("15.5.4.20-2-19.js");
        }

        [Test(Description = "String.prototype.trim - argument 'this' is a boolean whose value is true")]
        public void _15_5_4_20_2_2()
        {
            RunFile("15.5.4.20-2-2.js");
        }

        [Test(Description = "String.prototype.trim - argument 'this' is a number that converts to a string (value is 0.00000001)")]
        public void _15_5_4_20_2_20()
        {
            RunFile("15.5.4.20-2-20.js");
        }

        [Test(Description = "String.prototype.trim - argument 'this' is a number that converts to a string (value is 1e-7)")]
        public void _15_5_4_20_2_21()
        {
            RunFile("15.5.4.20-2-21.js");
        }

        [Test(Description = "String.prototype.trim - argument 'this' is a number that converts to a string (value is 1e-6)")]
        public void _15_5_4_20_2_22()
        {
            RunFile("15.5.4.20-2-22.js");
        }

        [Test(Description = "String.prototype.trim - argument 'this' is a number that converts to a string (value is 1e-5)")]
        public void _15_5_4_20_2_23()
        {
            RunFile("15.5.4.20-2-23.js");
        }

        [Test(Description = "String.prototype.trim - argument 'this' is an integer that converts to a string (value is 123)")]
        public void _15_5_4_20_2_24()
        {
            RunFile("15.5.4.20-2-24.js");
        }

        [Test(Description = "String.prototype.trim - argument 'this' is a decimal that converts to a string (value is 123.456)")]
        public void _15_5_4_20_2_25()
        {
            RunFile("15.5.4.20-2-25.js");
        }

        [Test(Description = "String.prototype.trim - argument 'this' is a number that converts to a string (value is 1(following 20 zeros).123)")]
        public void _15_5_4_20_2_26()
        {
            RunFile("15.5.4.20-2-26.js");
        }

        [Test(Description = "String.prototype.trim - argument 'this' is a number that converts to a string (value is 123.1234567)")]
        public void _15_5_4_20_2_27()
        {
            RunFile("15.5.4.20-2-27.js");
        }

        [Test(Description = "String.prototype.trim - argument 'this' is an empty string ")]
        public void _15_5_4_20_2_28()
        {
            RunFile("15.5.4.20-2-28.js");
        }

        [Test(Description = "String.prototype.trim - argument 'this' is a string(value is 'AB")]
        public void _15_5_4_20_2_29()
        {
            RunFile("15.5.4.20-2-29.js");
        }

        [Test(Description = "String.prototype.trim - argument 'this' is a number that converts to a string (value is NaN)")]
        public void _15_5_4_20_2_3()
        {
            RunFile("15.5.4.20-2-3.js");
        }

        [Test(Description = "String.prototype.trim - argument 'this' is a string(value is 'undefined') ")]
        public void _15_5_4_20_2_30()
        {
            RunFile("15.5.4.20-2-30.js");
        }

        [Test(Description = "String.prototype.trim - argument 'this' is a string(value is 'null') ")]
        public void _15_5_4_20_2_31()
        {
            RunFile("15.5.4.20-2-31.js");
        }

        [Test(Description = "String.prototype.trim - argument 'this' is a string(value is '123#$%abc')")]
        public void _15_5_4_20_2_32()
        {
            RunFile("15.5.4.20-2-32.js");
        }

        [Test(Description = "String.prototype.trim - argument 'this' is a string(value is '1')")]
        public void _15_5_4_20_2_33()
        {
            RunFile("15.5.4.20-2-33.js");
        }

        [Test(Description = "String.prototype.trim - 'this' is an array that converts to a string")]
        public void _15_5_4_20_2_34()
        {
            RunFile("15.5.4.20-2-34.js");
        }

        [Test(Description = "String.prototype.trim - 'this' is a String Object that converts to a string")]
        public void _15_5_4_20_2_35()
        {
            RunFile("15.5.4.20-2-35.js");
        }

        [Test(Description = "String.prototype.trim - 'this' is a Boolean Object that converts to a string")]
        public void _15_5_4_20_2_36()
        {
            RunFile("15.5.4.20-2-36.js");
        }

        [Test(Description = "String.prototype.trim - 'this' is a Number Object that converts to a string")]
        public void _15_5_4_20_2_37()
        {
            RunFile("15.5.4.20-2-37.js");
        }

        [Test(Description = "String.prototype.trim - 'this' is an object which has an own toString method")]
        public void _15_5_4_20_2_38()
        {
            RunFile("15.5.4.20-2-38.js");
        }

        [Test(Description = "String.prototype.trim - 'this' is an object which has an own valueOf method")]
        public void _15_5_4_20_2_39()
        {
            RunFile("15.5.4.20-2-39.js");
        }

        [Test(Description = "String.prototype.trim - argument 'this' is a number that converts to a string (value is 0)")]
        public void _15_5_4_20_2_4()
        {
            RunFile("15.5.4.20-2-4.js");
        }

        [Test(Description = "String.prototype.trim - 'this' is an object that has an own toString method that returns an object and valueOf method that returns a primitive value")]
        public void _15_5_4_20_2_40()
        {
            RunFile("15.5.4.20-2-40.js");
        }

        [Test(Description = "String.prototype.trim - 'this' is an object which has an own toString and valueOf method.")]
        public void _15_5_4_20_2_41()
        {
            RunFile("15.5.4.20-2-41.js");
        }

        [Test(Description = "String.prototype.trim - TypeError exception was thrown  when 'this' is an object that both toString and valueOf wouldn't return primitive value.")]
        public void _15_5_4_20_2_42()
        {
            RunFile("15.5.4.20-2-42.js");
        }

        [Test(Description = "String.prototype.trim - 'this' is an object with an own valueOf and inherited toString methods with hint string, verify inherited toString method will be called first")]
        public void _15_5_4_20_2_43()
        {
            RunFile("15.5.4.20-2-43.js");
        }

        [Test(Description = "String.prototype.trim - 'this' is a string that contains east Asian characters (value is 'SD咕噜')")]
        public void _15_5_4_20_2_44()
        {
            RunFile("15.5.4.20-2-44.js");
        }

        [Test(Description = "String.prototype.trim - 'this' is a string that contains white space, character, number, object and null characters")]
        public void _15_5_4_20_2_45()
        {
            RunFile("15.5.4.20-2-45.js");
        }

        [Test(Description = "String.prototype.trim - 'this' is a Function Object that converts to a string")]
        public void _15_5_4_20_2_46()
        {
            RunFile("15.5.4.20-2-46.js");
        }

        [Test(Description = "String.prototype.trim - 'this' is a object Object that converts to a string")]
        public void _15_5_4_20_2_47()
        {
            RunFile("15.5.4.20-2-47.js");
        }

        [Test(Description = "String.prototype.trim - 'this' is a RegExp Object that converts to a string")]
        public void _15_5_4_20_2_49()
        {
            RunFile("15.5.4.20-2-49.js");
        }

        [Test(Description = "String.prototype.trim - argument 'this' is a number that converts to a string (value is +0)")]
        public void _15_5_4_20_2_5()
        {
            RunFile("15.5.4.20-2-5.js");
        }

        [Test(Description = "String.prototype.trim - 'this' is a Error Object that converts to a string")]
        public void _15_5_4_20_2_50()
        {
            RunFile("15.5.4.20-2-50.js");
        }

        [Test(Description = "String.prototype.trim - 'this' is a Arguments Object that converts to a string")]
        public void _15_5_4_20_2_51()
        {
            RunFile("15.5.4.20-2-51.js");
        }

        [Test(Description = "String.prototype.trim - argument 'this' is a number that converts to a string (value is -0)")]
        public void _15_5_4_20_2_6()
        {
            RunFile("15.5.4.20-2-6.js");
        }

        [Test(Description = "String.prototype.trim - argument 'this' is a number that converts to a string (value is positive number)")]
        public void _15_5_4_20_2_7()
        {
            RunFile("15.5.4.20-2-7.js");
        }

        [Test(Description = "String.prototype.trim - argument 'this' is a number that converts to a string (value is negative number)")]
        public void _15_5_4_20_2_8()
        {
            RunFile("15.5.4.20-2-8.js");
        }

        [Test(Description = "String.prototype.trim - argument 'this' is a number that converts to a string (value is Infinity)")]
        public void _15_5_4_20_2_9()
        {
            RunFile("15.5.4.20-2-9.js");
        }

        [Test(Description = "String.prototype.trim - 'S' is a string with all LineTerminator")]
        public void _15_5_4_20_3_1()
        {
            RunFile("15.5.4.20-3-1.js");
        }

        [Test(Description = "String.prototype.trim - 'S' is a string with null character ('\\u0000')")]
        public void _15_5_4_20_3_10()
        {
            RunFile("15.5.4.20-3-10.js");
        }

        [Test(Description = "String.prototype.trim - 'S' is a string that starts with null character")]
        public void _15_5_4_20_3_11()
        {
            RunFile("15.5.4.20-3-11.js");
        }

        [Test(Description = "String.prototype.trim - 'S' is a string that ends with null character")]
        public void _15_5_4_20_3_12()
        {
            RunFile("15.5.4.20-3-12.js");
        }

        [Test(Description = "String.prototype.trim - 'S' is a string that starts with null character and ends with null character")]
        public void _15_5_4_20_3_13()
        {
            RunFile("15.5.4.20-3-13.js");
        }

        [Test(Description = "String.prototype.trim - 'S' is a string that has null character in the middle")]
        public void _15_5_4_20_3_14()
        {
            RunFile("15.5.4.20-3-14.js");
        }

        [Test(Description = "String.prototype.trim - 'S' is a string with all WhiteSpace")]
        public void _15_5_4_20_3_2()
        {
            RunFile("15.5.4.20-3-2.js");
        }

        [Test(Description = "String.prototype.trim - 'S' is a string with all union of WhiteSpace and LineTerminator")]
        public void _15_5_4_20_3_3()
        {
            RunFile("15.5.4.20-3-3.js");
        }

        [Test(Description = "String.prototype.trim - 'S' is a string start with union of all LineTerminator and all WhiteSpace")]
        public void _15_5_4_20_3_4()
        {
            RunFile("15.5.4.20-3-4.js");
        }

        [Test(Description = "String.prototype.trim - 'S' is a string end with union of all LineTerminator and all WhiteSpace")]
        public void _15_5_4_20_3_5()
        {
            RunFile("15.5.4.20-3-5.js");
        }

        [Test(Description = "String.prototype.trim - 'S' is a string start with union of all LineTerminator and all WhiteSpace and end with union of all LineTerminator and all WhiteSpace")]
        public void _15_5_4_20_3_6()
        {
            RunFile("15.5.4.20-3-6.js");
        }

        [Test(Description = "String.prototype.trim - 'S' is a string that union of LineTerminator and WhiteSpace in the middle")]
        public void _15_5_4_20_3_7()
        {
            RunFile("15.5.4.20-3-7.js");
        }

        [Test(Description = "String.prototype.trim - 'S' is a string with all null character")]
        public void _15_5_4_20_3_8()
        {
            RunFile("15.5.4.20-3-8.js");
        }

        [Test(Description = "String.prototype.trim - 'S' is a string with null character ('\\0')")]
        public void _15_5_4_20_3_9()
        {
            RunFile("15.5.4.20-3-9.js");
        }

        [Test(Description = "String.prototype.trim handles multiline string with whitepace and lineterminators")]
        public void _15_5_4_20_4_1()
        {
            RunFile("15.5.4.20-4-1.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (\\uFEFFabc)")]
        public void _15_5_4_20_4_10()
        {
            RunFile("15.5.4.20-4-10.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (abc\\u0009)")]
        public void _15_5_4_20_4_11()
        {
            RunFile("15.5.4.20-4-11.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (abc\\u000B)")]
        public void _15_5_4_20_4_12()
        {
            RunFile("15.5.4.20-4-12.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (abc\\u000C)")]
        public void _15_5_4_20_4_13()
        {
            RunFile("15.5.4.20-4-13.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (abc\\u0020)")]
        public void _15_5_4_20_4_14()
        {
            RunFile("15.5.4.20-4-14.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (abc\\u00A0)")]
        public void _15_5_4_20_4_16()
        {
            RunFile("15.5.4.20-4-16.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (abc\\uFEFF)")]
        public void _15_5_4_20_4_18()
        {
            RunFile("15.5.4.20-4-18.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (\\u0009abc\\u0009)")]
        public void _15_5_4_20_4_19()
        {
            RunFile("15.5.4.20-4-19.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators ( \\u0009abc \\u0009)")]
        public void _15_5_4_20_4_2()
        {
            RunFile("15.5.4.20-4-2.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (\\u000Babc\\u000B)")]
        public void _15_5_4_20_4_20()
        {
            RunFile("15.5.4.20-4-20.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (\\u000Cabc\\u000C)")]
        public void _15_5_4_20_4_21()
        {
            RunFile("15.5.4.20-4-21.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (\\u0020abc\\u0020)")]
        public void _15_5_4_20_4_22()
        {
            RunFile("15.5.4.20-4-22.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (\\u00A0abc\\u00A0)")]
        public void _15_5_4_20_4_24()
        {
            RunFile("15.5.4.20-4-24.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (\\u0009\\u0009)")]
        public void _15_5_4_20_4_27()
        {
            RunFile("15.5.4.20-4-27.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (\\u000B\\u000B)")]
        public void _15_5_4_20_4_28()
        {
            RunFile("15.5.4.20-4-28.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (\\u000C\\u000C)")]
        public void _15_5_4_20_4_29()
        {
            RunFile("15.5.4.20-4-29.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (\\u0009abc)")]
        public void _15_5_4_20_4_3()
        {
            RunFile("15.5.4.20-4-3.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (\\u0020\\u0020)")]
        public void _15_5_4_20_4_30()
        {
            RunFile("15.5.4.20-4-30.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (\\u00A0\\u00A0)")]
        public void _15_5_4_20_4_32()
        {
            RunFile("15.5.4.20-4-32.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (\\uFEFF\\uFEFF)")]
        public void _15_5_4_20_4_34()
        {
            RunFile("15.5.4.20-4-34.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (ab\\u0009c)")]
        public void _15_5_4_20_4_35()
        {
            RunFile("15.5.4.20-4-35.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (ab\\u000Bc)")]
        public void _15_5_4_20_4_36()
        {
            RunFile("15.5.4.20-4-36.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (ab\\u000Cc)")]
        public void _15_5_4_20_4_37()
        {
            RunFile("15.5.4.20-4-37.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (ab\\u0020c)")]
        public void _15_5_4_20_4_38()
        {
            RunFile("15.5.4.20-4-38.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (ab\\u0085c)")]
        public void _15_5_4_20_4_39()
        {
            RunFile("15.5.4.20-4-39.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (\\u000Babc)")]
        public void _15_5_4_20_4_4()
        {
            RunFile("15.5.4.20-4-4.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (ab\\u00A0c)")]
        public void _15_5_4_20_4_40()
        {
            RunFile("15.5.4.20-4-40.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (ab\\u200Bc)")]
        public void _15_5_4_20_4_41()
        {
            RunFile("15.5.4.20-4-41.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (ab\\uFEFFc)")]
        public void _15_5_4_20_4_42()
        {
            RunFile("15.5.4.20-4-42.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (\\u000Aabc)")]
        public void _15_5_4_20_4_43()
        {
            RunFile("15.5.4.20-4-43.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (\\u000Dabc)")]
        public void _15_5_4_20_4_44()
        {
            RunFile("15.5.4.20-4-44.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (\\u2028abc)")]
        public void _15_5_4_20_4_45()
        {
            RunFile("15.5.4.20-4-45.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (\\u2029abc)")]
        public void _15_5_4_20_4_46()
        {
            RunFile("15.5.4.20-4-46.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (abc\\u000A)")]
        public void _15_5_4_20_4_47()
        {
            RunFile("15.5.4.20-4-47.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (abc\\u000D)")]
        public void _15_5_4_20_4_48()
        {
            RunFile("15.5.4.20-4-48.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (abc\\u2028)")]
        public void _15_5_4_20_4_49()
        {
            RunFile("15.5.4.20-4-49.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (\\u000Cabc)")]
        public void _15_5_4_20_4_5()
        {
            RunFile("15.5.4.20-4-5.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (abc\\u2029)")]
        public void _15_5_4_20_4_50()
        {
            RunFile("15.5.4.20-4-50.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (\\u000Aabc\\u000A)")]
        public void _15_5_4_20_4_51()
        {
            RunFile("15.5.4.20-4-51.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (\\u000Dabc\\u000D)")]
        public void _15_5_4_20_4_52()
        {
            RunFile("15.5.4.20-4-52.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (\\u2028abc\\u2028)")]
        public void _15_5_4_20_4_53()
        {
            RunFile("15.5.4.20-4-53.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (\\u2029abc\\u2029)")]
        public void _15_5_4_20_4_54()
        {
            RunFile("15.5.4.20-4-54.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (\\u000A\\u000A)")]
        public void _15_5_4_20_4_55()
        {
            RunFile("15.5.4.20-4-55.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (\\u000D\\u000D)")]
        public void _15_5_4_20_4_56()
        {
            RunFile("15.5.4.20-4-56.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (\\u2028\\u2028)")]
        public void _15_5_4_20_4_57()
        {
            RunFile("15.5.4.20-4-57.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (\\u2029\\u2029)")]
        public void _15_5_4_20_4_58()
        {
            RunFile("15.5.4.20-4-58.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (\\u2029abc as a multiline string)")]
        public void _15_5_4_20_4_59()
        {
            RunFile("15.5.4.20-4-59.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (\\u0020abc)")]
        public void _15_5_4_20_4_6()
        {
            RunFile("15.5.4.20-4-6.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (string with just blanks)")]
        public void _15_5_4_20_4_60()
        {
            RunFile("15.5.4.20-4-60.js");
        }

        [Test(Description = "String.prototype.trim handles whitepace and lineterminators (\\u00A0abc)")]
        public void _15_5_4_20_4_8()
        {
            RunFile("15.5.4.20-4-8.js");
        }
    }
}
