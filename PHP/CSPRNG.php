<?php
	$bytes = random_bytes(5);
	echo $bytes . "<br>";
	print(bin2hex($bytes)) . "<br>";
	$int = random_int(100,999);
	echo "Inteiro aleatório = $int";
?>