var net=require("net");

/* O método 'connect' tentará fazer uma conexão
	com o servidor que está no endereço dado em 'host',
	na porta dado em 'port'.
	
	Caso a conexão seja feita, a função callback implementada
	será executada.
*/
var cliente=net.connect({
	port: 12340,
	host: "localhost"
	}, function(){
		console.log("Conexão estabelecida");
	});
