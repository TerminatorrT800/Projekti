<?php

include_once('db.php');

$upit ="SELECT * FROM glumac WHERE prikazan = 0 ORDER BY RAND() LIMIT 4";
$rez = mysqli_query($conn, $upit);

while($data = mysqli_fetch_assoc($rez)){
    echo'<a id="glumcihover" onclick="glumci(this)">'. $data['ime'] .' '. $data['prezime'] . '</a>';
    $updateUpit = 'UPDATE glumac SET prikazan = 1 WHERE glumac_id = '. $data['glumac_id'];
    mysqli_query($conn, $updateUpit);

}



?>
