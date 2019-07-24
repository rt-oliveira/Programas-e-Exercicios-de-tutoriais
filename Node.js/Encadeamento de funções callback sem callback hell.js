var fs=require('fs');
var arq='test.txt';

// Caso seja um arquivo, e exista, ler�-o e mostrar� no console.
function LerArquivo(erro,dados){
	if(erro)
		throw erro;
	console.log(dados);
}

// Fun��o callback que testa se � uma arquivo mesmo.
function Status(erro,tipo){
	if(erro)
		throw erro;
	if(tipo.isFile())
		fs.readFile(arq,'utf8',LerArquivo);
}

// Fun��o callback que testa se existe o arquivo.
function ArquivoExiste(existe){
	if(existe)
		fs.stat(arq,Status);
}

fs.exists(arq,ArquivoExiste);

/* Separando as fun��es callback, e programando-as
	uma de cada vez, sem haver encadeamento, o c�digo
	fica mais f�cil de ser entendido.*/