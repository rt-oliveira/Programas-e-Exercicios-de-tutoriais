// "Importa" o módulo fs
var fs=require('fs');
console.log("Programa iniciado");
/* Este comando faz a leitura do arquivo,
	porém o programa fica bloqueado até
	o arquivo terminar de ser lido.
*/
var data=fs.readFileSync("test.txt");
console.log(data.toString());
console.log("Programa terminado");