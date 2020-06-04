<?php

$con = mysqli_connect('localhost', 'root', 'root', 'unityaccess');

//check that connection happened
if (mysqli_connect_error())
{
    echo "1: Connection failed"; //error code #1 = connection failed
    exit();
}

$rotation = $_POST["rotation"];
$movement = $_POST["movement"];
$shoot = $_POST["shoot"];

//add user to the table

$insertuserquery = "INSERT INTO vitesseplayer (rotation, movement, shoot) VALUES ('" . $rotation . "','" . $movement. "', '" . $shoot . "');";
mysqli_query($con, $insertuserquery) or die("4: Insert player query failed"); //error code #4 - insert query failed

echo("0 test");
?>"
