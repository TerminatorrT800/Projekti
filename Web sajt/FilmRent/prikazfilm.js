function visina() {
    var visina = $('.proba').height();
    $('.col-8').css('height', visina - 120);
    var dugme = $('#korpa').val();
}
function visinaGradienta() {
    var visina = $('div .col-4').height();
    $(".proba").css('height', visina * 0.8)
}

$(document).ready(function () {
    visinaGradienta();
    visina();
    $(window).resize(function () {
        visinaGradienta();
        visina();
    });

})

function dodavanje(data) {
    var id = $(data).val();
    $.ajax({
        type: 'POST',
        url: 'funkcionalnosti/punjenjeKorpe.php',
        data: { id: id },
        success: function (response) {
            var alert = '<div id="uzbuna" class="alert alert-success" role="alert">' + response + '</div>';
            $('#footer').html(alert);
            setTimeout(function () {
                $('#uzbuna').fadeOut(5000);
            }, 500);
            console.log("uspeh");
            console.log(response);
        }
    });
} 