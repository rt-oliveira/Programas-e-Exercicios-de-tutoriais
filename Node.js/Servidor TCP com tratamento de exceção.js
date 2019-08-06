// "Importou" o módulo 'net'
var net=require("net");

/* O método 'createServer' criará um servidor
	TCP, sendo que ele ainda não está ativado,
	apenas foi definido.
*/
var server=net.createServer(function(socket){
	// Socket.end encerra a comunicação TCP.
	socket.end("Olá e tchau!\n");
});

/* Esse método define uma função callback que será
	executada caso dê um erro do tipo a porta definida
	para este servidor já estiver em uso.
*/
server.on("error",function(erro){
	if(erro.code==="EADDRINUSE")
		console.error("A port está em uso")
});

/* Esse método fará com que o servidor seja ativado
	nesta determinada porta, escutando requisições.
*/
server.listen(12340);

