<?php

include_once('db.php');
session_start();
$id = $_SESSION['id'];

$upit = $conn->prepare ("SELECT cena FROM korpa where korisnik_id = ?");
$upit->bind_param("i", $id);
$upit->execute();
$rez = $upit->get_result();
$suma =0;
if($rez!=false){
    if(mysqli_num_rows($rez)>0){
        while($data = mysqli_fetch_assoc($rez)){
            $suma+=$data["cena"];
        }    
        echo $suma;
    }else{
        echo "0";
    }
}else{
    echo 'Problem sa bazom podataka!';
}
?>