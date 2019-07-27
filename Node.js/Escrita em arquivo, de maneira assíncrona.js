var fs=require("fs");
var caminho="test.txt";
var dados="Dados são escritos no arquivo por um programa Node.js";

// A função callback dada como parâmetro só nos dirá se tudo ocorreu bem ou não.
fs.writeFile(caminho,dados,function(erro){
	if(erro)
  	console.error("erro de escrita: "+erro.message);
  else
  	console.log("Escrita com sucesso "+caminho);
});