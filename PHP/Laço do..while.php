<html>
    <body>
        <?php
            $i = 0;
            do {
                $i++;
                echo "Number:$i<br/>";
            } while ($i < 10);
            echo "<br><br>";

            $x=0;
            do{
                $x=rand(1,10);
                echo "Number: $x<br/>";
            }while($x!=5);
            ?>
    </body>
</html>