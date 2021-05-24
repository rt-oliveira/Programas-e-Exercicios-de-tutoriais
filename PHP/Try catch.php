<?php
	print "Primeiro número: ";
	fscanf(STDIN, "%d", $x);
	
	print "Segundo número: ";
	fscanf(STDIN, "%d", $y);
	
	try {
		if ($y==0)
			throw new Exception("Divisão por zero");
		$z = $x / $y;
		print "result = $z";
	} catch (Exception $e){
		print $e -> getMessage();
	}
?>