var fs=require('fs');
var arq='test.txt';

// H� um encadeamento de fun��es callback.
fs.exists(arq,function(existe){
	/* Essa fun��o callback ser� feita
		ap�s procurar sobre o arquivo.
		Testar� se o arquivo existe*/
	if(existe){
		// Caso exista, confirmar� se � mesmo um arquivo.
		fs.stat(arq,function(erro,tipo){
			if(erro)
				throw erro;
			if(tipo.isFile()){
				// Caso seja mesmo um arquivo, ler�-o.
				fs.readFile(arq,'utf8',function(erro,dados){
					if(erro)
						throw erro;
					// E depois imprimir� o conte�do dele.
					console.log(dados);
				});
			}
		});
	}
});

/* Do jeito que foi programado fica dif�cil de entender,
	pois h� um encadeamento de fun��es callback.
	
	Isso � o chamado "Callback Hell".
	
	Uma solu��o para evitar isso 
	� programar cada fun��o callback separadamente,
	dando um nome a cada uma delas, 
	e depois apenas pass�-las como par�metro.*/