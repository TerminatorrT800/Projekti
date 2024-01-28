<?php
    $db= 'filmrent';
    $user = "root";
    $password ='';
    $host = 'localhost';

    $conn = new mysqli($host, $user, $password, $db);
    if ($conn->connect_error) {
        die('Error : ('. $conn->connect_errno . ' )' . $conn->connect_error);
    }



?>