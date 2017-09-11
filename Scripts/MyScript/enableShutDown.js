function SearchTickethover() {
    function topicsHover() {
        $('.enable-shutdown-topics').css('opacity', '1');
        $('.all-themes').height(540);
        $('.all').css('display', 'none');
    }
    function topicsHoverOut() {
        $('.all-themes').height(378);
        $('.all').css('display', 'block');
        $('.enable-shutdown-topics').css('opacity', '0');
    }
    $('.topics').hover(topicsHover, topicsHoverOut);
};
    function ticketSearch (search) {
            if (search == false) {
                for (var i = 1; i <= 31; i++) {
                    $('.autoNext-' + i).prop('checked', true);
                    $('.autoNext-' + i).css("left", 3);
                }
            } else {
                for (var i = 1; i <= 31; i++) {
                    $('.autoNext-' + i).prop('checked', false);
                    $('.autoNext-' + i).css("left", 43);
                }
            }
}
