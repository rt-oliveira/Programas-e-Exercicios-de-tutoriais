<?php

	if (isset($_POST['submit'])){
		$name=$_POST['name'];
		$age=$_POST['age'];
		setcookie('name', $name);
		setcookie('age', $age, time()+3600, "/", "", 0);
		echo 'Cookies configurados.';
		echo '<a href="aula31-getcookie.php">Clique aqui para ver</a>';
	}
?>