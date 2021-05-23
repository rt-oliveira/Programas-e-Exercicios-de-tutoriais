<html>
  <head>
    <title>Função definida pelo usuário com argumentos variáveis</title>
  </head>
  <body>
    <?php
      function media(){
        $argumentos = func_get_args();
        print_r($argumentos); echo "<br>";
        $soma = 0;
        $quantidade = func_num_args();
        for ($i=0; $i < func_num_args(); $i++) { 
          $soma += $argumentos[$i];
        }
        $media = $soma/$quantidade;
        echo "Média=$media";
      }
      media(10,20,30,40,50);
    ?>
  </body>
</html>