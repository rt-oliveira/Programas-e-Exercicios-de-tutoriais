<?php
  class Estudante{
    protected $nome, $idade, $nota;
    public function __construct()
    {
      $n = func_num_args();
      if ($n === 3){
        $this->nome = func_get_arg(0);
        $this->idade = intval(func_get_arg(1));
        $this->nota = intval(func_get_arg(2));
      }
    }

    public function getDetalhes(){
      echo "Nome: $this->nome, Idade: $this->idade, Nota: $this->nota<br>";
    }
  }

  class Eng extends Estudante{
    private $ramificacao;
    public function __construct()
    {
      $n = func_num_args();
      if ($n === 4){
        parent::__construct(func_get_arg(0), func_get_arg(1), func_get_arg(2));
        $this->ramificacao = func_get_arg(3);
      }
    }

    // Sobrecarga de método
    public function getDetalhes(){
      parent::getDetalhes();
      echo "Ramificação: $this->ramificacao<br>";
    }
  }

  $s1 = new Eng("xyz", 20, 340, "CSE");
  $s1->getDetalhes();
?>