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

/* Esse método fará com que o servidor seja ativado
	nesta determinada porta, escutando requisições.
*/
server.listen(12340);

