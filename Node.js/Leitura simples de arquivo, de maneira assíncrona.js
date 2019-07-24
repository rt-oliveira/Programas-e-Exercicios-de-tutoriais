// "Importa" o m�dulo fs
var fs=require('fs');
console.log("Programa iniciado");
/* Este comando faz a leitura do arquivo de maneira ass�ncrona.
	Enquanto � lido o arquivo, o Node.js continua sua execu��o.
	Quando terminar a leitura do arquivo, a fun��o callback � 
	executada.
*/
fs.readFile("test.txt",function(erro,dados){
	/* Esta fun��o ser� executada quando o arquivo terminar
		de ser lido. */
	if(erro)
		console.error(erro);
	console.log(dados.toString());
});
/* Por estar tudo sendo feito de maneira ass�ncrona,
	esta impress�o ser� feita antes da fun��o callback,
	definida anteriormente.*/
console.log("Programa terminado");