<?php
	echo "<p>Operador de coalescência no PHP 7</p>";
	$usuario = $_GET['user'] ?? 'não passou';
	echo "Nome de usuário $usuario<br>";
	echo "<p>Resultado do operador ternário</p>";
	$usuario = isset($_GET['user']) ? $_GET['user'] : 'não passou';
	print("Usuário " . $usuario);
	print("<br>");
?>