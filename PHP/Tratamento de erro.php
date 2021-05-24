<?php
	error_reporting(E_ERROR);
	
	function handleError($numErr, $descErr){
		echo "Erro nº: [$numErr] $descErr\n";
		echo "Terminando script PHP.";
		die();
	}
	
	set_error_handler("handleError");
	
	$f = fopen("naoPresente.txt","r");
	echo "Arquivo aberto.";
	$f.close();
?>