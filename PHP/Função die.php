<?php
  if (!file_exists("test.txt")){
    die("Arquivo não encontrado");
  } else {
    $file = fopen("text.txt", "r");
    print "Arquivo aberto com sucesso.";
  }
  fclose($file);
?>