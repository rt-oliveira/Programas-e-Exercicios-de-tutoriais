var fs=require("fs");
var caminho=__dirname+"/meuDiret�rio";

// M�todo que ir� criar um diret�rio
fs.mkdir(caminho,function(erro){
	if(erro)
  	console.error("Erro no mkdir: "+erro.message);
});