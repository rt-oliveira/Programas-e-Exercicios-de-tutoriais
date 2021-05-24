<?php
	$nomeArq = 'arqteste.txt';
	$file = fopen($nomeArq, 'w');
	
	if ($file == false){
		echo 'Erro ao abrir novo arquivo';
		exit();
	}
	
	$str = <<<teste
	Esta é uma string teste\n
Que estou quebrando em algumas linhas\n
Que bonito!!!
teste;
	
	fwrite($file, $str);
	fclose($file);
	echo 'Arquivo criado';
?>