/// Copyright (c) 2012 Ecma International.  All rights reserved. 
/// Ecma International makes this code available under the terms and conditions set
/// forth on http://hg.ecmascript.org/tests/test262/raw-file/tip/LICENSE (the 
/// "Use Terms").   Any redistribution of this code must retain the above 
/// copyright and this notice and otherwise comply with the Use Terms.
/**
 * @path ch15/15.4/15.4.4/15.4.4.15/15.4.4.15-8-a-19.js
 * @description Array.prototype.lastIndexOf -  decreasing length of array does not delete non-configurable properties
 */


function testcase() {

        var arr = [0, 1, 2, 3];

        Object.defineProperty(arr, "2", {
            get: function () {
                return "unconfigurable";
            },
            configurable: false
        });

        Object.defineProperty(arr, "3", {
            get: function () {
                arr.length = 2;
                return 1;
            },
            configurable: true
        });

        return 2 === arr.lastIndexOf("unconfigurable");
    }
runTestCase(testcase);
