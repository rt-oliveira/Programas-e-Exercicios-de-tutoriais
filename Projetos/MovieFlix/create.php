<?php

	function createRecord(){

		$servername = 'localhost';
		$username = 'root';
		$password = 'usbw';
		$database = 'movieflix_database';

		$connection = mysqli_connect($servername, $username, $password, $database);

		if (!$connection){
			die('Connection unsuccessful :' . mysqli_connect_error());
		}

		$movieTitle = $_POST['create-title'];
		$movieGenre = $_POST['create-genre'];
		$movieDirector = $_POST['create-director'];

		$sql = "INSERT INTO movieflix_table (title, genre, director) VALUES ('$movieTitle','$movieGenre','$movieDirector')";
		if (mysqli_query($connection, $sql)){
			echo '';
		}
		else {
			echo 'Error: ' . $sql . mysqli_error($connection);
		}

		mysqli_close($connection);

		header('location: index.php');
	}

	if (isset($_POST['create-button']))
		createRecord();
?>