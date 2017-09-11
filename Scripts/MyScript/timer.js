var timerStop;
function timerCall() {
    var count = 0;
    var returnCount = "0";
    function timerFunction(/*Termination*/) {

        count = count + 1;
        if (count >= 60) {
            var getMinutes = Math.floor(count / 60);
            var getHours = count % 60;
            var getSeconds = Math.floor(getMinutes / 6);

            if (getMinutes.toString().length == 1) {
                getMinutes = "0" + getMinutes;
            }
            if (getHours.toString().length == 1) {
                getHours = "0" + getHours;
            }

            $('#timer').html("00:" + getMinutes + ":" + getHours);
        }
        else {
            if (count.toString().length == 1) {
                returnCount = "0" + count;
            }
            else {
                returnCount = count;
            }
            $('#timer').html("00:00:" + returnCount);
        }

    }

    timerStop = setInterval(function () {
        timerFunction(); //timer gamodzaxeba
    }, 1000);
}
function stopFunction() {
    clearInterval(timerStop);
}