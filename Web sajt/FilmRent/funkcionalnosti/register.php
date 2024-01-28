<?php
include_once("db.php");

$password = $_REQUEST["password"];
$passwordre = $_REQUEST["passwordre"];

if($password!=$passwordre){
    die(header("Location: ../register.php?error=1"));
}
else{
    $ime = $_REQUEST["ime"];
    $prezime = $_REQUEST["prezime"];
    $email =  $_REQUEST["email"];

    $query = $conn->query("SELECT * FROM korisnik WHERE email ='$email'");
    $num = $query->num_rows;
    if($num> 0){
        die(header("Location: ../register.php?error=2"));
    }

    $upis = $conn->prepare("INSERT INTO korisnik (ime, prezime, email, password) VALUES (?, ?, ?, ?)") ;
    $upis->bind_param("ssss",$ime, $prezime, $email, md5($password));
    if($upis->execute()){
    header("Location: ../login.php?success=1");
    }
    else{
        die("Error (" . $conn->errno .")". $conn->error);
    }
    
}

?>