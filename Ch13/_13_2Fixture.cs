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

namespace Jint.Test262.Ch13
{
    [TestFixture]
    public class _13_2Fixture : Test262Fixture
    {
        public _13_2Fixture()
            : base("ch13\\13.2")
        {
        }

        [Test(Description = "StrictMode -  Writing or reading from a property named 'caller' of function objects is allowed under both strict and normal modes.")]
        public void _13_2_1_s()
        {
            RunFile("13.2-1-s.js");
        }

        [Test(Description = "StrictMode - writing a property named 'caller' of function objects is not allowed outside the function")]
        public void _13_2_10_s()
        {
            RunFile("13.2-10-s.js");
        }

        [Test(Description = "StrictMode - enumerating over a function object looking for 'caller' fails outside of the function")]
        public void _13_2_11_s()
        {
            RunFile("13.2-11-s.js");
        }

        [Test(Description = "StrictMode - enumerating over a function object looking for 'caller' fails inside the function")]
        public void _13_2_12_s()
        {
            RunFile("13.2-12-s.js");
        }

        [Test(Description = "StrictMode - reading a property named 'arguments' of function objects is not allowed outside the function")]
        public void _13_2_13_s()
        {
            RunFile("13.2-13-s.js");
        }

        [Test(Description = "StrictMode - writing a property named 'arguments' of function objects is not allowed outside the function")]
        public void _13_2_14_s()
        {
            RunFile("13.2-14-s.js");
        }

        [Test(Description = "Function Object has length as its own property and does not invoke the setter defined on Function.prototype.length (Step 15)")]
        public void _13_2_15_1()
        {
            RunFile("13.2-15-1.js");
        }

        [Test(Description = "StrictMode - enumerating over a function object looking for 'arguments' fails outside of the function")]
        public void _13_2_15_s()
        {
            RunFile("13.2-15-s.js");
        }

        [Test(Description = "StrictMode - enumerating over a function object looking for 'arguments' fails inside the function")]
        public void _13_2_16_s()
        {
            RunFile("13.2-16-s.js");
        }

        [Test(Description = "Function Object has 'constructor' as its own property, it is not enumerable and does not invoke the setter defined on Function.prototype.constructor (Step 17)")]
        public void _13_2_17_1()
        {
            RunFile("13.2-17-1.js");
        }

        [Test(Description = "StrictMode - reading a property named 'arguments' of function objects is not allowed outside the function")]
        public void _13_2_17_s()
        {
            RunFile("13.2-17-s.js");
        }

        [Test(Description = "Function Object has 'prototype' as its own property, it is not enumerable and does not invoke the setter defined on Function.prototype (Step 18)")]
        public void _13_2_18_1()
        {
            RunFile("13.2-18-1.js");
        }

        [Test(Description = "StrictMode - writing a property named 'arguments' of function objects is not allowed outside the function")]
        public void _13_2_18_s()
        {
            RunFile("13.2-18-s.js");
        }

        [Test(Description = "StrictMode - error is thrown when assign a value to the 'caller' property of a function object")]
        [ExpectedException]
        public void _13_2_19_b_3gs()
        {
            RunFile("13.2-19-b-3gs.js");
        }

        [Test(Description = "StrictMode - enumerating over a function object looking for 'arguments' fails outside of the function")]
        public void _13_2_19_s()
        {
            RunFile("13.2-19-s.js");
        }

        [Test(Description = "StrictMode - A TypeError is thrown when a strict mode code writes to properties named 'caller' of function instances.")]
        public void _13_2_2_s()
        {
            RunFile("13.2-2-s.js");
        }

        [Test(Description = "StrictMode - enumerating over a function object looking for 'arguments' fails inside the function")]
        public void _13_2_20_s()
        {
            RunFile("13.2-20-s.js");
        }

        [Test(Description = "StrictMode - reading a property named 'caller' of function objects is not allowed outside the function")]
        public void _13_2_21_s()
        {
            RunFile("13.2-21-s.js");
        }

        [Test(Description = "StrictMode - writing a property named 'caller' of function objects is not allowed outside the function")]
        public void _13_2_22_s()
        {
            RunFile("13.2-22-s.js");
        }

        [Test(Description = "StrictMode - enumerating over a function object looking for 'caller' fails outside of the function")]
        public void _13_2_23_s()
        {
            RunFile("13.2-23-s.js");
        }

        [Test(Description = "StrictMode - enumerating over a function object looking for 'caller' fails inside the function")]
        public void _13_2_24_s()
        {
            RunFile("13.2-24-s.js");
        }

        [Test(Description = "StrictMode - reading a property named 'arguments' of function objects is not allowed outside the function")]
        public void _13_2_25_s()
        {
            RunFile("13.2-25-s.js");
        }

        [Test(Description = "StrictMode - writing a property named 'arguments' of function objects is not allowed outside the function")]
        public void _13_2_26_s()
        {
            RunFile("13.2-26-s.js");
        }

        [Test(Description = "StrictMode - enumerating over a function object looking for 'arguments' fails outside of the function")]
        public void _13_2_27_s()
        {
            RunFile("13.2-27-s.js");
        }

        [Test(Description = "StrictMode - enumerating over a function object looking for 'arguments' fails inside the function")]
        public void _13_2_28_s()
        {
            RunFile("13.2-28-s.js");
        }

        [Test(Description = "StrictMode - property named 'caller' of function objects is not configurable")]
        public void _13_2_29_s()
        {
            RunFile("13.2-29-s.js");
        }

        [Test(Description = "StrictMode - Writing or reading from a property named 'arguments' of function objects is allowed under both strict and normal modes.")]
        public void _13_2_3_s()
        {
            RunFile("13.2-3-s.js");
        }

        [Test(Description = "StrictMode - property named 'caller' of function objects is not configurable")]
        public void _13_2_30_s()
        {
            RunFile("13.2-30-s.js");
        }

        [Test(Description = "StrictMode - property named 'caller' of function objects is not configurable")]
        public void _13_2_31_s()
        {
            RunFile("13.2-31-s.js");
        }

        [Test(Description = "StrictMode - property named 'caller' of function objects is not configurable")]
        public void _13_2_32_s()
        {
            RunFile("13.2-32-s.js");
        }

        [Test(Description = "StrictMode - property named 'arguments' of function objects is not configurable")]
        public void _13_2_33_s()
        {
            RunFile("13.2-33-s.js");
        }

        [Test(Description = "StrictMode - property named 'arguments' of function objects is not configurable")]
        public void _13_2_34_s()
        {
            RunFile("13.2-34-s.js");
        }

        [Test(Description = "StrictMode - property named 'arguments' of function objects is not configurable")]
        public void _13_2_35_s()
        {
            RunFile("13.2-35-s.js");
        }

        [Test(Description = "StrictMode - property named 'arguments' of function objects is not configurable")]
        public void _13_2_36_s()
        {
            RunFile("13.2-36-s.js");
        }

        [Test(Description = "StrictMode - A TypeError is thrown when a code in strict mode tries to write to 'arguments' of function instances.")]
        public void _13_2_4_s()
        {
            RunFile("13.2-4-s.js");
        }

        [Test(Description = "StrictMode - reading a property named 'caller' of function objects is not allowed outside the function")]
        public void _13_2_5_s()
        {
            RunFile("13.2-5-s.js");
        }

        [Test(Description = "StrictMode - writing a property named 'caller' of function objects is not allowed outside the function")]
        public void _13_2_6_s()
        {
            RunFile("13.2-6-s.js");
        }

        [Test(Description = "StrictMode - enumerating over a function object looking for 'caller' fails outside of the function")]
        public void _13_2_7_s()
        {
            RunFile("13.2-7-s.js");
        }

        [Test(Description = "StrictMode - enumerating over a function object looking for 'caller' fails inside the function")]
        public void _13_2_8_s()
        {
            RunFile("13.2-8-s.js");
        }

        [Test(Description = "StrictMode - reading a property named 'caller' of function objects is not allowed outside the function")]
        public void _13_2_9_s()
        {
            RunFile("13.2-9-s.js");
        }

        [Test(Description = "Creating function calls 32 elements depth")]
        public void S13_2_1_A1_T1()
        {
            RunFile("S13.2.1_A1_T1.js");
        }

        [Test(Description = "Adding new number property to a function argument within the function body,")]
        public void S13_2_1_A4_T1()
        {
            RunFile("S13.2.1_A4_T1.js");
        }

        [Test(Description = "Adding new string property to a function argument within the function body,")]
        public void S13_2_1_A4_T2()
        {
            RunFile("S13.2.1_A4_T2.js");
        }

        [Test(Description = "Adding new number property to a function argument within the function body,")]
        public void S13_2_1_A4_T3()
        {
            RunFile("S13.2.1_A4_T3.js");
        }

        [Test(Description = "Adding new number property to a function argument within the function body,")]
        public void S13_2_1_A4_T4()
        {
            RunFile("S13.2.1_A4_T4.js");
        }

        [Test(Description = "Sorting with closure")]
        public void S13_2_1_A5_T1()
        {
            RunFile("S13.2.1_A5_T1.js");
        }

        [Test(Description = "Returning a function that approximates the derivative of f")]
        public void S13_2_1_A5_T2()
        {
            RunFile("S13.2.1_A5_T2.js");
        }

        [Test(Description = "Declaring a function with \"function __func(arg1, arg2)\"")]
        public void S13_2_1_A6_T1()
        {
            RunFile("S13.2.1_A6_T1.js");
        }

        [Test(Description = "Declaring a function with \"__func = function(arg1, arg2)\"")]
        public void S13_2_1_A6_T2()
        {
            RunFile("S13.2.1_A6_T2.js");
        }

        [Test(Description = "Returning null. Declaring a function with \"function __func()\"")]
        public void S13_2_1_A7_T1()
        {
            RunFile("S13.2.1_A7_T1.js");
        }

        [Test(Description = "Returning null. Declaring a function with \"var __func = function ()\"")]
        public void S13_2_1_A7_T2()
        {
            RunFile("S13.2.1_A7_T2.js");
        }

        [Test(Description = "Returning number. Declaring a function with \"function __func()\"")]
        public void S13_2_1_A7_T3()
        {
            RunFile("S13.2.1_A7_T3.js");
        }

        [Test(Description = "Returning boolean. Declaring a function with \"function __func()\"")]
        public void S13_2_1_A7_T4()
        {
            RunFile("S13.2.1_A7_T4.js");
        }

        [Test(Description = "Throwing an exception within a function body. Declaring function with \"function __func()\"")]
        public void S13_2_1_A8_T1()
        {
            RunFile("S13.2.1_A8_T1.js");
        }

        [Test(Description = "Throwing an exception within a function body. Declaring function with \"var __func = function (message)\"")]
        public void S13_2_1_A8_T2()
        {
            RunFile("S13.2.1_A8_T2.js");
        }

        [Test(Description = "Declaring a function with \"function __func()\" and no \"return\" in the function body")]
        public void S13_2_1_A9_1_T1()
        {
            RunFile("S13.2.1_A9.1_T1.js");
        }

        [Test(Description = "Declaring a function with \"var __func = function()\" and no \"return\" in the function body")]
        public void S13_2_1_A9_1_T2()
        {
            RunFile("S13.2.1_A9.1_T2.js");
        }

        [Test(Description = "Using \"return\" with no expression. Declaring a function with \"function __func()\"")]
        public void S13_2_1_A9_T1()
        {
            RunFile("S13.2.1_A9_T1.js");
        }

        [Test(Description = "Using \"return\" with no expression. Declaring a function with \"var __func = function()\"")]
        public void S13_2_1_A9_T2()
        {
            RunFile("S13.2.1_A9_T2.js");
        }

        [Test(Description = "Calling a function as a constructor after it has been declared")]
        public void S13_2_2_A10()
        {
            RunFile("S13.2.2_A10.js");
        }

        [Test(Description = "Calling a function as a constructor after it has been declared with \"function func()\"")]
        public void S13_2_2_A11()
        {
            RunFile("S13.2.2_A11.js");
        }

        [Test(Description = "Calling a function as a constructor after it has been declared with \"function func()\"")]
        public void S13_2_2_A12()
        {
            RunFile("S13.2.2_A12.js");
        }

        [Test(Description = "Calling a function as a constructor after it has been declared by eval")]
        public void S13_2_2_A13()
        {
            RunFile("S13.2.2_A13.js");
        }

        [Test(Description = "Calling a function as a constructor after it has been declared by eval")]
        public void S13_2_2_A14()
        {
            RunFile("S13.2.2_A14.js");
        }

        [Test(Description = "Function declared at the end of the program and \"obj\" property is declared with \"var obj = {}\"")]
        public void S13_2_2_A15_T1()
        {
            RunFile("S13.2.2_A15_T1.js");
        }

        [Test(Description = "Function declared at the end of the program and \"obj\" property is declared with \"obj = {}\"")]
        public void S13_2_2_A15_T2()
        {
            RunFile("S13.2.2_A15_T2.js");
        }

        [Test(Description = "Function declared at the end of the program and \"obj\" property is declared with \"var obj = {}\"")]
        public void S13_2_2_A15_T3()
        {
            RunFile("S13.2.2_A15_T3.js");
        }

        [Test(Description = "Function declared at the end of the program and \"obj\" property is declared with \"obj = {}\"")]
        public void S13_2_2_A15_T4()
        {
            RunFile("S13.2.2_A15_T4.js");
        }

        [Test(Description = "Using \"is __obj = new function __func(){this.prop=1;}\" as FunctionExpression")]
        public void S13_2_2_A16_T1()
        {
            RunFile("S13.2.2_A16_T1.js");
        }

        [Test(Description = "Using \"var __obj = new function __func(arg){this.prop=arg;}(5)\" as FunctionExpression")]
        public void S13_2_2_A16_T2()
        {
            RunFile("S13.2.2_A16_T2.js");
        }

        [Test(Description = "Using \"is __obj = new function __func(arg){this.prop=arg; return {feat: ++arg}}(5)\" as FunctionExpression")]
        public void S13_2_2_A16_T3()
        {
            RunFile("S13.2.2_A16_T3.js");
        }

        [Test(Description = "Throwing an exception within \"with\" statement")]
        public void S13_2_2_A17_T2()
        {
            RunFile("S13.2.2_A17_T2.js");
        }

        [Test(Description = "In the check 4 we populate field getRight in __obj object since var getRight declaration adds variable to function scope")]
        public void S13_2_2_A17_T3()
        {
            RunFile("S13.2.2_A17_T3.js");
        }

        [Test(Description = "Object is declared with \"var __obj={callee:\"a\"}\"")]
        public void S13_2_2_A18_T1()
        {
            RunFile("S13.2.2_A18_T1.js");
        }

        [Test(Description = "Object is declared with \"__obj={callee:\"a\"}\"")]
        public void S13_2_2_A18_T2()
        {
            RunFile("S13.2.2_A18_T2.js");
        }

        [Test(Description = "Function is declared in the global scope")]
        public void S13_2_2_A19_T1()
        {
            RunFile("S13.2.2_A19_T1.js");
        }

        [Test(Description = "Function is declared in the object scope. Using \"with\" statement")]
        public void S13_2_2_A19_T2()
        {
            RunFile("S13.2.2_A19_T2.js");
        }

        [Test(Description = "Function is declared in the object scope and then an exception is thrown")]
        public void S13_2_2_A19_T3()
        {
            RunFile("S13.2.2_A19_T3.js");
        }

        [Test(Description = "Function is declared in the hierarchical object scope and then an exception is thrown")]
        public void S13_2_2_A19_T4()
        {
            RunFile("S13.2.2_A19_T4.js");
        }

        [Test(Description = "Function is declared in the object scope, then an exception is thrown and the object is deleted")]
        public void S13_2_2_A19_T5()
        {
            RunFile("S13.2.2_A19_T5.js");
        }

        [Test(Description = "Function is declared in the \"object->do-while\" scope, then the object is deleted and another object with the same name is declared")]
        public void S13_2_2_A19_T6()
        {
            RunFile("S13.2.2_A19_T6.js");
        }

        [Test(Description = "Function is declared in the object scope as a variable")]
        public void S13_2_2_A19_T7()
        {
            RunFile("S13.2.2_A19_T7.js");
        }

        [Test(Description = "Function is declared multiply times")]
        public void S13_2_2_A19_T8()
        {
            RunFile("S13.2.2_A19_T8.js");
        }

        [Test(Description = "Declaring a function with \"function __func()\"")]
        public void S13_2_2_A1_T1()
        {
            RunFile("S13.2.2_A1_T1.js");
        }

        [Test(Description = "Declaring a function with \"var __PROTO = function()\"")]
        public void S13_2_2_A1_T2()
        {
            RunFile("S13.2.2_A1_T2.js");
        }

        [Test(Description = "Trying to [[call]] this function")]
        public void S13_2_2_A2()
        {
            RunFile("S13.2.2_A2.js");
        }

        [Test(Description = "Declaring a function with \"function __FACTORY()\"")]
        public void S13_2_2_A3_T1()
        {
            RunFile("S13.2.2_A3_T1.js");
        }

        [Test(Description = "Declaring a function with \"var __FACTORY = function()\"")]
        public void S13_2_2_A3_T2()
        {
            RunFile("S13.2.2_A3_T2.js");
        }

        [Test(Description = "Declaring a function with \"function __FACTORY()\"")]
        public void S13_2_2_A4_T1()
        {
            RunFile("S13.2.2_A4_T1.js");
        }

        [Test(Description = "Declaring a function with \"__FACTORY = function()\"")]
        public void S13_2_2_A4_T2()
        {
            RunFile("S13.2.2_A4_T2.js");
        }

        [Test(Description = "Declaring a function with \"function __FACTORY(arg1, arg2)\"")]
        public void S13_2_2_A5_T1()
        {
            RunFile("S13.2.2_A5_T1.js");
        }

        [Test(Description = "Declaring a function with \"__FACTORY = function(arg1, arg2)\"")]
        public void S13_2_2_A5_T2()
        {
            RunFile("S13.2.2_A5_T2.js");
        }

        [Test(Description = "Declaring a function with \"__func = function(arg)\"")]
        public void S13_2_2_A6_T1()
        {
            RunFile("S13.2.2_A6_T1.js");
        }

        [Test(Description = "Declaring a function with \"function __func (arg)\"")]
        public void S13_2_2_A6_T2()
        {
            RunFile("S13.2.2_A6_T2.js");
        }

        [Test(Description = "Declaring a function with \"as __func = function(arg)\"")]
        public void S13_2_2_A7_T1()
        {
            RunFile("S13.2.2_A7_T1.js");
        }

        [Test(Description = "Declaring a \"function as function __func (arg)\"")]
        public void S13_2_2_A7_T2()
        {
            RunFile("S13.2.2_A7_T2.js");
        }

        [Test(Description = "Creating a function whose prototype contains \"return\" followed by declaration of another function")]
        public void S13_2_2_A8_T1()
        {
            RunFile("S13.2.2_A8_T1.js");
        }

        [Test(Description = "Creating a function whose prototype contains declaration of another function declared as a variable")]
        public void S13_2_2_A8_T2()
        {
            RunFile("S13.2.2_A8_T2.js");
        }

        [Test(Description = "Creating a function whose prototype contains declaration of another function defined by using Function.call method")]
        public void S13_2_2_A8_T3()
        {
            RunFile("S13.2.2_A8_T3.js");
        }

        [Test(Description = "Calling a function as a constructor")]
        public void S13_2_2_A9()
        {
            RunFile("S13.2.2_A9.js");
        }

        [Test(Description = "check that all poisoning use the [[ThrowTypeError]]")]
        public void S13_2_3_A1()
        {
            RunFile("S13.2.3_A1.js");
        }

        [Test(Description = "Using \"function __func(){}\" as a FunctionDeclaration")]
        public void S13_2_A1_T1()
        {
            RunFile("S13.2_A1_T1.js");
        }

        [Test(Description = "Using \"var __func = function(){}\" as a FunctionDeclaration")]
        public void S13_2_A1_T2()
        {
            RunFile("S13.2_A1_T2.js");
        }

        [Test(Description = "Nesting level is two")]
        public void S13_2_A2_T1()
        {
            RunFile("S13.2_A2_T1.js");
        }

        [Test(Description = "Nesting level is three")]
        public void S13_2_A2_T2()
        {
            RunFile("S13.2_A2_T2.js");
        }

        [Test(Description = "Creating functions with various FormalParameterList and checking their lengths")]
        public void S13_2_A3()
        {
            RunFile("S13.2_A3.js");
        }

        [Test(Description = "Checking prototype, prototype.constructor properties and {DontEnum} property of a constructor.")]
        public void S13_2_A4_T1()
        {
            RunFile("S13.2_A4_T1.js");
        }

        [Test(Description = "Checking prototype, prototype.constructor properties and {DontEnum} property of a constructor.")]
        public void S13_2_A4_T2()
        {
            RunFile("S13.2_A4_T2.js");
        }

        [Test(Description = "Function.prototype.isPrototypeOf() is used")]
        public void S13_2_A5()
        {
            RunFile("S13.2_A5.js");
        }

        [Test(Description = "check if \"caller\" poisoning poisons")]
        public void S13_2_A6_T1()
        {
            RunFile("S13.2_A6_T1.js");
        }

        [Test(Description = "check if \"arguments\" poisoning poisons")]
        public void S13_2_A6_T2()
        {
            RunFile("S13.2_A6_T2.js");
        }

        [Test(Description = "check if \"caller\" poisoning poisons")]
        public void S13_2_A7_T1()
        {
            RunFile("S13.2_A7_T1.js");
        }

        [Test(Description = "check if \"arguments\" poisoning poisons")]
        public void S13_2_A7_T2()
        {
            RunFile("S13.2_A7_T2.js");
        }

        [Test(Description = "check if \"caller\" poisoning poisons")]
        public void S13_2_A8_T1()
        {
            RunFile("S13.2_A8_T1.js");
        }

        [Test(Description = "check if \"arguments\" poisoning poisons")]
        public void S13_2_A8_T2()
        {
            RunFile("S13.2_A8_T2.js");
        }
    }
}
