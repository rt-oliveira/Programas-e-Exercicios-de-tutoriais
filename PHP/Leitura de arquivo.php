<?php
	$nomeArq = 'arqteste.txt';
	$file = fopen($nomeArq, 'r');
	
	if ($file == false){
		echo 'Erro ao abrir novo arquivo';
		exit();
	}
	
	while(!feof($file)){
		echo fgets($file);
		//."\n";
	}
	fclose($file);
?>