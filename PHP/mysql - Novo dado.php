<html>
	<head>
		<title>Novo registro no MySQL</title>
	</head>
	<body>
		<?php
			if (isset($_POST['add'])){
				$servidor	= 'localhost';
				$usuario	= 'root';
				$senha		= 'usbw';
				$conn			= mysql_connect($servidor, $usuario, $senha);
				if (!$conn){
					die('Sem conectar: ' . mysql_error());
				}
				$emp_name	= $_POST['emp_name'];
				$emp_address	= $_POST['emp_address'];
				$emp_salary		= $_POST['emp_salary'];
				
				$sql			= "INSERT INTO employee (emp_name, emp_address, emp_salary) VALUES ('$emp_name', '$emp_address', $emp_salary)";
				mysql_select_db('testdb');
				$ret			= mysql_query($sql, $conn);

				if(!$ret){
					die('Não consegui criar dado: '. mysql_error());
				}
				echo 'Dados criados com sucesso.<br>';
				mysql_close($conn);
			}
		?>
	
		<form method="POST" action="<?php $_PHP_SELF ?>">
			<p>Employee name</p>
			<input name="emp_name" type="text">
			
			<p>Employee address</p>
			<input name="emp_address" type="text">
			
			<p>Employee salary</p>
			<input name="emp_salary" type="text">
			
			<input name="add" type="submit" value="Add employee">
		</form>
	</body>
</html>