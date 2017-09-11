function appearing() {
    $('.container-carusel').css('display', 'block');
    $('.image-container').css('display', 'block');
    $('.w3-display-right').css('display', 'none');
    $('.image-container').css('z- index', '1');
}
function CloseCorrectErrorWindow() {
    $('.container-carusel').css('display', 'none');
    $('.test-result-ticket').css('opacity', '1');
    if ($('.test-result-ticket').css('display') != "block") {
        tick(null, null, null, null, null, true);
        resultShow();
    }
    else {
        $('.ticket-container').css('opacity', '0');
    }
    $('#1').css('background-color', 'rgba(4, 47, 79, 0.99)');
    $('#2').css('background-color', 'rgba(4, 47, 79, 0.99)');
    $('#3').css('background-color', 'rgba(4, 47, 79, 0.99)');
    $('#4').css('background-color', 'rgba(4, 47, 79, 0.99)');
    $('.1').removeClass("glyphicon glyphicon-ok");
    $('.1').removeClass("glyphicon glyphicon-remove");
    $('.2').removeClass("glyphicon glyphicon-ok");
    $('.2').removeClass("glyphicon glyphicon-remove");
    $('.3').removeClass("glyphicon glyphicon-ok");
    $('.3').removeClass("glyphicon glyphicon-remove");
    $('.4').removeClass("glyphicon glyphicon-ok");
    $('.4').removeClass("glyphicon glyphicon-remove");

    $('.1').text(1);
    $('.2').text(2);
    $('.3').text(3);
    $('.4').text(4);
}
function CorrectOpen() {
    if ($('#true').html() != 0) {
        appearing();
        tick(null, null, null, true, null, null);
        resultShow(null, null, 0, 0);
        value = 0;
        Call = 1;
        classActive = $('#true').html() - 1;
        $('.carousel-indicators li').remove();
        $('.ticket-container').css("opacity", "1");
    }
}
function WrongOpen() {
    if ($('#false').html() != 0) {
        appearing();
        tick(null, null, null, null, true, null);
        resultShow(null, null, 0, 1);
        value = 1;
        Call = 1;
        classActive = $('#false').html() - 1;
        $('.carousel-indicators li').remove();
        $('.ticket-container').css("opacity", "1");
    }
}
document.getElementById("myCarousel").addEventListener("click", function (e) {
    var target = '#' + e.target.id;
    var item = target.substring(6, 8);

    if (item != "") {
        $('li').each(function () {
            $('.active').removeClass("active");
        });
        $(target).addClass("active");
        liCarusel(item, value);
    }
});
$('#data-' + item).addClass("active");
function displayLeft(valueError) {
    $('#1').css('background-color', 'rgba(4, 47, 79, 0.99)');
    $('#2').css('background-color', 'rgba(4, 47, 79, 0.99)');
    $('#3').css('background-color', 'rgba(4, 47, 79, 0.99)');
    $('#4').css('background-color', 'rgba(4, 47, 79, 0.99)');
    if (item != 0) {
        item -= 1;
        if (valueError == 1)
            resultShow(null, null, 1, 1);
        else
            resultShow(null, null, 1, 0);
        if (corerrLength != item)
            $('.w3-display-right').css('display', 'block');
        if (item == 0)
            $('.w3-display-left').css('display', 'none');
    }
    else {
        $('.w3-display-left').css('display', 'none');
    }
    $('li').each(function () {
        $('.active').removeClass("active");
    });
    $('#data-' + item).addClass("active");
}
function displayRight(valueError) {
    $('#1').css('background-color', 'rgba(4, 47, 79, 0.99)');
    $('#2').css('background-color', 'rgba(4, 47, 79, 0.99)');
    $('#3').css('background-color', 'rgba(4, 47, 79, 0.99)');
    $('#4').css('background-color', 'rgba(4, 47, 79, 0.99)');
    if (corerrLength != item + 1) {
        $('.w3-display-right').css('display', 'block');
        item += 1;
        if (valueError == 0)
            resultShow(null, null, 1, 0);
        else
            resultShow(null, null, 1, 1);
        if (corerrLength - 1 == item)
            $('.w3-display-right').css('display', 'none');
        if (item != 0)
            $('.w3-display-left').css('display', 'block');
    }
    $('li').each(function () {
        $('.active').removeClass("active");
    });
    $('#data-' + item).addClass("active");
}
function liCarusel(importance, valueError) {
    item = importance;
    if (valueError == 1)
        resultShow(null, null, 1, 1);
    else
        resultShow(null, null, 1, 0);
    if (corerrLength - 1 == item)
        $('.w3-display-right').css('display', 'none');
    else
        $('.w3-display-right').css('display', 'block');
    if (item != 0)
        $('.w3-display-left').css('display', 'block');
    else
        $('.w3-display-left').css('display', 'none');

}