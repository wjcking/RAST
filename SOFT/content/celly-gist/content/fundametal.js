//function toggleFullScreen() {
//    if (!document.fullscreenElement && // alternative standard method
//		!document.mozFullScreenElement && !document.webkitFullscreenElement) {// current working methods
//        if (document.documentElement.requestFullscreen) {
//            document.documentElement.requestFullscreen();
//        } else if (document.documentElement.mozRequestFullScreen) {
//            document.documentElement.mozRequestFullScreen();
//        } else if (document.documentElement.webkitRequestFullscreen) {
//            document.documentElement.webkitRequestFullscreen(Element.ALLOW_KEYBOARD_INPUT);
//        }
//    } else {
//        if (document.cancelFullScreen) {
//            document.cancelFullScreen();
//        } else if (document.mozCancelFullScreen) {
//            document.mozCancelFullScreen();
//        } else if (document.webkitCancelFullScreen) {
//            document.webkitCancelFullScreen();
//        }
//    }
//}

//window.onload = function () {
//    toggleFullScreen();
//}

//// 判断各种浏览器，找到正确的方法
//function launchFullScreen(element) {
//    if (element.requestFullscreen) {
//        element.requestFullscreen();
//    } else if (element.mozRequestFullScreen) {
//        element.mozRequestFullScreen();
//    } else if (element.webkitRequestFullscreen) {
//        element.webkitRequestFullscreen();
//    } else if (element.msRequestFullscreen) {
//        element.msRequestFullscreen();
//    }
//}
//// 启动全屏!
//launchFullScreen(document.documentElement); // 整个网页