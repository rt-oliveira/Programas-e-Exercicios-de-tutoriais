<?php

function deleteRecord(){

  $servername = 'localhost';
  $username = 'root';
  $password = 'usbw';
  $database = 'movieflix_database';

  $connection = mysqli_connect($servername, $username, $password, $database);

  if (!$connection){
    die('Connection unsuccessful :' . mysqli_connect_error());
  } else {
    echo 'Connection success!';
  }

  $id = $_POST['delete-ID'];

  $sql = "DELETE FROM movieflix_table WHERE id = '$id'";
  $deleteQuery = mysqli_query($connection, $sql);

  if(!$deleteQuery){
    echo 'Error: '.$sql.mysqli_error($connection);
  }

  mysqli_close($connection);

  header('location: index.php');
}

if (isset($_POST['submit-delete'])){
  deleteRecord();
}

?>