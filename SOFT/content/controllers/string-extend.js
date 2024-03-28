"use strict";
/**
 * Karyact
 */
function StringBuilder() {
    var strings = [];

    this.add = function (string) {
        string = verify(string);
        if (string.length > 0) strings[strings.length] = string;
    };

    this.addBreak = function (string) {
        string = verify(string);
        if (this.isEmpty()) {
            if (string.length > 0) strings[strings.length] = string;
            else return;
        }
        else strings[strings.length] = string.length > 0 ? "\r\n" + string : "\r\n";
    };

    this.clear = function () { strings = []; };

    this.isEmpty = function () { return strings.length == 0; };

    this.toString = function () { return strings.join(""); };

    var verify = function (string) {
        if (!defined(string)) return "";
        if (getType(string) != getType(new String())) return String(string);
        return string;
    };

    var defined = function (el) {
        // Changed per Ryan O'Hara's comment:
        return el != null && typeof (el) != "undefined";
    };

    var getType = function (instance) {
        if (!defined(instance.constructor)) throw Error("Unexpected object type");
        var type = String(instance.constructor).match(/function\s+(\w+)/);

        return defined(type) ? type[1] : "undefined";
    };
};
String.prototype.upperFirst = function () {
    return this.substring(0, 1).toUpperCase() + this.substring(1);
}
String.prototype.lowerFirst = function () {
    return this.substring(0, 1).toUpperCase() + this.substring(1);
}
String.prototype.replaceAll = function (s2, replacement) {
    return this.replace(new RegExp(s2, 'g'), replacement);
}
String.prototype.format = function () {
    if (arguments.length == 0) {
        return this;
    }
    for (var s = this, i = 0; i < arguments.length; i++) {
        s = s.replace(new RegExp("\\{" + i + "\\}", "g"), arguments[i]);
    }
    return s;
};


String.prototype.lines = function () {
    if (this.indexOf("\r\n") > -1)
        return this.split('\r\n');

    if (this.indexOf('\n') > -1)
        return this.split('\n');

    return this.split('\r');
}
String.prototype.br = function () {
    return this + "<br/>";
}

/**
 * eval line [[split], [dot]]  function * 
 * @param 
 * function name and parameters
 */
String.prototype.execute = function (item) {

    var funk = new StringBuilder();

    funk.add(qta + this + qta);
    funk.add(dst);
    //name 
    funk.add(item[func_name]);
    funk.add(lsm);
    //parameters
    item[func_params].forEach(function (pe, pi) {
        if (typeof (pe) == type_string) {
            funk.add(qta);
            funk.add(pe);
            funk.add(qta);
        } else {
            funk.add(pe);
        }
        //去掉函数最后一个 逗号
        funk.add(item[func_params].length - 1 == pi ? string_empty : kma);
    });
    
    funk.add(rsm);
    //currently debuged returned as ["single string in a quota"]    
    var result = Except.track(eval(funk.toString()));

    var tripleKant = [
        //a function name
        [item[func_name]],
        //parameters names more than 2 parameters like: "abc".replace("a","1")
        [item[func_params]],
        //returns
        result
    ];
   // console.table(tripleKant);
    return tripleKant;
}
