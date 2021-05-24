<html>
	<head>
		<title>Página teste</title>
	</head>
	<body>
		<?php
			if (isset($_POST['submit'])) {
				echo 'Welcome, ' . $_POST['name'].'<br>';
				echo 'You are ' . $_POST['age'].' years old<br>';
				
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