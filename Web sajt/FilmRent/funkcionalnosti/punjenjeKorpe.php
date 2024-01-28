<?php

include_once('db.php');
session_start();
$id = $_SESSION['id'];
$idFilm = $_REQUEST['id'];
$upitFilm = $conn->prepare("SELECT cena FROM film WHERE id =?");
$upitFilm->bind_param('i', $idFilm);
$upitFilm->execute();
$rezfilm = $upitFilm->get_result();
$red = $rezfilm->fetch_assoc();
$cena = $red['cena'];
$upit = $conn->prepare("INSERT INTO korpa (film_id, korisnik_id, cena) VALUES (?,?,?)");
$upit->bind_param('iii', $idFilm, $id, $cena);

try {
 $upit->execute();
        echo 'Film je dodat u korpi';
    }
 catch (Exception $e) {
        echo 'Film se već nalazi u korpi.';
}


?>