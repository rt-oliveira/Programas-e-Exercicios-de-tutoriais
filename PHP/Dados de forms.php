﻿<html>
	<head>
		<title>Página teste</title>
	</head>
	<body>
		<?php
			if (isset($_REQUEST['submit'])) {
				echo 'Welcome, ' . $_REQUEST['name'].'<br>';
				echo 'You are ' . $_REQUEST['age'].' years old<br>';
				
				exit();
			}
		?>
		<form action="<?php $_PHP_SELF ?>" method="POST">
			Name: <input type="text" name="name">
			Age: <input type="text" name="age">
			<input type="submit" name="submit">
		</form>
	</body>
</html>