<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="css/bootstrap.css">
    <script src="jquery-3.7.1.js"></script>
</head>

<body>
    <div class="container">
        <div class="row">
            <div class="col-2"></div>
            <div class="col-8">
                <div class="card text-white bg-dark">
                    <div class="card-header">Login stranica</div>
                    <div class="card-body">
                        <p class="card-text">
                        <form action="funkcionalnosti/log.php" method="POST">
                            <div class="form-group">
                                <label for="email">Email adresa</label>
                                <input type="email" name="email" class="form-control" placeholder="Unesite email"
                                    required>
                            </div>
                            <div class="form-group">
                                <label for="password">Šifra</label>
                                <input type="password" name="password" class="form-control" placeholder="Šifra"
                                    required>
                            </div>
                            <button type="submit" class="btn btn-primary mt-3">Prosledi</button>
                            <button type="button" class="btn btn-primary mt-3"><a style="color: white;"
                                    href="register.php">Registracija</a></button>
                        </form>
                        </p>
                    </div>
                    <div class="card-footer">
                        <?php
                        if (isset($_REQUEST["error"])) {
                            if ($_REQUEST["error"] == 3) {
                                echo '<div class="alert alert-danger" role="alert">';
                                echo 'Ne postoji ovakav nalog!</div>';
                            }
                            if ($_REQUEST["error"] == 4) {
                                echo '<div class="alert alert-danger" role="alert">';
                                echo 'Niste prijavljeni!</div>';
                            }
                        } else if (isset($_REQUEST["success"])) {
                            if ($_REQUEST["success"] == 1) {
                                echo '<div class="alert alert-success" role="alert">';
                                echo 'Uspesno ste kreirali nalog!</div>';
                            }
                            if ($_REQUEST["success"] == 2) {
                                echo '<div class="alert alert-success" role="alert">';
                                echo 'Uspesno ste se odjavili sa naloga!</div>';
                            }
                        }
                        ?>
                    </div>
                </div>
            </div>
            <div class="col-2"></div>
        </div>
    </div>
</body>

</html>