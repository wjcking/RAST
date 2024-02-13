RequestUrl = "http://localhost:50775/"

/*
 * handle server Buiness and Poweredsource
 */
Handlers = {};

handler = function () {
    this.success = null;
    this.error = null;
    this.complete = null;
    //黄鼠狼 Cansai 位置
    this.call = function (json, method, url, success, error, complete) {
        this.success = success;
        this.error = error;
        this.complete = complete;
        $.ajax({
            type: method,
            url: url,
            data: JSON.stringify(json),
            // data: json,
            contentType: "application/json; charset=utf-8",
             dataType: "json",
            //404 505 the like
            //当前状态,0-未初始化，1-正在载入，2-已经载入，3-数据进行交互，4-完成。
            error: error,
            success: success,
            complete: complete

        });
    }
    this.get = function (json, success, error, complete) {
        // mind the method type of Form submit
        this.call(json, "GET", RequestUrl + "get.ashx", success, error, complete);

    }
    this.set = function (json, success, error, complete) {
        this.call(json, "POST", RequestUrl + "set.ashx", success, error, complete);

    }

}
//instance a new object for statically call
Handlers.handler = new handler();