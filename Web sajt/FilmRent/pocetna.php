<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Pocetna</title>
    <link rel="stylesheet" href="css/bootstrap.css">
    <link rel="stylesheet" href="pocetnastyle.css">
    <script type="text/javascript" src="jquery-3.7.1.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js"></script>
    <script type="text/javascript" src="pretraga.js"></script>

</head>

<?php
include_once("funkcionalnosti/db.php");

$query = "SELECT * FROM film ORDER BY RAND()";
$result = mysqli_query($conn, $query);
$resetGlumac = 'UPDATE glumac SET prikazan = 0';
mysqli_query($conn, $resetGlumac);
$upit = "SELECT * FROM glumac WHERE prikazan = 0 ORDER BY RAND() LIMIT 8";
$rez = mysqli_query($conn, $upit);

session_start();
if (!isset($_SESSION["email"])) {
    die(header("Location: login.php?error=4"));
}


?>

<body>
    <nav class="navbar navbar-expand-lg navbar-light bg-light">
        <div class="container-fluid" style="margin:10px">
            <a class="navbar-brand" href="pocetna.php">Pocetna</a>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavAltMarkup" aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
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
                    <input id="pretraga" class="form-control mr-sm-2" type="text" placeholder="Pretraga..." aria-label="Pretraga...">
                    <button class="btnNav btn btn-outline-light" onclick="pretrazi()" type="button">Pretraga</button>
                </form>
            </div>
        </div>
    </nav>

    <div class="row">
        <h1 style="text-align:center; color:white; padding-top:40px;"><b>Dobrodošli na ...</b></h1>
        <hr style="color:white; margin: auto; width: 70%; ">
    </div>


    <div class="row">
        <div class="col-2">
            <div class="glumci">
                <h2 style="color:white; padding-bottom: 30px;">Glumci:</h2>
                <?php
                while ($data = mysqli_fetch_assoc($rez)) { ?>
                    <a id="glumcihover" onclick="glumci(this)"><?php echo $data['ime'] . ' ' . $data['prezime'] . '</a>';
                                                                $updateUpit = 'UPDATE glumac SET prikazan = 1 WHERE glumac_id = ' . $data['glumac_id'];
                                                                mysqli_query($conn, $updateUpit);
                                                            }
                                                                ?>
                    <button type="button" class="btn btn-link" onclick="prikaziGlumce()">Prikazi jos</button>
            </div>
            <div class="glumci">
                <h2 style="color:white; padding-bottom: 30px;">Žanr:</h2>
                <a id="glumcihover" onclick="zanr(this)">Akcija</a>
                <a id="glumcihover" onclick="zanr(this)">Avantura</a>
                <a id="glumcihover" onclick="zanr(this)">Fantastika</a>
                <a id="glumcihover" onclick="zanr(this)">Drama</a>
                <a id="glumcihover" onclick="zanr(this)">Krimi</a>
                <a id="glumcihover" onclick="zanr(this)">Triler</a>
                <a id="glumcihover" onclick="zanr(this)">Ratni</a>
                <a id="glumcihover" onclick="zanr(this)">Biografija</a>
                <a id="glumcihover" onclick="zanr(this)">Komedija</a>
            </div>
        </div>
        <div class="col-lg-8 grid">

            <?php
            if (mysqli_num_rows($result) > 0) {
                while ($film = mysqli_fetch_assoc($result)) {
            ?>
                    <div class="film">
                        <img src="<?php echo $film["slika"]; ?>" class="slika" />
                        <div>
                            <a name="<?php echo $film["id"]; ?>" class="naslov" href="prikazfilma.php?id=<?php echo $film['id']; ?>">
                                <?php echo $film["naziv"]; ?>
                            </a>
                            <div class="opis">
                                <p class="godinaIzdanja">
                                    <?php echo $film["godizdanja"]; ?>
                                </p>
                                <p class="ocena">
                                    <?php echo 'Ocena: ' . $film["ocena"] . '/10'; ?><img src="imgs/IMDB.png" class="imdb" />
                                </p>
                                <p class="godinaIzdanja">
                                    <?php echo 'Trajanje: ' . $film["trajanje"] . " mins"; ?>
                                </p>
                            </div>
                        </div>
                        <div class="opis2">
                            <?php
                            $imeFilma = $film["naziv"];
                            $glumacupit = $conn->prepare("SELECT glumac.ime, glumac.prezime FROM glumac JOIN uloga ON glumac.glumac_id = uloga.glumac_id JOIN film ON uloga.film_id = film.id WHERE film.naziv =?");
                            $glumacupit->bind_param('s', $imeFilma);
                            $glumacupit->execute();
                            $glumcarez = $glumacupit->get_result();
                            ?>
                            <p class="godinaIzdanja" id="glumi">&#x2022; Glumi:
                                <?php
                                if ($glumcarez != false) {
                                    if (mysqli_num_rows($glumcarez) > 0) {
                                        $brojredova = mysqli_num_rows($glumcarez);
                                        $trenutanRed = 1;
                                        while ($glumac = mysqli_fetch_assoc($glumcarez)) { ?>
                                            <a class="godinaIzdanja" href="#" onclick="glumci(this)">
                                                <?php
                                                if ($trenutanRed == $brojredova) {
                                                    echo $glumac["ime"] . " " . $glumac["prezime"];
                                                } else {
                                                    echo $glumac["ime"] . " " . $glumac["prezime"] . ",";
                                                }
                                                $trenutanRed++;
                                                ?>
                                            </a>
                                <?php
                                        }
                                    } else {
                                        echo " Nema informacija u bazi podataka";
                                    }
                                } else {
                                    echo "Nema informacija u bazi podataka";
                                }
                                ?>
                            </p>
                            <p id="reditelj" class="godinaIzdanja">&#x2022; Režiser(i):
                                <?php
                                $rediteljupit = $conn->prepare("SELECT reditelj.ime, reditelj.prezime FROM reditelj 
                                                                JOIN reditelj_film ON reditelj.reditelj_id = reditelj_film.reditelj_id 
                                                                JOIN film ON reditelj_film.film_id = film.id 
                                                                WHERE film.naziv =?");
                                $rediteljupit->bind_param('s', $imeFilma);
                                $rediteljupit->execute();
                                $rediteljrez = $rediteljupit->get_result();
                                if ($rediteljrez != false) {
                                    if (mysqli_num_rows($rediteljrez) > 0) {
                                        $brojredova = mysqli_num_rows($rediteljrez);
                                        $trenutanRed = 1;
                                        while ($reditelj = mysqli_fetch_assoc($rediteljrez)) { ?>
                                            <a class="godinaIzdanja" href="#" onclick="reditelji(this)">
                                                <?php
                                                if ($trenutanRed == $brojredova) {
                                                    echo $reditelj['ime'] . " " . $reditelj['prezime'];
                                                } else {
                                                    echo $reditelj['ime'] . " " . $reditelj['prezime'] . ",";
                                                }
                                                $trenutanRed += 1;
                                                ?>
                                            </a>
                                <?php

                                        }
                                    } else {
                                        echo "Nema informacija u bazi podataka";
                                    }
                                } else {
                                    echo "Nema informacija u bazi podataka";
                                }

                                ?>
                            </p>
                        </div>
                    </div>
            <?php
                }
            }
            ?>


        </div>
    </div>
</body>

</html>