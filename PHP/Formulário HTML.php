<html>
	<head>
		<title>Página teste</title>
	</head>
	<body>
		<?php
			if (isset($_POST['submit'])) {
				echo 'Welcome, ' . $_POST['name'].'<br>';
				echo 'Gender ' . $_POST['Gender'].'<br>';
				echo 'R/O '.$_POST['city'].'<br>';
				echo 'Address '.$_POST['addr'].'<br>';
				echo 'PINCODE '.$_POST['pin'].'<br>';
				
				exit();
			}
		?>
		<form action="<?php $_PHP_SELF ?>" method="POST">
			<label for="name">Name</label><br>
			<input type="text" name="name"/><br>
			<label for="Gender">Gender</label><br>
			<input type="Radio" name="Gender" value="Male" checked>Male
			<input type="Radio" name="Gender" value="Female">Female<br>
			<label for="city">City<label><br>
			<input type="text" name="city"><br>
			<label for="addr">addr</label><br>
			<textarea name="addr"></textarea><br>
			<label for="PIN">PINCODE</label><br>
			<input type="text" name="pin"><br>
			<input type="submit" name="submit">
		</form>
	</body>
</html>