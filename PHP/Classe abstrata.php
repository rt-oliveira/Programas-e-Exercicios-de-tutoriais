<?php
	abstract class shape{
		abstract function area();
	}
	class retangulo extends shape{
		private $altura, $base;
		public function __construct($altura, $base){
			$this->altura = $altura;
			$this->base	= $base;
		}
		public function area(){
			return $this->altura * $this->base;
		}
	}
	class circulo extends shape{
		private $raio;
		public function __construct($raio){
			$this->raio = $raio;
		}
		public function area(){
			return pow($this->raio, 2)*3.142;
		}
	}
	
	$r1 = new retangulo(10,20);
	$area = $r1->area();
	echo "Área do retângulo = $area<br><br>";

	$c1 = new circulo(10);
	$area = $c1->area();
	echo "Área do círculo = $area<br><br>";
?>