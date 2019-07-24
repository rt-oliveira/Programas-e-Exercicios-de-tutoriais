var fs=require('fs');
var arq='test.txt';

// Caso seja um arquivo, e exista, lerá-o e mostrará no console.
function LerArquivo(erro,dados){
	if(erro)
		throw erro;
	console.log(dados);
}

// Função callback que testa se é uma arquivo mesmo.
function Status(erro,tipo){
	if(erro)
		throw erro;
	if(tipo.isFile())
		fs.readFile(arq,'utf8',LerArquivo);
}

// Função callback que testa se existe o arquivo.
function ArquivoExiste(existe){
	if(existe)
		fs.stat(arq,Status);
}

fs.exists(arq,ArquivoExiste);

/* Separando as funções callback, e programando-as
	uma de cada vez, sem haver encadeamento, o código
	fica mais fácil de ser entendido.*/