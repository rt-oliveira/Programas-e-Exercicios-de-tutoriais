<?php
  /* Declaração de tipo escalar:

  Um novo recurso que permite declarar os tipos de dados de parâmetros de funções e de retornos de funções.
*/
	declare(strict_types = 1);
	echo "Declaração de tipo escalar<br>";
	function media(int $x, int $y): int {
		$valor = ($x+$y)/2/;
		return $valor;
	}
	$media = media(10,20);
	echo "Média=$media";
?>