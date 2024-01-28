<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="style.css" />
    <link rel="stylesheet" href="css/bootstrap.css" />
    <script src="jquery-3.7.1.js"></script>
    <script type="text/javascript" src="pretraga.js"></script>
    <script type="text/javascript" src="funkcionalnosti/logout.js"></script>
    

</head>
<?php
include_once("funkcionalnosti/db.php");

session_start();

if (!isset($_SESSION["email"])) {
    die(header("Location: login.php?error=4"));
}



?>

<body>
    <nav class="navbar navbar-expand-lg navbar-light bg-light">
        <a class="navbar-brand m-sm-2" href="">Pocetna</a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navitem" aria-controls="navbarText" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navitem">
            <ul class="navbar-nav mr-auto">
                <li class="nav-item active">
                    <a class="nav-link" href="">Dugme</a>
                </li>
                <li class="nav-item active">
                    <a class="nav-link" href="">Dugme</a>
                </li>
                <li class="nav-item active">
                    <a class="nav-link" href="">Dugme</a>
                </li>
                <li class="nav-item active">
                    <a class="nav-link" onclick="logout()" href="">Odjava</a>
                </li>
            </ul>
        </div>
        <form class="d-inline-flex m-sm-2">
            <input id="pretraga" class="form-control mr-sm-2" type="text" placeholder="Pretraga..." aria-label="Pretraga...">
            <button class="btn btn-outline-dark my-2 my-sm-0" onclick="pretrazi()" type="button">Pretraga</button>
        </form>
    </nav>


    <div class="tabela">
        <table class="table">
            <thead>
                <tr>
                    <th id="prvakol" scope="col">#</th>
                    <th id="drugakol" scope="col">Naziv</th>
                    <th id="drugakol" scope="col">Godina izdanja</th>
                    <th id="drugakol" scope="col">Trajanje</th>
                    <th id="drugakol" scope="col">Ocena</th>
                    <th id="sestakol" scope="col">Dodaj u korpu</th>
                </tr>
            </thead>
            <tbody>
                <tr class='red'>
                    <?php
                    $br = 1;
                    $tabelaupit = 'SELECT * from film';
                    $tabelarez = mysqli_query($conn, $tabelaupit);
                    if (mysqli_num_rows($tabelarez) > 0) {
                        while ($film = mysqli_fetch_assoc($tabelarez)) {
                    ?>
                            <th style="width: 5%; text-align: left;" scope="row">
                                <?php echo $br; ?>
                            </th>
                            <td style="width: 20%; text-align: center;" scope="row">
                                <?php echo $film['naziv']; ?>
                            </td>
                            <td style="width: 20%; text-align: center;" scope="row">
                                <?php echo $film['godizdanja']; ?>
                            </td>
                            <td style="width: 20%; text-align: center;" scope="row">
                                <?php echo $film['trajanje']; ?>
                            </td>
                            <td style="width: 10%; text-align: center;" scope="row">
                                <?php echo $film['ocena'];
                                $br += 1; ?>
                            </td>
                            <td style="width: 9%; text-align: center;" scope="row">
                                <button style="border-radius: 25% ;" type="button" href="">🛒</button>
                            </td>
                </tr>
        <?php

                        }
                    } ?>
            </tbody>
        </table>
    </div>




</body>

</html>