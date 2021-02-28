<?php

function updateRecord(){

  $servername = 'localhost';
  $username = 'root';
  $password = 'usbw';
  $database = 'movieflix_database';

  $connection = mysqli_connect($servername, $username, $password, $database);

  if (!$connection){
    die('Connection unsuccessful :' . mysqli_connect_error());
  }

  $id = $_POST['update-ID'];
  $movieTitle = $_POST['update-title'];
  $movieGenre = $_POST['update-genre'];
  $movieDirector = $_POST['update-director'];

  $sql = "UPDATE movieflix_table SET title = '$movieTitle', genre = '$movieGenre', director = '$movieDirector' WHERE id = '$id'";
  $updateQuery = mysqli_query($connection, $sql);

  if(!$updateQuery){
    echo 'Error: '.$sql.mysqli_error($connection);
  }

  mysqli_close($connection);

  header('location: index.php');
}

if (isset($_POST['submit-update'])){
  updateRecord();
}

?>