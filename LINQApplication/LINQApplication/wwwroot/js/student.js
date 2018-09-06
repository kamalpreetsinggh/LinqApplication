
$('[data-attr="search"]').on('click', function () {
    $.ajax(
        {
            type: "POST",
            url: "/Student/SearchById",
            data: $('#inputSearchID').serialize(),
            success: function (response) {
                $('#loadOnStartUp').hide();
                $('#loadAfterSearch').html('');
                $('#loadAfterSearch').html(response);
            },
            error: function (err) {
                $('#loadOnStartUp').hide();
                $('#loadAfterSearch').html('');
                $('#loadAfterSearch').html(err.statusText);
            }
        });
});