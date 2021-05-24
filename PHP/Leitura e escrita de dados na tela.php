<?php
  print "Largura:";
  fscanf(STDIN, "%d", $a);
  echo "Profundidade:";
  fscanf(STDIN, "%d", $b);
  $c = $a * $b;
  fprintf(STDOUT, "Área=%d", $c);
?>