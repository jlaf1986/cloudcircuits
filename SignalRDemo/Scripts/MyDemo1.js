
function RegisterRequestFriendshipTo(url) {
    $(document).on('click', '#submit_room1', function (e) {
        e.preventDefault();
        var parameters = { "key": e.target.id.substring(22) };
        $.post(url, parameters, function (data) {
            //$(e.target).closest('article.comment').remove();
            alert('you requested a friendship');
            //var json = eval(data);
            $(e.target).enabled = false;
            //$(e.target).val(data);
        });
    });
}