function pretrazi() {
    var izbor = $("#pretraga").val();
    if (izbor != "") {
        var pocetnaStr = "http://localhost/FilmRent/pocetna.php";

        if (!window.location.href.startsWith(pocetnaStr)) {
            window.location.href = pocetnaStr + "?izbor=" + izbor;
        } else {
            $.ajax({
                type: "POST",
                url: "pretraga.php",
                data: { izbor: izbor },
                success: function (response) {
                    $(".grid").html(response);
                    postaviVisinu();
                }
            });
        }
    }
}

function getParameterValue(parameterName) {
    var url = window.location.href;
    parameterName = parameterName.replace(/[\[\]]/g, "\\$&");
    var regex = new RegExp("[?&]" + parameterName + "(=([^&#]*)|&|#|$)"),
        results = regex.exec(url);
    if (!results) return null;
    if (!results[2]) return '';
    return decodeURIComponent(results[2].replace(/\+/g, " "));
}

$(document).ready(function () {
    postaviVisinu();
    $(window).resize(function () {
        postaviVisinu();
    });

    $("#pretraga").keypress(function (e) {
        if (e.which === 13) {
            e.preventDefault();
            pretrazi();
        }
    });

    var izborValue = getParameterValue('izbor');

    if (izborValue !== null) {
        $.ajax({
            type: "POST",
            url: "pretraga.php",
            data: { izbor: izborValue },
            success: function (response) {
                $(".grid").html(response);
                postaviVisinu();
            }
        });
    }

    $(".slika").click(function () {
        var naslov = $(this).closest(".film").find(".naslov").text();
        var id = $(this).closest(".film").find(".naslov").attr("name");
        uvecajSliku(this, naslov, id);
    });

    
        $('#pretraga').on('input', function(){
            if (window.location.href.startsWith("http://localhost/FilmRent/pocetna.php")){
                pretrazi();
            }
        });
    

});


function glumci(tekst) {
    var vrednost = $(tekst).text();
    var deloviImena = vrednost.trim()
    deloviImena = deloviImena.replace(",", "");
    deloviImena = deloviImena.split(' ');
    if (deloviImena.length > 2) {
        var ime = deloviImena[0] + ' ' + deloviImena[1];
        var prezime = deloviImena.slice(2).join(' ');
    }
    else {
        var ime = deloviImena[0];
        prezime = deloviImena[1];
    }

    $.ajax({
        type: "POST",
        url: "pretragaGlumac.php",
        data: { ime: ime, prezime: prezime },
        success: function (response) {
            $(".grid").html(response);
            postaviVisinu();
        }
    });
}
function zanr(tekst) {
    var vrednost = $(tekst).text();
    $.ajax({
        type: 'POST',
        data: { vrednost: vrednost },
        url: 'funkcionalnosti/pretragaZanr.php',
        success: function (response) {
            $('.grid').html(response);
            postaviVisinu();
        }
    })

}

function reditelji(tekst) {
    var vrednost = $(tekst).text();
    prvoIme = vrednost.trim();
    punoIme = prvoIme.replace(/\s+/g, " ");
    punoIme = punoIme.replace(",", "");
    punoIme = punoIme.split(' ');
    var ime;
    var prezime;
    if (punoIme.length > 0) {
        ime = punoIme[0];
        prezime = punoIme[1];
        $.ajax({
            type: "POST",
            url: "pretragaReditelj.php",
            data: { ime: ime, prezime: prezime },
            success: function (response) {
                $(".grid").html(response);
                postaviVisinu();
            }
        });
    }
    else {
        console.log("Problem pri dobavljanju imena režisera.")
    }
}

function prikaziGlumce() {
    $(".btn-link").css("display", 'none');
    $.ajax({
        type: "GET",
        url: "funkcionalnosti/prikazGlumaca.php",
        success: function (response) {
            $(".glumci").first().append(response);
        },
        error: function (error) {
            console.error("Greška pri dohvatanju glumaca:", error);
        }
    });
}

function postaviVisinu() {

    $(".film").each(function () {
        var slika = $(this).find(".slika").height();
        var naslov = $(this).find(".naslov").height();
        var opis = slika - naslov;
        $(this).find(".opis").height(opis);
    });

}

function uvecajSliku(slikaURL, naslov, id) {
    var overlayDiv = $("<div>")
        .attr("id", "uvecajSlikuOverlay")
        .css({
            position: "fixed",
            top: "0",
            left: "0",
            width: "100%",
            height: "100%",
            backgroundColor: "rgba(0, 0, 0, 0.8)",
            display: "flex",
            alignItems: "center",
            justifyContent: "center",
            flexDirection: "column",
            opacity: 0
        })
        .click(function () {
            $(this).fadeOut("slow", function () {
                $(this).remove();
            });
        });

    var uvecanaSlika = $("<img>")
        .attr("src", $(slikaURL).attr('src'))
        .css({
            maxWidth: "80%",
            maxHeight: "80%",
        });
    var naziv = $("<a>")
        .attr("href", 'prikazfilma.php?id=' + id)
        .text(naslov)
        .css({
            color: "white",
            fontSize: "36px",
            fontStyle: "Italic",
            marginTop: "20px",
            opacity: 0,
        });

    overlayDiv.append(uvecanaSlika).append(naziv);
    overlayDiv.animate({ opacity: 1 }, "swing", function () {
        overlayDiv.find(':last-child').animate({ opacity: 1 }, "normal")
    });

    $("body").append(overlayDiv);
}

