var fs=require("fs");
var caminho="C:\\Windows";

/* Este método tentará ver os conteúdos existentes em uma pasta,
 * e, neste caso, em condição de sucesso, serão mostrados os arquivos/pastas
 * existentes dentro do caminho informado como parâmetro.
 */
fs.readdir(caminho,function(erro,arquivos){
	arquivos.forEach(function(arquivo){
		console.log(arquivo);
	});
});
