<?php
	$obj = new class (10){
		private $x;
		
		function __construct($x){
			$this->x = $x;
		}
		
		function add($y){
			return $this->x + $y;
		}
		
		function sub($y){
			return $this->x - $y;
		}
	};
	
	$resultado = $obj->add(20);
	echo "Adição=$resultado<br>";
	$resultado = $obj->sub(5);
	echo "Subtração=$resultado<br>";
?>