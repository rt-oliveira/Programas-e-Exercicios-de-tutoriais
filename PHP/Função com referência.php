<html>
  <head>
    <title>Chamada por referência</title>
  </head>
  <body>
    <?php
      function troca(&$x, &$y){
        $t=$x;
        $x=$y;
        $y=$t;
      }
      $a=10; $b=20;
      echo "Antes da troca A=$a, B=$b<br>";
      troca($a, $b);
      echo "Depois da troca A=$a, B=$b<br>";
    ?>
  </body>
</html>