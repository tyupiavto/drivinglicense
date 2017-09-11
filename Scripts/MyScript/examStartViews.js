var incorrectAnswers, correctIncorrect, sameTicket, newTicket, questionsQuantity, answer;
var Response;
var ticket_test;
var result;
var response;
var skip;
var end;
var ticketSkip;
var ticketLenght;
var answertest;
var answerId;
var currentTargetId;
var nextTicketRemove;
var correctQuantity = 0;
var errorQuantity = 0;
var CorrectAnswers;
var WrongAnswers;
var CorrectWrongClose;
var item = 0, corerrLength = 0, valueError, countError, redError;
var QuestionsTopicsArray = [];
function tick(skip, end, answertest, CorrectOpen, WrongClose,CorrectWrongCloseClick) {
    if (CorrectOpen == true) {
        CorrectAnswers = true;
    }
    else {
        CorrectAnswers = false;
    }
    if (WrongClose == true) {
        WrongAnswers = true;
    }
    else {
        WrongAnswers = false;
    }
    if (CorrectWrongCloseClick == true) {
        CorrectWrongClose = true;
    }
    else {
        CorrectWrongClose = false;
    }
    if (skip == true) {
        ticketSkip = true;
    }
    if (skip == false) {
        ticketSkip = false;
    }

    if (end == 0) {
        sameTicket = true;
        correctQuantity = 0;
        errorQuantity = 0;
        $('#true').text(correctQuantity);
        $('#false').text(errorQuantity);
        $('#ticket-number-now').text(correctQuantity + errorQuantity + 1);
    }
    else {
        sameTicket = false;
    }
    if (end == 1) {
        newTicket = true;
        correctQuantity = 0;
        errorQuantity = 0;
        $('#true').text(correctQuantity);
        $('#false').text(errorQuantity);
        $('#ticket-number-now').text(correctQuantity + errorQuantity + 1);
    }
    else {
        newTicket = false;
    }
    answer = answertest;
}
function nextTicket(currentTargetId) {
    answer = currentTargetId;
    if (currentTargetId == response.Dataresult.CorrectAnswer) {
        $('#' + currentTargetId).css('background-color', 'green');
        $('.' + response.Dataresult.CorrectAnswer).text("");
        $('.' + response.Dataresult.CorrectAnswer).addClass("glyphicon glyphicon-ok");
    }
    else {
        $('#' + currentTargetId).css('background-color', 'red');
        $('#' + response.Dataresult.CorrectAnswer).css('background-color', 'green');
        $('.' + currentTargetId).text("");
        $('.' + response.Dataresult.CorrectAnswer).text("");
        $('.' + response.Dataresult.CorrectAnswer).addClass("glyphicon glyphicon-ok");
        $('.' + currentTargetId).addClass("glyphicon glyphicon-remove");
    }
}


function resultShow(answer, nextTicketRemove, valueError, countError) {
    if (nextTicketRemove == true) {
        $('.' + response.Dataresult.CorrectAnswer).removeClass("glyphicon glyphicon-ok");
        $('.' + answer).removeClass("glyphicon glyphicon-remove");
        
        $('#1').css('background-color', 'rgba(4, 47, 79, 0.99)');
        $('#2').css('background-color', 'rgba(4, 47, 79, 0.99)');
        $('#3').css('background-color', 'rgba(4, 47, 79, 0.99)');
        $('#4').css('background-color', 'rgba(4, 47, 79, 0.99)');

        $('.' + response.Dataresult.CorrectAnswer).text(response.Dataresult.CorrectAnswer);
        $('.' + answer).text(answer);
    }

    $.ajax({
        type: 'POST',
        data: {
            'ticketSkip': ticketSkip, 'answer': answer, 'sameTicket': sameTicket, 'newTicket': newTicket, 'ticketLenght': ticketLenght, 'CorrectAnswers': CorrectAnswers,'WrongAnswers': WrongAnswers, 'CorrectWrongClose': CorrectWrongClose, 'CorrectItem': item, 'indcount': valueError, 'count': countError },
        dataType: 'json',
        url: '/Exam/StartPageLoad',
        success: function (Response) {
            response = Response;
            testEnd = Response.testEnd;
            incorrectAnswers = true;
            correctIncorrect = false;
           
            if (valueError == 0) {
                if (Response.testErr == 0 || Response.testErr == 1) {
                    $('.w3-display-left').css('display', 'none');
                }
                else {
                    $('.w3-display-left').css('display', 'block');
                }
                corerrLength = Response.testErr;
                item = Response.testErr - 1;
                valueError = 1;
                $('.carousel-indicators').append('<ol>');
                for (var i = 0; i < corerrLength; i++) {
                    $('.carousel-indicators').append('<li data-target="#myCarousel" id=data-' + i + ' data-slide-to=' + i + '></li>');
                }
                $('.carousel-indicators').css({ bottom: "-575px" });
                $('.carousel-indicators li').css({ margin: "7px" });
                $('#data-' + item).addClass("active");
            }
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

            if (WrongAnswers == true) {
                $('.answer-' + (Response.Dataresult.CorrectAnswer)).css('background-color', 'green');
                $('.answer-' + (Response.error)).css('background-color', 'red');
                $('.' + Response.Dataresult.CorrectAnswer).text("");

                $('.' + Response.Dataresult.CorrectAnswer).addClass("glyphicon glyphicon-ok");
                $('.' + (Response.error)).addClass("glyphicon glyphicon-remove");
                $('.' + (Response.error)).text("");
            }
            if (CorrectAnswers == true) {
                $('.answer-' + (Response.Dataresult.CorrectAnswer)).css('background-color', 'green');
                $('.' + Response.Dataresult.CorrectAnswer).text("");
                $('.' + Response.Dataresult.CorrectAnswer).addClass("glyphicon glyphicon-ok");
            }
  
            $('#ticket-number-sum').text('/' + Response.ticketLenght);

            $('.text-read-1').text(Response.Dataresult.AnswerOne);
            $('.text-read-2').text(Response.Dataresult.AnswerTwo);
            $('.text-read-3').text(Response.Dataresult.AnswerThree);
            $('.text-read-4').text(Response.Dataresult.AnswerFour);

            $('#img').attr('src', '/image/' + Response.Dataresult.ImageNumber + '.jpg');
            $('#imgCorrect').append('<img src="/image/' + Response.Dataresult.ImageNumber + '.jpg">');

            $('.answer-1').css("height", "50%");
            $('.answer-2').css("height", "50%");

            $('.answer-3').css("display", "block");
            $('.answer-4').css("display", "block");

            if (Response.Dataresult.ImageSize == 1) {
                if (Response.Dataresult.AnswersPoints == 2) {
                    $('.answer-1').css("height", "100%");
                    $('.answer-2').css("height", "100%");

                    $('.answer-3').css("display", "none");
                    $('.answer-4').css("display", "none");
                }
                $('.answers').height(111);
                $('#img').height(402);
            }

            if (Response.Dataresult.ImageSize == 2) {
                $('.answers').height(231);
                $('#img').height(282);
            }

            if (Response.Dataresult.ImageSize == 3) {
                $('.answers').height(345);
                $('#img').height(168);
            }

            if (Response.Dataresult.AnswerThree == "") {
                $('.answer-3').css("display", "none");
            }
            else {
                $('.answer-3').css("display", "block");
            }
            if (Response.Dataresult.AnswerFour == "") {
                $('.answer-4').css("display", "none");
            }
            else {
                $('.answer-4').css("display", "block");
            }
            if (testEnd == Response.ticketLenght && $('.container-carusel').css('display') != "block") {
                if (correctQuantity < Response.ticketLenght - 3) {
                    $('.test-result-message').css("display", "none");
                }
                if (correctQuantity >= Response.ticketLenght - 3) {
                    $('.test-result-message-error').css("display", "none");
                }
                $('.test-result-ticket').css("display", "block");
                $('.ticket-container').css("opacity", "0");
                stopFunction(); // timer stop
            }
            else {
                $('.ticket-container').css("opacity", "1");
            }
            $('#yes').click(function () {
                $('.test-result-ticket').css("display", "block");
                $('.ticket-container').css("opacity", "0");
                $('#true-img').attr('src', '/Image/HomePage/green.png');
                $('#false-img').attr('src', '/Image/HomePage/red.png');
                stopFunction(); // timer stop
                if (correctQuantity >= Response.ticketLenght - 3) {
                    $('.test-result-message').css("display", "block");
                    $('.test-result-message-error').css("display", "none");
                }
                else {
                    $('.test-result-message-error').css("display", "block");
                    $('.test-result-message').css("display", "none");

                }
            });
        }
    });
}

function closeHover() {
    if ($('.glyphicon-list').css('display') == 'none') {
        $('.definition-button').css('display', 'none');
    }
}
function OpenHover() {
    $('.definition-button').css('display', 'block');

    if ($('.glyphicon-list').css('display') == 'none') {
        $('.glyphicon-list-alt').css('display', 'block');
    }
}
function definitionOpen() {
    $('.glyphicon-list-alt').css('display', 'none');
    $('.glyphicon-list').css('display', 'block');
    $('.definition-box').css('display', 'block');
    $('.definition-box-inner').css('display', 'block');
    $('.definition-text').text(response.Dataresult.Definition);
} 
function definitionClose() {
    $('.definition-box').css('display', 'none');
    $('.glyphicon-list-alt').css('display', 'block');
    $('.glyphicon-list').css('display', 'none');
}
 
function clickRotate(answerId, skip) {
    WrongCorrect = false;
    if (answerId != 0) {
        if (answerId == response.Dataresult.CorrectAnswer) {
            correctQuantity++;
            $('#true-img').attr('src', '/image/' + response.Dataresult.ImageNumber + '.jpg');
            $('#true').text(correctQuantity);
            $('.ticket-container').addClass('rotateCorrect').removeClass('rotateShow');
            setTimeout(function () {
                $('.ticket-container').addClass('rotateShow').removeClass('rotateCorrect');
            }, 300);
        }
        if (answerId != response.Dataresult.CorrectAnswer && skip != 0) {
            errorQuantity++;
            $('#false-img').attr('src', '/image/' + response.Dataresult.ImageNumber + '.jpg');
            $('#false').text(errorQuantity);
            $('.ticket-container').addClass('rotateInvalid').removeClass('rotateShow');
            setTimeout(function () {
                $('.ticket-container').addClass('rotateShow').removeClass('rotateInvalid');
            }, 300);
        }
        if (skip == 0) {
            $('.ticket-container').addClass('rotateSkip').removeClass('rotateShow');
            setTimeout(function () {
                $('.ticket-container').addClass('rotateShow').removeClass('rotateSkip');
            }, 350);
        }
        $('#ticket-number-now').text(correctQuantity + errorQuantity);
    }
}