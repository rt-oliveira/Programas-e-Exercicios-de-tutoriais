var fs=require("fs");

var caminhoAntigo="test.txt";
var caminhoNovo="test-novo.txt";

// Tal processo de renomear tamb�m feito de maneira ass�ncrona.
fs.rename(caminhoAntigo,caminhoNovo,function(erro){
	if(erro)
  	console.error("Erro ao renomear: "+erro.message);
  else
  	console.log("Arquivo renomeado com sucesso.");
});