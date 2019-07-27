var fs=require("fs");
var caminho=__dirname+"/meuDiretório";

// Método que irá criar um diretório
fs.mkdir(caminho,function(erro){
	if(erro)
  	console.error("Erro no mkdir: "+erro.message);
});