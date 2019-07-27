var fs=require("fs");
var caminho=__dirname+"/meuDir";

/* Este método tentará remover a pasta informada como parâmetro.
 * Caso bem sucedido, a pasta será removida, e nada será impresso.
 */
fs.rmdir(caminho,function(erro){
	if(erro)
		console.error("Erro no rmdir: "+erro.message);
});
