var evento=require("events")
var EventEmitter=evento.EventEmitter;
// Cria um objeto emissor de eventos
var emissorEvento=new evento.EventEmitter();

/* Está fazendo a associação entre um evento 
	e uma função callback que deve ser executada
	quando acontece tal tipo de evento.
*/
emissorEvento.on("meuEvento",function(){
	console.log("Tarefa 1");
});

/*	Este é um outro listener para o mesmo tipo de evento.
	Pode haver mais de um listener para o mesmo evento,
	ambas as funções callback serão executadas quando for
	emitido um evento do tipo
*/
emissorEvento.on("meuEvento",function(){
	console.log("Tarefa 2");
});

// Está emitindo um evento do tipo "adicionarUsuario"
emissorEvento.emit("meuEvento");

// Mostra a quantidade de listeners associados a um determinado evento
console.log(EventEmitter.listenerCount(emissorEvento,"meuEvento"));