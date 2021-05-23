<?php
  class Livro{
    var $preco;
    var $titulo;

    function __construct($par1, $par2){
      $this->titulo = $par1;
      $this->preco = $par2;
    }

    function setPreco($par){
      $this->preco = $par;
    }

    function getPreco(){
      return $this->preco;
    }

    function setTitulo($par){
      $this->titulo = $par;
    }
    
    function getTitulo(){
      return $this->titulo."<br>";
    }

    function getDetalhes(){
      echo "Título: $this->titulo, Preço: $this->preco<br>";
    }
  }

  $fisica = new Livro("Física Ensino Médio", 10);
  $matematica = new Livro("Álgebra", 15);
  $quimica = new Livro("Química avançada", 7);
  $fisica->getDetalhes();
  $quimica->getDetalhes();
  $matematica->getDetalhes();
  echo "<p>Física com preço alterado para 25</p>";
  $fisica->setPreco(25);
  echo "<p>Matemática com título alterado</p>";
  $matematica->setTitulo("Álgebra moderna");
  $fisica->getDetalhes();
  $matematica->getDetalhes();

  $ttl=$fisica->getPreco()+$quimica->getPreco()+$matematica->getPreco();
  echo "Custo total = \$$ttl";
?>