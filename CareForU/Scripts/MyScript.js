/// <reference path="jquery-1.8.2-vsdoc.js" />
/// <reference path="jquery-ui-1.8.11.js" />


$(document).ready(function () {

    $('#gvTheGrid tbody tr').live('hover', function () {
        $(this).toggleClass('clickable');
    }).live('click', function () {
        var name = $(this).find('td:first').text();
        //location.href = '/Details/' + $(this).find('td:last').text();
    });

});