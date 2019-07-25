var evento=require("events")
// Cria um objeto emissor de eventos
var emissorEvento=new evento.EventEmitter();

var uid="nodejs"
var pwd="tutorialspoint"

/* Está fazendo a associação entre um evento 
	e uma função callback que deve ser executada
	quando acontece tal tipo de evento.
*/
emissorEvento.on("adicionarUsuario",function(usuario,senha){
	console.log("Adicionado usuário " + usuario);
});

// Está emitindo um evento do tipo "adicionarUsuario"
emissorEvento.emit("adicionarUsuario",uid,pwd);