<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Korpa</title>
    <link rel="stylesheet" href="css/bootstrap.css">
    <link rel="stylesheet" href="korpastyle.css">
    <script type="text/javascript" src="jquery-3.7.1.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js"></script>
    <script type="text/javascript" src="korpa.js"></script>
    <script type="text/javascript" src="pretraga.js"></script>

</head>
<?php
session_start();
if (!isset($_SESSION["email"])) {
    die(header("Location: login.php?error=4"));
}
?>
<body>
<nav class="navbar navbar-expand-lg navbar-light bg-light">
        <div class="container-fluid" style="margin:10px">
            <a class="navbar-brand" href="pocetna.php">Pocetna</a>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavAltMarkup"
                aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
                <ul class="navbar-nav mr-auto">
                    <li class="nav-item active">
                        <a class="nav-link" href="#">Dugme</a>
                    </li>
                    <li class="nav-item active">
                        <a class="nav-link" href="">Dugme</a>
                    </li>
                    <li class="nav-item active">
                        <a class="nav-link" href="korpa.php">Korpa</a>
                    </li>
                    <li class="nav-item active">
                        <a class="nav-link" href="funkcionalnosti/logout.php">Odjava</a>
                    </li>
                </ul>
                <form class="d-inline-flex ms-auto">
                    <input id="pretraga" class="form-control mr-sm-2" type="text" placeholder="Pretraga..."
                        aria-label="Pretraga...">
                    <button class="btnNav btn btn-outline-light my-2 my-sm-0" onclick="pretrazi()"
                        type="button">Pretraga</button>
                </form>
            </div>
        </div>
    </nav>
    <div class="stranica row">
        <div class="levideo">
                <h2>Korpa</h2>
            <hr>
            <div class="grid">
            </div>
        </div>


        <div class="desnideo">
            <h2>Rezime narudžbine</h2>
            <hr>
            <h4 class="brstavki">Broj stavki: <span id="broj"></span></h4>

            <div style="padding-top:16px; padding-bottom: 30px;">
                <div class="promoKod">
                    <h3>PROMO KOD:</h3>
                    <img class="uzvicnik" src="imgs/uzvicnik.png" alt=""/>
                    <div class="uzvicnik-tooltip fade">To all things and men I appertain,<br>
                        and yet by some am shunned and distained.<br>
                        Fondle me and ogle me til you're insane,<br>
                        but no blow can harm me, cause me pain.<br>
                        Children delight in me, elders take fright.<br>
                        Fair maids rejoice and spin.<br>
                        Cry and I weep, yawn and I sleep.<br>
                        Smile, and I shal grin.<br><br>
                        What am I?
                        <br><br><br>
                        Sve stvari i ljudi meni pripadaju,<br>
                        a opet me neki izbegavaju i preziru.<br>
                        Mazi me i bulji u mene dok ne poludiš,<br>
                        ali nijedan udarac ne može mi nauditi, ne može mi naneti bol.<br>
                        Deca se raduju meni, stariji se plaše.<br>
                        Lepotice se raduju i vrte.<br>
                        Plačem kad plačeš, zevam kad spavaš.<br>
                        Osmehni se, i ja ću se cerekati.<br><br>
                        Šta sam ja?
                    </div>
                </div>
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="inputGroup-sizing-default">PROMO KOD</span>
                    </div>
                    <input id="promo" type="text" class="form-control" aria-label="Default"
                        aria-describedby="inputGroup-sizing-default">
                </div>
                <button type="button" class="btn btn-success" onclick="promoKod(this)">Primeni</button>
            </div>
            <hr>

            <h4 class="cena">Ukupna cena: <span id="cena"></span></h4>

            <button style="margin-top:50px;" type="button" class="btn btn-primary btn-lg w-100">Završi sa
                kupovinom</button>

        </div>

    </div>
    <div id="footer"></div>


</body>

</html>