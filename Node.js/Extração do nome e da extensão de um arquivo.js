var path=require("path");

var nomeArquivo="Nodejs/Programas/programa.js";

// Esse comando extrai a extens�o do arquivo, cujo caminho foi dado como par�metro.
var extensao=path.extname(nomeArquivo);

/* Esse comando extrai o nome do arquivo (com extens�o),
	 cujo caminho foi dado como par�metro.
 */
var arquivo=path.basename(nomeArquivo);

console.log(arquivo);
console.log(extensao);