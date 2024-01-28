<?php

include_once('db.php');
session_start();
$id = $_SESSION['id'];

$upit = $conn->prepare("SELECT * FROM film JOIN korpa ON film.id = korpa.film_id JOIN korisnik ON korpa.korisnik_id = korisnik.id_korisnika WHERE korisnik_id =?");
$upit->bind_param("i", $id);
$upit->execute();
        echo'<span style="font-style:italic; margin-bottom:20px;">Detalji proizvoda:</span>';
        echo'<span style="font-style:italic;">Cena:</span>';
if ($upit->execute()) {
    $rez = $upit->get_result();
    while ($data = mysqli_fetch_assoc($rez)) {
        echo '<div class="film">';
        echo '<img class="slika" src="' . $data['slika'] . '">';
        echo '<div style="display:grid">';
        echo '<a href="prikazfilma.php?id='.$data['id'].'">' . $data['naziv']. '</a>';
        echo '<p style="margin-top: 50px;">' . $data['godizdanja'] . '</p>';
        echo '<button class="ukloni" type ="button" value="'.$data['id'].'" onclick="brisanje(this)"></button>';
        echo '<hr style="margin-top:30px">';
        echo '</div>';
        echo '</div>';
        echo '<p>'. $data['cena'] .'$</p>';
    }
} else {
    echo 'Problem sa bazom podataka!';
}
?>