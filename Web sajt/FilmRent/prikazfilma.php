<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Prikaz filma</title>
    <link rel="stylesheet" href="css/bootstrap.css">
    <link rel="stylesheet" href="prikazfilma.css">
    <script type="text/javascript" src="jquery-3.7.1.js"></script>
    <script type="text/javascript" src="pretraga.js"></script>
    <script type="text/javascript" src="prikazfilm.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js"></script>
</head>
<?php
session_start();
include_once('funkcionalnosti/db.php');
if (!isset($_SESSION["email"])) {
    die(header("Location: login.php?error=4"));
}
$id = $_REQUEST['id'];
$upit = $conn->prepare("SELECT * FROM film WHERE id = ?");
$cenaFilma;
$upit->bind_param('i', $id);
$upitGlumac = $conn->prepare('SELECT * FROM glumac JOIN uloga ON glumac.glumac_id = uloga.glumac_id JOIN film ON uloga.film_id = film.id WHERE id=?');
$upitGlumac->bind_param('i', $id);
$upitReditelj = $conn->prepare("SELECT * FROM reditelj JOIN reditelj_film ON reditelj.reditelj_id = reditelj_film.reditelj_id JOIN film ON reditelj_film.film_id = film.id WHERE id=?");
$upitReditelj->bind_param('i', $id);
?>

<body>
    <nav class="navbar navbar-expand-lg navbar-light bg-light">
        <div class="container-fluid" style="margin:10px">
            <a class="navbar-brand" href="pocetna.php">Pocetna</a>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavAltMarkup" aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
                <ul class="navbar-nav mr-auto">
                    <li class="nav-item active">
                        <a class="nav-link" href="#">Dugme</a>
                    </li>
                    <li class="nav-item active">
                        <a class="nav-link" href="">Dugme</a>
                    </li>
                    <li class="nav-item active">
                        <a class="nav-link" href="korpa.php">Korpa</a>
                    </li>
                    <li class="nav-item active">
                        <a class="nav-link" href="funkcionalnosti/logout.php">Odjava</a>
                    </li>
                </ul>
                <form class="d-inline-flex ms-auto">
                    <input id="pretraga" class="form-control mr-sm-2" type="text" placeholder="Pretraga..." aria-label="Pretraga...">
                    <button class="btnNav btn btn-outline-light" onclick="pretrazi()" type="button">Pretraga</button>
                </form>
            </div>
        </div>
    </nav>

    <div class="row">

        <div class="col-1"></div>
        <div class="col-10">
            <div class="proba">
            </div>
            <div class="film row">
                <div class="col-4">
                    <a href="http://localhost/FilmRent/pocetna.php"><span><svg viewBox="0 0 24 24" role="presentation" style="width: 0.75rem; height: 0.75rem;">
                                <path d="M20,11V13H8L13.5,18.5L12.08,19.92L4.16,12L12.08,4.08L13.5,5.5L8,11H20Z" style="fill: currentcolor;">
                                </path>
                            </svg></span><span>Filmovi</span></a>

                    <?php
                    if ($upit->execute()) {
                        $rez = $upit->get_result();
                        while ($row = $rez->fetch_assoc()) {
                            $cenaFilma = $row['cena'];
                            echo '<h3>' . $row['naziv'] . '</h3>';
                    ?>

                            <div class="opis1">
                                <p style="margin-right: 10px;"><?php echo $row['godizdanja']  ?></p>
                                <p>•</p>
                                <p style="padding-left: 10px;"><?php echo $row['trajanje'] . 'min'  ?></p>
                                <p>•</p>
                                <p style="padding-left: 10px;">
                                    <?php echo $row["ocena"] . '/10'; ?><img src="imgs/IMDB.png" class="imdb" />
                                </p>
                            </div>
                            <p id="radnja"><?php echo $row['radnja']  ?></p>
                            <a href="#" class="btn btn-info btn-lg">
                                <span class="glyphicon glyphicon-play"></span> Gledaj trailer
                            </a>
                            <img style="display:block" class="slika" src="<?php echo $row['slika']  ?>">
                            <div style="display:flex; justify-content:center; width:335px; margin-top:10px; ">

                        <?php
                            $data = $row['kategorija'];

                            $niz = explode(" ", $data);
                            foreach ($niz as $element) {
                                echo '<button style="width:max-content; margin-left:5px;" class="btn" disabled>' . $element . '</button>';
                            }
                        }
                    }
                        ?>

                            </div>
                </div>
                <div class="col-8">
                    <div style="display:grid; grid-template-rows: 300px auto; justify-content:right; width:90%; height: 90%; color:white">
                        <div>
                            <h3>Glumci:</h3>
                            <?php
                            if ($upitGlumac->execute()) {
                                $rezglumac = $upitGlumac->get_result();
                                while ($dataGlumac = mysqli_fetch_assoc($rezglumac)) {
                                    echo '<p>' . $dataGlumac['ime'] . ' ' . $dataGlumac['prezime'] . ' ' . $dataGlumac['datumRodj'] . ' ' . $dataGlumac['zemljaporekla'] . '</p>';
                                }
                            }
                            ?>
                            <h3 style='margin-top:20px'>Reditelji:</h3>
                            <?php
                            if ($upitReditelj->execute()) {
                                $rezReditelj = $upitReditelj->get_result();
                                while ($dataReditelj = mysqli_fetch_assoc($rezReditelj)) {
                                    echo '<p>' . $dataReditelj['ime'] . ' ' . $dataReditelj['prezime'] . ' ' . $dataReditelj['datumRodj'] . ' ' . $dataReditelj['zemljaporekla'] . '</p>';
                                }
                            }
                            ?>
                        </div>
                        <div style="display: flex; flex-direction: column; align-items: center; justify-content:end">
                            <button id="korpa" type="button" class="btn btin-primary" value="<?php echo $id; ?>" onclick="dodavanje(this)">Ubaci u korpu</button>
                            <p style="font-style:italic; font-size:xx-large"><?php echo $cenaFilma . '$' ?></p>
                        </div>
                    </div>
                </div>
            </div>
        </div>



    </div>

    <div id="footer">
        <div id=uzbuna class="alert alert-success" style="display:none;" role="alert"></div>
    </div>

</body>

</html>