var evento=require("events")
// Cria um objeto emissor de eventos
var emissorEvento=new evento.EventEmitter();

/* Está fazendo a associação entre um evento 
	e uma função callback que deve ser executada
	quando acontece tal tipo de evento.
*/
emissorEvento.on("adicionarUsuario",function(){
	console.log("Evento adicionarUsuario disparado");
});

// Está emitindo um evento do tipo "adicionarUsuario"
emissorEvento.emit("adicionarUsuario");