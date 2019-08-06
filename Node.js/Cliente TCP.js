var net=require("net");

/* O m�todo 'connect' tentar� fazer uma conex�o
	com o servidor que est� no endere�o dado em 'host',
	na porta dado em 'port'.
	
	Caso a conex�o seja feita, a fun��o callback implementada
	ser� executada.
*/
var cliente=net.connect({
	port: 12340,
	host: "localhost"
	}, function(){
		console.log("Conex�o estabelecida");
	});
