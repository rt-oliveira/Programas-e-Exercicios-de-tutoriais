<html>
    <body>
        <?php
            $arr = array('C', 'C++', 'Java', 'PHP', 'JavaScript');
            foreach ($arr as $val){
            	echo $val." ";
            }
            echo "<br><br>";
            
            $arr = array("name" => "Raju", "age" => 25, "marks" => 70);
            foreach ($arr as $key=>$val){
            	echo "$key => $val <br> ";
            }
        ?>
    </body>
</html>