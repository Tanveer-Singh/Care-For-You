/// <reference path="jquery-1.8.2-vsdoc.js" />
/// <reference path="jquery-ui-1.8.11.js" />


$(document).ready(function () {

    $('#gvTheGrid tbody tr').live('hover', function () {
        $(this).toggleClass('clickable');
    }).live('click', function () {
        var name = $(this).find('td:first').text();
        //location.href = '/Details/' + $(this).find('td:last').text();
    });


    $("#dialog-modal").dialog({
        autoOpen: false,
        modal: true,
        height: 200,
        width: 500,
        resizable: true       

    });

    $('.OpenDialog').click(function () {
        //$('#dialog-modal').dialog("open");
        $('#dialog-modal').dialog("open");
        return false;

    });

});