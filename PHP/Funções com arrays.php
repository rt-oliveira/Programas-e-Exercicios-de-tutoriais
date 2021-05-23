<html>
    <body>
        <?php
        	$arr1 = array_fill(0,5,5);
            foreach($arr1 as $a){
            	echo $a."<br>";
            }
            
            $arr = array(1=>"one",2=>"two",3=>"three");
            foreach($arr as $k=>$v){
            	echo "$k => $v<br>";
            }
            print "Keys: ";
            print_r(array_keys($arr)); echo "<br>";
            print "Values: ";
            print_r(array_values($arr)); echo "<br>";
            print "Flipped array: <br>";
            $newarr = array_flip($arr);
            foreach($newvar as $k=>$v){
            	echo "$k => $v<br>";
            }
            $arr1 = array(10,20,30,40,50);
            print_r($arr1); echo "<br>";
            print "popped: ";
            array_pop($arr1);
            print_r($arr1); echo '<br>';
            echo 'pushed 25:';
            array_push($arr1, 25);
            print_r($arr1); echo '<br>';
            $arr1 = array_reverse($arr1);
            print "Reverse of array: "; print_r($arr1); echo '<br>';
            sort($arr1);
            print 'Sorted array: '; print_r($arr1); print '<br>';
            print 'array length: '; print count($arr1);
        ?>
    </body>
</html>
