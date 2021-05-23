<?php
  interface botao{
    public function clicar();
  }

  class MeuBotao implements botao{
    public function clicar(){
      echo "MeuBotao clicado<br>";
    }
  }

  class SeuBotao implements botao{
    public function clicar(){
      echo 'SeuBotao clicado<br>';
    }
  }

  $b1 = new MeuBotao();
  $b1->clicar();

  $b2 = new SeuBotao();
  $b2->clicar();
?>