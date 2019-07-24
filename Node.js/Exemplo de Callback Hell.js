var fs=require('fs');
var arq='test.txt';

// Há um encadeamento de funções callback.
fs.exists(arq,function(existe){
	/* Essa função callback será feita
		após procurar sobre o arquivo.
		Testará se o arquivo existe*/
	if(existe){
		// Caso exista, confirmará se é mesmo um arquivo.
		fs.stat(arq,function(erro,tipo){
			if(erro)
				throw erro;
			if(tipo.isFile()){
				// Caso seja mesmo um arquivo, lerá-o.
				fs.readFile(arq,'utf8',function(erro,dados){
					if(erro)
						throw erro;
					// E depois imprimirá o conteúdo dele.
					console.log(dados);
				});
			}
		});
	}
});

/* Do jeito que foi programado fica difícil de entender,
	pois há um encadeamento de funções callback.
	
	Isso é o chamado "Callback Hell".
	
	Uma solução para evitar isso 
	é programar cada função callback separadamente,
	dando um nome a cada uma delas, 
	e depois apenas passá-las como parâmetro.*/