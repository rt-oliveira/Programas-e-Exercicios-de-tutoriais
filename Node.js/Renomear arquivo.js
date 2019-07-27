var fs=require("fs");

var caminhoAntigo="test.txt";
var caminhoNovo="test-novo.txt";

// Tal processo de renomear também feito de maneira assíncrona.
fs.rename(caminhoAntigo,caminhoNovo,function(erro){
	if(erro)
  	console.error("Erro ao renomear: "+erro.message);
  else
  	console.log("Arquivo renomeado com sucesso.");
});