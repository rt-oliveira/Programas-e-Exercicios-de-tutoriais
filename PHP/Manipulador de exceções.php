<?php
	function manipExcecao($exc){
		echo "Excepção: ", $exc->getMessage(), "\n";
	}

	set_exception_handler("manipExcecao");

	print "Primeiro número: ";
	fscanf(STDIN, "%d", $x);
	
	print "Segundo número: ";
	fscanf(STDIN, "%d", $y);
	
	if ($y==0)
		throw new Exception("Divisão por zero");
	$z = $x / $y;
	print "result = $z";
?>