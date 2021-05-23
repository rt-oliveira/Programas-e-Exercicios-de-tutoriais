<?php
  $x="Olá mundo";
  $l=strlen($x);
  echo "Tamanho da string \"$x\" é $l<br>";

  $pos = strpos($x, "mun");
  echo "Posição de \"mun\" em $x é $pos<br>";

  echo str_shuffle($x). "<br>";
  echo strtoupper($x)."<br>";
  print_r(str_split($x));
?>