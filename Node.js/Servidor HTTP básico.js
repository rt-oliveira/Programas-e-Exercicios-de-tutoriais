// "Importa" o módulo http
var http = require('http');

// Cria o servidor HTTP
var server = http.createServer(function(req,res){
	res.writeHead(200,{"Content-Type": "text/plain"});
	res.end("Welcome to my first Node.js server...");
});

// Passa a escutar requisições na porta 1234
server.listen(1234,function(){
	console.log("Server iniciado...");
});