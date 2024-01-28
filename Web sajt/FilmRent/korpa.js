function cena() {
    $.ajax({
        type: 'GET',
        url: 'funkcionalnosti/korpaCena.php',
        success: function (response) {
            console.log(response);
            pokusaj = $('#promo').val();
            if (pokusaj == "odraz" || pokusaj == "refleksija" || pokusaj == 'reflection') {
                response = response * 0.5;
                $('#cena').html(response + "$");
            } else {
                $('#cena').html(response + "$");
            }
            console.log("Ukupna cena " + response);
        }
    });
};
function broj() {
    $.ajax({
        type: 'GET',
        url: 'funkcionalnosti/korpaBroj.php',
        success: function (response) {
            $('#broj').html(response);
            console.log("Broj stavki " + response);
        }
    });
};

function prikazi() {
    $.ajax({
        type: 'GET',
        url: 'funkcionalnosti/korpaStavke.php',
        success: function (response) {
            $('.grid').html(response);
        }
    })
};



$(document).ready(function () {
    $('.uzvicnik').hover(
        function () {
            $('.uzvicnik-tooltip').css('opacity', '1');
        },
        function () {
            $('.uzvicnik-tooltip').css('opacity', '0');
        }
    );

    cena();
    broj();
    prikazi();

});

function brisanje(data) {
    var id = $(data).val();
    $.ajax({
        type: 'POST',
        url: 'funkcionalnosti/korpaBrisanje.php',
        data: { id: id },
        success: function (response) {
            cena();
            broj();
            prikazi();
            var alert = '<div id="uzbuna" class="alert alert-success" role="alert">Film je uklonjen iz korpe.</div>';
            $('#footer').html(alert);
            setTimeout(function () {
                $('#uzbuna').fadeOut(5000);
            }, 500);
        }
    });
}


var broj_pokusaja = 1;
var pokusaj;
function promoKod(data) {
    pokusaj = $('#promo').val();
    pokusaj = pokusaj.toLowerCase();
    if (pokusaj == "odraz" || pokusaj == "refleksija") {
        var cena = $('#cena').text();
        var alert = '<div id="uzbuna" class="alert alert-success" role="alert">Very smart!</div>';
        cena = cena.replace('$', "");
        cena = cena * 0.5;
        $('#cena').html(cena);
        $('#cena').append("$");
        $('#promo').prop('disabled', true);
        $(data).prop('disabled', true);
        $('#footer').html(alert);

    }
    else {
        console.log(broj_pokusaja);
        if (broj_pokusaja >= 3 && broj_pokusaja < 6) {
            var alert = '<div id="uzbuna" class="alert alert-danger" role="alert">Ne idu vam baš zagonetke.</div>';
            $('#footer').html(alert);
            broj_pokusaja++;
        } else if (broj_pokusaja >= 6 && broj_pokusaja < 9) {
            var alert = '<div id="uzbuna" class="alert alert-danger" role="alert">Not very smart.</div>';
            $('#footer').html(alert);
            broj_pokusaja++;
        } else if (broj_pokusaja >= 9) {
            var alert = '<div id="uzbuna" class="alert alert-danger" role="alert">Not very smart, not at all.</div>';
            $('#footer').html(alert);
        }
        else {
            broj_pokusaja++;
            var alert = '<div id="uzbuna" class="alert alert-danger" role="alert">Ne ne.</div>';
            $('#footer').html(alert);
        }

    }
    setTimeout(function () {
        $('#uzbuna').fadeOut(5000);
    }, 500);

};