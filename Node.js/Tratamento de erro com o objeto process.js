var fs=require("fs");

/*Caso, no diretório deste arquivo, exista um 'test.exe',
	o conteúdo do arquivo será impresso.

  Caso contrário, ele lançará um erro, que será visto,
  e aí a função callback associada será executada
  (veja o comando abaixo).
*/
fs.readFile("test.txt","utf8",function(erro,dados){
	if(erro)
  	throw erro;
  console.log(dados);
});

/* O objeto 'process' tem um método chamado 'on',
	 que será o responsável por observar por exceções de um
   tipo dado como parâmetro.

   Caso aquela exceção aconteça, a função callback declarada
   (e associada) àquela exceção será executada.
*/
process.on("uncaughtException",function(erro){
	console.log("Ocorreu uma exceção");
});