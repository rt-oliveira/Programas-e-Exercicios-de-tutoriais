// "Importa" o m�dulo fs
var fs=require('fs');
console.log("Programa iniciado");
/* Este comando faz a leitura do arquivo,
	por�m o programa fica bloqueado at�
	o arquivo terminar de ser lido.
*/
var data=fs.readFileSync("test.txt");
console.log(data.toString());
console.log("Programa terminado");