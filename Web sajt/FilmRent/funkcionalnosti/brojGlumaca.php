<?php

include_once("db.php");

$ukupnoUpit = "SELECT COUNT(*) as ukupno FROM glumac";
$ukupnoRez = mysqli_query($conn, $ukupnoUpit);
if ($ukupnoRez) {
    $ukupno = mysqli_fetch_assoc($ukupnoRez);
    if (isset($ukupno['ukupno'])) {
        $ukupanBroj = $ukupno['ukupno'];
        echo $ukupanBroj;
    } else {
        echo "Nema rezultata u upitu.";
    }
} else {
    echo "Greška pri izvršavanju upita: " . mysqli_error($conn);
}


?>