<html>
	<head>
		<title>Página teste</title>
	</head>
	<body>
		<?php
			if (isset($_COOKIE['name']))
				echo 'Nome: ' . $_COOKIE['name'] . '<br>';
			else
				echo 'Nome não config';
			
			if (isset($_COOKIE['age']))
				echo 'Idade: ' . $_COOKIE['age'] . '<br>';
			else
				echo 'Idade não config';
		?>
	</body>
</html>