<?php
	
	$servidor	= 'localhost';
	$usuario	= 'root';
	$senha		= 'usbw';
	$con			= mysql_connect($servidor, $usuario, $senha);
	
	mysql_select_db('testdb');
	
	$sql			= "SELECT * FROM employee";
	$result		= mysql_query($sql);
	
	$numFields	= mysql_num_fields($result);
	$numLinhas	= mysql_num_rows($result);
	
	echo "<table border='1'>";
	echo "<tr>";
	for($j=0;$j<$numFields;$j++){
		echo '<td>' . mysql_field_name($result, $j) . '</td>';
	}
	echo '</tr>';
	for ($i=0;$i<$numLinhas;$i++){
		$row	= mysql_fetch_row($result);
		echo '<tr>';
		for($j=0;$j<$numFields;$j++){
			echo '<td>' . $row[$j] . '</td>';
		}
		echo '</tr>';
	}
	echo '</table>';
?>