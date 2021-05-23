<html>
  <head>
    <title>Função definida pelo usuário com argumento padrão</title>
  </head>
  <body>
    <?php
      function porcentagem($p, $c, $m, $ttl=300){
        echo "p=$p, c=$c, m=$m, ttl=$ttl<br>";
        $percent = ($p+$c+$m)*100/$ttl;
        echo "Porcentagem=$percent<br>";
      }
      porcentagem(50,60,70);
      porcentagem(25,30,35,150);
    ?>
  </body>
</html>