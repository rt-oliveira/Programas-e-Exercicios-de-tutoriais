var fs=require("fs");
var caminho="test.txt";
var dados="Dados s�o escritos no arquivo por um programa Node.js";

// A fun��o callback dada como par�metro s� nos dir� se tudo ocorreu bem ou n�o.
fs.writeFile(caminho,dados,function(erro){
	if(erro)
  	console.error("erro de escrita: "+erro.message);
  else
  	console.log("Escrita com sucesso "+caminho);
});