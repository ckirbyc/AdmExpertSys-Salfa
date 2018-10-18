$(document).ready(function () {
    $('input.fecha').after("<span class='input-group-addon'><i class='glyphicon glyphicon-calendar'></i></span>");
    $("input.fecha").attr("readonly", "readonly");
    $("input.fecha").attr("style", "cursor:pointer");

    $.each($('.fechaContainer .input-group.date'), function (i, control) {
        $(control).datepicker({        
            format: "dd-mm-yyyy",
            minViewMode: 3,
            autoclose: true,
            language: 'es',
            orientation: "top left"
        });
    });

    $('input.fechaDiaMes').after("<span class='input-group-addon'><i class='glyphicon glyphicon-calendar'></i></span>");
    $("input.fechaDiaMes").attr("readonly", "readonly");
    $("input.fechaDiaMes").attr("style", "cursor:pointer");

    $.each($('.fechaContainerDiaMes .input-group.date'), function (i, control) {
        $(control).datepicker({
            changeDay: true,
            changeMonth: true,
            changeYear: false,
            format: "dd-MM",
            minViewMode: 3,
            autoclose: true,
            viewMode: "months",
            maxViewMode: "months",
            language: 'es',
            orientation: "top left"
        });
    });
});