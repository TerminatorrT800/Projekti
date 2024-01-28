<?php

include_once('db.php');
session_start();
$id = $_SESSION['id'];
$filmID = $_REQUEST['id'];
$upit = $conn->prepare("DELETE FROM korpa WHERE film_id = ? AND korisnik_id = ?");
$upit->bind_param("ii", $filmID, $id);

$upit->execute();