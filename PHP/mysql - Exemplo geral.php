<?php

$servidor	= 'localhost';
$usuario	= 'root';
$senha		= 'usbw';
$conn			= mysql_connect($servidor, $usuario, $senha);

if (!$conn){
	die('Não consegui conectar: ' . mysql_error());
}
echo 'Conectado com sucesso.<br>';

$sql			= 'CREATE DATABASE testdb';
$ret			= mysql_query($sql, $conn);
if(!$ret){
	die('Não consegui criar BD: ' . mysql_error());
}
echo 'Banco testdb criado<br>';
$sql			= "CREATE TABLE employee(".
						"emp_id INT NOT NULL AUTO_INCREMENT,".
						"emp_name VARCHAR(20) NOT NULL,".
						"emp_address VARCHAR(20) NOT NULL,".
						"emp_salary INT NOT NULL,".
						"primary key (emp_id))";
mysql_select_db('testdb');
$ret			= mysql_query($sql, $conn);
if(!$ret){
	die('Não consegui criar tabela: ' . mysql_error());
}
echo 'Tabela criada com sucesso.<br>';

$sql			= "INSERT INTO employee (emp_name, emp_address, emp_salary) VALUES ('Rajiv', 'Nanded', 10000)";
mysql_select_db('testdb');
$ret			= mysql_query($sql, $conn);

if(!$ret){
	die('Não consegui criar dado: '. mysql_error());
}
echo 'Dados criados com sucesso.<br>';

mysql_close($conn);
?>