var path=require("path");

var nomeArquivo="Nodejs/Programas/programa.js";

// Esse comando extrai a extensão do arquivo, cujo caminho foi dado como parâmetro.
var extensao=path.extname(nomeArquivo);

/* Esse comando extrai o nome do arquivo (com extensão),
	 cujo caminho foi dado como parâmetro.
 */
var arquivo=path.basename(nomeArquivo);

console.log(arquivo);
console.log(extensao);