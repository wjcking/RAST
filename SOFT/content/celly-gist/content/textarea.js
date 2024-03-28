
var textarea_id = "tea";

(function ($, undefined) {
    $.fn.getCursorPosition = function () {
        var el = $(this).get(0);
        var pos = 0;
        if ("selectionStart" in el) {
            pos = el.selectionStart;
        } else if ("selection" in document) {
            el.focus();
            var Sel = document.selection.createRange();
            var SelLength = document.selection.createRange().text.length;
            Sel.moveStart("character", -el.value.length);
            pos = Sel.text.length - SelLength;
        }
        return pos;
    };
})(jQuery);

$(document).keydown(function (e) {
    text = document.getElementById(textarea_id);
    if (e.which == 9) {
        var cursor_pos = $(text).getCursorPosition();
        $(text).val($(text).val().slice(0, cursor_pos) + "\t" + $(text).val().slice(cursor_pos)
        );
        text.focus();
        text.setSelectionRange(cursor_pos + 1, cursor_pos + 1);
        return false;
    }
    if (e.which == 13) {
        var cursor_pos = $(text).getCursorPosition();
        var notelines = $(text).val().slice(0, cursor_pos).split("\n");
        var listline = notelines[notelines.length - 1];
        var n = 0;
        while (listline[n] == "\t") {
            n += 1;
        }
        $(text).val($(text).val().slice(0, cursor_pos) + "\n" + $(text).val().slice(cursor_pos)
        );
        for (i = n; i > 0; i--) {
            $(text).val($(text).val().slice(0, cursor_pos + 1) + "\t" + $(text).val().slice(cursor_pos + 1)
            );
        }
        text.focus();
        text.setSelectionRange(cursor_pos + n + 1, cursor_pos + n + 1);
        var height = $("#tea")[0].scrollHeight;
        $("#tea").scrollTop(height);
        return false;
    }
});
