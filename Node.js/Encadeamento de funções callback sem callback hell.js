var fs=require('fs');
var arq='test.txt';

function LerArquivo(erro,dados){
	if(erro)
		throw erro;
	console.log(dados);
}

function Status(erro,tipo){
	if(erro)
		throw erro;
	if(tipo.isFile())
		fs.readFile(arq,'utf8',LerArquivo);
}

function ArquivoExiste(existe){
	if(existe)
		fs.stat(arq,Status);
}

fs.exists(arq,ArquivoExiste);