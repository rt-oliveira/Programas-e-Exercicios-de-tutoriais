<html>
    <body>
        <?php
        	$marks = array("phy" => 50, "che" => 60, "maths" => 70);
            foreach($marks as $sub => $mark){
            	echo "marks in $sub = $mark<br>";
            }
            
            foreach(array_keys($marks) as $k){
            	echo "marks in $k: $marks[$k]<br>";
            }            
        ?>
    </body>
</html>
