<html>
	<body>
		<table border=1>
			<?php
				foreach($_SERVER as $chave => $valor)
				{
					echo '<tr>';
					echo '<td>' . $chave . '</td>';
					echo '<td>' . $valor . '</td>';
					echo '</tr>';
				}
			?>
		</table>
	</body>
</html>