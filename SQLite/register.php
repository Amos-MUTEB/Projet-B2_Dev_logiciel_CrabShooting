<?php

    $con = mysqli_connect('localhost', 'root', 'root', 'unityaccess');

    //check that connection happened
    if (mysqli_connect_error())
    {
        echo "1: Connection failed"; //error code #1 = connection failed
        exit();
    }

    $username = $_POST["name"];
    $password = $_POST["password"];

    //check if name exists
    $namecheckquery = "SELECT name FROM player WHERE name='" . $username . "';";

    $namecheck = mysqli_query($con, $namecheckquery) or die("2: Name check query failed"); //error code #2 - name check failed

    if (mysqli_num_rows($namecheck) > 0)
    {
        echo "3: Name already exists"; //error code #3 - name exists cannot register
        exit();
    } 

    //add user to the table
    $salt = "\$5\$rounds=5000\$" . "steamsdhams" . $username . "\$";
    $hash = crypt($password,$salt);
    $insertuserquery = "INSERT INTO player (name, hash, salt) VALUES ('" . $username . "','" . $hash . "', '" . $salt . "');";
    mysqli_query($con, $insertuserquery) or die("4: Insert player query failed"); //error code #4 - insert query failed

    echo("0");
?>