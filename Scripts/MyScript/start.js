function startPage() {
    $('.start-page-wrap').hide();
    $('.image-container').css('display', 'block');
    var QuestionsTopicsArray = [];
    var count=0;
    $('.inputNext').each(function (item) {
        if ($(this).prop('checked') == true) {
            QuestionsTopicsArray[count] = item + 1;
            count++;
        }
    });
    $.ajax({
        url: '/Exam/QuestionsTopics',
        type: 'POST',
        data: { 'ResultTopics': QuestionsTopicsArray },
        success: function (Response) {
            if (Response == 1) {
                resultShow();
            }
        }
    });
    return ;
}