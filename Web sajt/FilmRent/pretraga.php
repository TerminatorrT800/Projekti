<?php
include_once("funkcionalnosti/db.php");

$pretraga = $_POST['izbor'];
$izbor = "%$pretraga%";
$query = "SELECT * FROM film WHERE naziv LIKE '$izbor'";

$result = mysqli_query($conn, $query);

if ($result->num_rows > 0) {
    while ($film = mysqli_fetch_assoc($result)) {
        echo '<div class="film">';
        echo '<img src="' . $film['slika'] . '" class="slika"/>';
        echo '<div>';
        echo '<a name="' . $film['id'] . '" class="naslov" href="prikazfilma.php?id=' . $film['id'] . '">' . $film['naziv'] . '</a>';
        echo '<div class="opis">';
        echo '<p class ="godinaIzdanja">' . $film['godizdanja'] . '</p>';
        echo '<p class="ocena">Ocena: ' . $film['ocena'] . '/10<img src="imgs/IMDB.png" class="imdb"/></p>';
        echo '<p class="godinaIzdanja">Trajanje ' . $film["trajanje"] . ' mins</p>';
        echo '</div></div>';
        echo '<div class="opis2">';
        $imeFilma = $film["naziv"];
        
        $glumacupit = $conn->prepare("SELECT glumac.ime, glumac.prezime FROM glumac JOIN uloga ON glumac.glumac_id = uloga.glumac_id JOIN film ON uloga.film_id = film.id WHERE film.naziv =?");
        $glumacupit->bind_param('s', $imeFilma);
        $glumacupit->execute();
        $glumcarez = $glumacupit->get_result();
        echo '<p class="godinaIzdanja" id="glumi">&#x2022; Glumi: ';
        if ($glumcarez != false) {
            if (mysqli_num_rows($glumcarez) > 0) {
                $brojredova = mysqli_num_rows($glumcarez);
                $trenutanRed = 1;
                while ($glumac = mysqli_fetch_assoc($glumcarez)) {
                    echo '<a class="godinaIzdanja" href="#" onclick="glumci(this)">';
                    if ($trenutanRed == $brojredova) {
                        echo $glumac["ime"] . " " . $glumac["prezime"];
                    } else {
                        echo $glumac["ime"] . " " . $glumac["prezime"] . ", ";
                    }
                    $trenutanRed++;
                    echo '</a>';
                }
            } else {
                echo " Nema informacija u bazi podataka";
            }
        } else {
            echo "Nema informacija u bazi podataka";
        }

        echo '</p><p id="reditelj" class="godinaIzdanja">&#x2022; Režiser(i): ';
        $rediteljupit = $conn->prepare("SELECT reditelj.ime, reditelj.prezime FROM reditelj JOIN reditelj_film ON reditelj.reditelj_id = reditelj_film.reditelj_id JOIN film ON reditelj_film.film_id = film.id WHERE film.naziv =?");
        $rediteljupit->bind_param('s', $imeFilma);
        $rediteljupit->execute();
        $rediteljrez = $rediteljupit->get_result();
        if ($rediteljrez != false) {
            if (mysqli_num_rows($rediteljrez) > 0) {
                $brojredova = mysqli_num_rows($rediteljrez);
                $trenutanRed = 1;
                while ($reditelj = mysqli_fetch_assoc($rediteljrez)) {
                    echo '<a class="godinaIzdanja" href="#" onclick="reditelji(this)">';
                    if ($trenutanRed == $brojredova) {
                        echo $reditelj['ime'] . " " . $reditelj['prezime'];
                    } else {
                        echo $reditelj['ime'] . " " . $reditelj['prezime'] . ", ";
                    } 
                    $trenutanRed += 1;
                    echo'</a>';
                }
            } else {
                echo "Nema informacija u bazi podataka";
            }
        } else {
            echo "Nema informacija u bazi podataka";
        }
        echo '</p></div></div>';
    }
}



?>