<!DOCTYPE html>
<html>
	<head>
		<title>Movieflix CRUD App</title>
		<link rel="preconnect" href="https://fonts.gstatic.com">
		<link href="https://fonts.googleapis.com/css2?family=Roboto&display=swap" rel="stylesheet">
		<style type="text/css">
			body {
				font-family: 'Roboto', sans-serif;
			}

			#create-form, #update-form, #delete-form {
				display: none;
			}

			.main-div {
				width: 80vw;
				margin: 0 auto;
			}

			h2 {
				text-align: center;
			}

			table {
				margin: 15px auto;
				width: 50vw;
				text-align: center;
			}

			table tr td {
				padding: 12px;
			}

			.content-wrapper {
				width: 100%;
				margin: 0 auto;
				text-align: center;
			}

			#create-button, #update-button, #delete-button{
				width: 140px;
				height: 37.5px;
				background-color: blue;
				color: #FFFFAA;
				border-radius: 4px;
				border: 1.5px solid black;
				letter-spacing: 1.5px;
				cursor: pointer;
			}

			.small-button {
				width: 76px;
				height: 30px;
				background-color: blue;
				color: #FFFFAA;
				border-radius: 2px;
				border: none;
				cursor: pointer;
			}

			input[type="text"]{
				margin: 6px;
				width: 260px;
				height: 32px;
				padding: 3px;
			}
		</style>
	</head>
	<body>
		<div>
			<?php require_once 'create.php'; ?>
			<div class="main-div">
				<h2>Movieflix CRUD</h2>
				<?php
					$servername = 'localhost';
					$username = 'root';
					$password = 'usbw';
					$database = 'movieflix_database';
			
					$connection = mysqli_connect($servername, $username, $password, $database);
			
					if (!$connection){
						die('Connection unsuccessful :' . mysqli_connect_error());
					}

					$sql = "SELECT * FROM movieflix_table";
					$result = mysqli_query($connection, $sql);
					$rowCount = mysqli_num_rows($result);

					if ($rowCount > 0){
						echo "
							<table>
								<thead>
									<tr>
										<th>Record ID</th>
										<th>Title</th>
										<th>Genre</th>
										<th>Director</th>
									</tr>
								</thead>
						";
					}
				?>
				<?php
					while ($row = $result->fetch_assoc()): ?>
						<tr>
							<td><?php echo $row['id'] ?></td>
							<td><?php echo $row['title'] ?></td>
							<td><?php echo $row['genre'] ?></td>
							<td><?php echo $row['director'] ?></td>
						</tr>
					<?php endwhile ?>
				</table>
			</div>
			<div class="content-wrapper">
				<button id="create-button">Create Record</button>
				<button id="update-button">Edit Record</button>
				<button id="delete-button">Delete Record</button>

				<form action="create.php" method="POST" id="create-form">
					<input type="text" name="create-title" placeholder="Enter movie title"><br/>
					<input type="text" name="create-genre" placeholder="Enter movie genre"><br/>
					<input type="text" name="create-director" placeholder="Enter movie director"><br/>
					<input type="submit" value="Save" name="create-button" class="small-button">
				</form>

				<form action="update.php" method="POST" id="update-form">
					<input type="text" name="update-ID" placeholder="Enter Record ID"><br/>
					<input type="text" name="update-title" placeholder="Enter movie title"><br/>
					<input type="text" name="update-genre" placeholder="Enter movie genre"><br/>
					<input type="text" name="update-director" placeholder="Enter movie director"><br/>
					<input type="submit" value="Save" name="submit-update" class="small-button">
				</form>

				<form action="delete.php" method="POST" id="delete-form">
					<input type="text" name="delete-ID" placeholder="Enter Record ID"><br/>
					<input type="submit" value="Save" name="submit-delete" class="small-button">
				</form>
			</div>
		</div>

		<script src="script.js"></script>
	</body>
</html>