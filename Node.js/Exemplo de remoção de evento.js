var evento=require("events")
// Cria um objeto emissor de eventos
var emissorEvento=new evento.EventEmitter();

// Está fazendo uma função callback separadamente, com nome
function handler(){
	console.log("No handler do meuEvento");
}

/* Está fazendo a associação entre um evento 
	e uma função callback que deve ser executada
	quando acontece tal tipo de evento.
*/
emissorEvento.on("meuEvento",handler);

/* Está removendo um listener do evento meuEvento.
	Para fazer isso, é preciso que a função callback tenha um nome.
*/
emissorEvento.removeListener("meuEvento",handler);

/* Nada será feito, pois o listener desse evento foi, anteriormente,
	removido.
*/
emissorEvento.emit("meuEvento");