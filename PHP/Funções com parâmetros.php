<html>
  <head>
    <title>Função definida pelo usuário</title>
  </head>

  <body>
    <?php
      function bemvindo($nm){
        echo "Olá $nm<br>";
        echo "Bem-vindo à biblioteca de tutoriais em vídeo do TutorialsPoint";
      }
      bemvindo("Rafael");

      function area($l, $b){
        $a = $l*$b;
        echo "<p>Area=$a</p>";
      }
      area(10,20);
    ?>
  </body>
</html>