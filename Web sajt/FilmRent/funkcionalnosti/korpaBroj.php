<?php

include_once('db.php');
session_start();
$id = $_SESSION['id'];

$upit = $conn->prepare ("SELECT COUNT(*) FROM korpa where korisnik_id = ?");
$upit->bind_param("i", $id);
$upit->execute();

if ($upit->execute()) {
    $upit->bind_result($brojRedova);
    $upit->fetch();

    echo $brojRedova;
} else {
    echo 'Problem sa bazom podataka!';
}
?>