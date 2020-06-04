<?php
$con = mysqli_connect('localhost', 'root', 'root', 'unityaccess');

//check that connection happened
if (mysqli_connect_error())
{
    echo "1: Connection failed"; //error code #1 = connection failed
    exit();
}

$left = $_POST["leftp"];
$right = $_POST["rightp"];
$forward = $_POST["forwardp"];
$backward = $_POST["backwardp"];

//add user to the table

$insertuserquery = "INSERT INTO directionplayer (leftp, rightp, forwardp, backwardp) VALUES ('" . $left . "','" . $right. "', '" . $forward . "', '" . $backward . "');";
mysqli_query($con, $insertuserquery) or die("4: Insert player query failed"); //error code #4 - insert query failed

echo("0");
?>