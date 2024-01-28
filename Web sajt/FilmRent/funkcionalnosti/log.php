<?php

include_once("db.php");
session_start();
$email =stripcslashes( $_REQUEST["email"]);
$password = stripcslashes($_REQUEST["password"]);
$md5= md5($password);

$query = $conn->prepare("SELECT * FROM korisnik WHERE email=? AND password=?");
$query->bind_param('ss', $email, $md5);
$query->execute();

$result = $query->get_result();

if($result->num_rows == 0){
    die(header("Location: ../login.php?error=3"));
}
else{
    $data = $result->fetch_object();
    $_SESSION["ime"] = $data->ime;
    $_SESSION["prezime"] = $data->prezime;
    $_SESSION["email"] = $data->email;
    $_SESSION['id'] = $data->id_korisnika;
    header("Location: ../pocetna.php");
}


?>