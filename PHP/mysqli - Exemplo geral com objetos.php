<?php
$servidor = 'localhost';
$usuario = 'root';
$senha = 'usbw';

$conn = new mysqli($servidor, $usuario, $senha);

if($conn->connect_error){
	die("Erro . " . $conn->connect_error);
}
echo 'Conectado com sucesso';
$sql = "CREATE DATABASE testdb";
if ($conn->query($sql) === true)
	echo 'Banco criado.';
else
	echo 'Erro ao criar banco: ' . $conn->error;

$conn->select_db('testdb');
$sql            = "CREATE TABLE employee(".
                         "emp_id INT NOT NULL AUTO_INCREMENT,".
                         "emp_name VARCHAR(20) NOT NULL,".
                         "emp_address VARCHAR(20) NOT NULL,".
                         "emp_salary INT NOT NULL,".
                         "primary key (emp_id))";
if ($conn->query($sql) === true)
	echo 'Tabela criada com sucesso';
else
	echo 'Erro ao criar tabela: ' . $conn->error;

$sql			= "INSERT INTO employee (emp_name, emp_address, emp_salary) VALUES ('Rajiv', 'Nanded', 10000)";
if($conn->query($sql) === true)
	echo 'Registro posto com sucesso.';
else
	echo 'Erro: ' . $conn->error . '<br>';

$conn->close();
?>