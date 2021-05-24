<?php
$servidor = 'localhost';
$usuario = 'root';
$senha = 'usbw';

$conn = new mysqli($servidor, $usuario, $senha, "testdb");

if($conn->connect_error){
	die("Erro . " . $conn->connect_error);
}
echo 'Conectado com sucesso';

$sql = "SELECT * FROM employee";
$result = $conn->query($sql);
$numL = $result->num_rows;
$numF = $result->field_count;
echo "<table border='1'>";
echo "<tr>";
for ($i=0;$i<$numF;$i++){
	$teste = $result->fetch_field();
	echo "<td>" . $teste->name . "</td>";
	echo "<td>" . ($result->fetch_field())->name . "</td>";
}
for ($i=0;$i<$numL;$i++){
	$linha = $result->fetch_row();
	echo '<tr>';
	for ($j=0;$j<$numF;$j++)
		echo '<td>' . $linha[$j] . '</td>';
	echo '</tr>';
}
echo '</table>';
$conn->close();