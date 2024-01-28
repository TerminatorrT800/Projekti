<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Registracija</title>
    <link rel="stylesheet" href="css/bootstrap.css">
</head>
<body>
    <div class="container">
        <div class="row">
            <div class="col-2">

            </div>
            <div class="col-8">

                <div class="card text-white bg-dark">
                    <div class="card-header">Register stranica</div>
                    <div class="card-body">
                        <p class="card-text">

                        <form action="funkcionalnosti/register.php" method="POST">
                            <div class="form-group">
                                <label for="ime">Ime</label>
                                <input type="text" name="ime" class="form-control" placeholder="Unesite ime" required>
                            </div>
                            <div class="form-group">
                                <label for="prezime">Prezime</label>
                                <input type="text" name="prezime" class="form-control" placeholder="Unesite prezime" required>
                            </div>
                            <div class="form-group">
                                <label for="email">Email</label>
                                <input type="email" name="email" class="form-control" placeholder="Unesite email" required>
                            </div>
                            <div class="form-group">
                                <label for="password">Password</label>
                                <input type="password" name="password" class="form-control" placeholder="Unesite Password" required>
                            </div>
                            <div class="form-group">
                                <label for="passwordre">Password-re</label>
                                <input type="password" name="passwordre" class="form-control" placeholder="Ponovo unesite Password" required>
                            </div>
                                <button type="submit" class="btn btn-primary mt-3">Prosledi</button>
                        </form>
                        </p>
                    </div>
                    <div class="card-footer">
                        <?php
                        if (isset($_REQUEST["error"])) {
                            if ($_REQUEST["error"] == 1) {
                                echo '<div class = "alert alert-danger" role="alert">';
                                echo 'Sifre se ne poklapaju!</div>';
                            } else if ($_REQUEST["error"] == 2) {
                                echo '<div class = "alert alert-danger" role="alert">';
                                echo 'Vec postoji nalog sa ovom e-mail adresom!</div>';
                            }
                        } 
                        ?>
                    </div>
                </div>
            </div>

        </div>
        

    
</body>
</html>