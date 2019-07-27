var fs=require("fs");

/*Caso, no diret�rio deste arquivo, exista um 'test.exe',
	o conte�do do arquivo ser� impresso.

  Caso contr�rio, ele lan�ar� um erro, que ser� visto,
  e a� a fun��o callback associada ser� executada
  (veja o comando abaixo).
*/
fs.readFile("test.txt","utf8",function(erro,dados){
	if(erro)
  	throw erro;
  console.log(dados);
});

/* O objeto 'process' tem um m�todo chamado 'on',
	 que ser� o respons�vel por observar por exce��es de um
   tipo dado como par�metro.

   Caso aquela exce��o aconte�a, a fun��o callback declarada
   (e associada) �quela exce��o ser� executada.
*/
process.on("uncaughtException",function(erro){
	console.log("Ocorreu uma exce��o");
});