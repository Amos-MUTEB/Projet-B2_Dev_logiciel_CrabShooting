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
$namecheckquery = "SELECT name, hash, salt, score, life FROM player WHERE name='" . $username . "';";

$namecheck = mysqli_query($con, $namecheckquery) or die("2: Name check query failed"); //error code #2 - name check failed
if (mysqli_num_rows($namecheck) !=1)
{
    echo "5: Either no user with name, or more than one"; //error code #5  - number of names matching !=1
    exit();
}

//get login into from query
$existinginfo = mysqli_fetch_assoc($namecheck);
$salt = $existinginfo["salt"];
$hash = $existinginfo["hash"];

$loginhash = crypt($password, $salt);
if ($hash != $loginhash)
{
    echo "7: Incorrect passwordvbnfe"; //error code #6 - password does not hash to match table
    exit();
}

echo "0\t" . $existinginfo["score"];
?>