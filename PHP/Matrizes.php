<html>
    <body>
        <?php
        	$marks = array(
            	"Ramesh" => array("Física" => 35, "Matemática" => 30, "Química" => 39),
                "Ravi" => array("Física" => 30, "Matemática" => 32, "Química" => 29),
                "Rashmi" => array("Física" => 31, "Matemática" => 22, "Química" => 39)
            );
            
            foreach($marks as $nm=>$subs){
            	echo "Nome: $nm ";
                foreach ($subs as $sub=>$m){
                	echo "$sub: $m ";
                }
                echo '<br>';
            }
        ?>
    </body>
</html>
