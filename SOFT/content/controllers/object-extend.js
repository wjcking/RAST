"use strict";
let Typelect = {
    assert: function (value) {
        if (value == null) {
            const error = "[Error]Typelect.Assertion:value is null"; 
            throw error;
        }
        if (value == undefined) {
            const error = "[Undefined]Typelect.Assertion:value is undefined";
            throw error;
        }
    },
    default: function (value, defaultValue) {

        value == undefined ? null : value;

        if (null != value)
            return value;

        if (defaultValue == null)
            value = string_empty
        else
            value = defaultValue;
    },

    isString: function (value) {
        return typeof (value) == type_string;
    }

}
let logger = {
    write: function (value, color) {
        document.write( "<log style='color: " + Typelect.default(color, "red") + "'>" + value + "</log>");
    }

}

let Except = {
    track: function (funk) {
        try {
            return funk;
        } catch (e) {
            throw e.error;
        }
    }
}
let Cryteck = {
    /*
     *[yingG!=^/\]可丁可卯每一个   sok
     * isAdverse = Direct.Left|Direct.Right
     */
    kaiter: function (condets) {

        //Typelect.assert(value);

        //step = Typelect.default(step, 1);
        //isAdverse = Typelect.default(isAdverse, false);
    }
}

/*
 * print each array by using document. write
  */
Object.prototype.logout = function () {
    this.forEach(function (e, i) {
        document.write(e);
    });

}