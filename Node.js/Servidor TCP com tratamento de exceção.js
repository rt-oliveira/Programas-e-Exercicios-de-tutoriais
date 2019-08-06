// "Importou" o m�dulo 'net'
var net=require("net");

/* O m�todo 'createServer' criar� um servidor
	TCP, sendo que ele ainda n�o est� ativado,
	apenas foi definido.
*/
var server=net.createServer(function(socket){
	// Socket.end encerra a comunica��o TCP.
	socket.end("Ol� e tchau!\n");
});

/* Esse m�todo define uma fun��o callback que ser�
	executada caso d� um erro do tipo a porta definida
	para este servidor j� estiver em uso.
*/
server.on("error",function(erro){
	if(erro.code==="EADDRINUSE")
		console.error("A port est� em uso")
});

/* Esse m�todo far� com que o servidor seja ativado
	nesta determinada porta, escutando requisi��es.
*/
server.listen(12340);

