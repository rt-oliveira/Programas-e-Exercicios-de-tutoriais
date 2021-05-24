<?php
	
	echo 'Upload: ' . $_FILES["uploadfile"]["name"] . '<br>';
	echo 'Type: ' . $_FILES["uploadfile"]["type"] . '<br>';
	echo 'Size: ' . ($_FILES["uploadfile"]["size"]/1024) . '<br>';
	echo 'Stored in: ' . $_FILES["uploadfile"]["tmp_name"] . '<br>';
	
	if (file_exists($_FILES["uploadfile"]["name"]))
		echo 'Arquivo já existe.';
	else {
		move_uploaded_file($_FILES["uploadfile"]["tmp_name"],$_FILES["uploadfile"]["name"]);
		echo 'Arquivo movido';
	}
?>