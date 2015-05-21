/// <reference path="../js/esl.js" />


define(function (require, exports, module) {
    var assert = new require("./Assert");
    var expressionParser = require("/expressionParser/main");
    assert.AreEqual(3, expressionParser.External("1+2"));
    assert.AreEqual(6, expressionParser.External("1+2+3="));
    assert.AreEqual(10, expressionParser.External("1+2+3+4="));




});