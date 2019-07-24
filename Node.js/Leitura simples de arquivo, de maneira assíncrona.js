// "Importa" o módulo fs
var fs=require('fs');
console.log("Programa iniciado");
/* Este comando faz a leitura do arquivo de maneira assíncrona.
	Enquanto é lido o arquivo, o Node.js continua sua execução.
	Quando terminar a leitura do arquivo, a função callback é 
	executada.
*/
fs.readFile("test.txt",function(erro,dados){
	/* Esta função será executada quando o arquivo terminar
		de ser lido. */
	if(erro)
		console.error(erro);
	console.log(dados.toString());
});
/* Por estar tudo sendo feito de maneira assíncrona,
	esta impressão será feita antes da função callback,
	definida anteriormente.*/
console.log("Programa terminado");