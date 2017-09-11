var value;
function bodyKeyDown(value) {
    $("body").keydown(function (e) {
        if ($('.answer-3').css("display") == "block" && e.key == 3) {
            if (checked != true) {
                tick(false, 2, e.key);
                clickRotate(e.key);
                resultShow(e.key);
            }
            else {
                nextTicket(e.key);
            }
            currentTargetId = e.key;
        }
        if ($('.answer-4').css("display") == "block" && e.key == 4) {
            if (checked != true) {
                tick(false, 2, e.key);
                clickRotate(e.key);
                resultShow(e.key);
            }
            else {
                nextTicket(e.key);
            }
            currentTargetId = e.key;
        }
        if (e.key == 1 || e.key == 2) {
            if (checked != true) {
                tick(false, 2, e.key);
                clickRotate(e.key);
                resultShow(e.key);
            }
            else {
                nextTicket(e.key);
            }
            currentTargetId = e.key;
        }
        if ($('.container-carusel').css("display") == "block") {
            if (e.keyCode == 37) { // left
                displayLeft(value);
            }
            else if (e.keyCode == 39) { // right
                displayRight(value);
            }
        }
    });

}