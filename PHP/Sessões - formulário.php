<?php
	if (isset($_POST['submit'])){
		session_start();
		$_SESSION['user']=$_POST['name'];
		echo 'Sessão variable set';
		echo "<a href='checksession.php'><b>read session var</b></a>";
		exit();
	}
?>
<html>
	<head>
		<title>Página teste</title>
	</head>
	<body>
	<form action="<?PHP $_PHP_SELF ?>" method="POST">
		Nome: <input type="text" name="name"/>
		Idade: <input type="text" name="age"/>
		<input type="submit" name="submit"/>
		</form>
	</body>
</html>