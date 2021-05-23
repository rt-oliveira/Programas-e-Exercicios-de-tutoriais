<html>
    <body>
        <?php
        	// Primeiro método
        	$numeros = array(1, 2, 3, 4, 5);
            echo 'Laço foreach<br>';
            foreach($numeros as $val){
            	echo "Valor é $val <br/>";
            }
            
            echo 'Laço for<br>';
            for($i=0;$i<count($numeros);$i++){
            	echo "Valor é $numeros[i]<br>";
            }
            echo "<br><br>";
            
            // Segundo método
            $numbers[0] = "one";
            $numbers[1] = "two";
            $numbers[2] = "three";
            $numbers[3] = "four";
            $numbers[4] = "five";
            foreach($numbers as $value){
            	echo "Valor é $value<br/>";
            }
        ?>
    </body>
</html>
