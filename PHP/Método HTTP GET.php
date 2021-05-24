<html>
	<head>
		<title>Página teste</title>
	</head>
	<body>
		<?php
			if (isset($_GET['submit'])) {
				echo 'Welcome, ' . $_GET['name'].'<br>';
				echo 'You are ' . $_GET['age'].' years old<br>';
				
				exit();
			}
		?>
		<form action="<?php $_PHP_SELF ?>" method="GET">
			Name: <input type="text" name="name">
			Age: <input type="text" name="age">
			<input type="submit" name="submit">
		</form>
	</body>
</html>