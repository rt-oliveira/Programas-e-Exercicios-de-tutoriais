<?php

$con = mysqli_connect('localhost', 'root', 'usbw', 'testdb');
if (mysqli_connect_errno()){
	echo('Falha ao conectar: ' . mysqli_connect_error());
	exit();
} else 
	echo 'Conexão com sucesso.<br>';

	$sql = 'SELECT * FROM employee';
	$result	= mysqli_query($con, $sql);
	$rowcount = mysqli_num_rows($result);
	
	for ($i=0;$i<$rowcount;$i++){
		$linha = mysqli_fetch_row($result);
		echo 'emp_id -> ' . $linha[0] . '<br>';
		echo 'emp_name -> ' . $linha[1] . '<br>';
		echo 'emp_address -> ' . $linha[2] . '<br>';
		echo 'emp_salary -> ' . $linha[3] . '<br>';
	}
	mysqli_free_result($result);
	mysqli_close($con);

?>