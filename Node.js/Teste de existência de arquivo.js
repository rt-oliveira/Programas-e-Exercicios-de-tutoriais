var fs=require("fs");
var caminho="test.txt";

// Esse comando testará se um determinado arquivo existe ou não.
fs.exists(caminho,function(existe){
	if(existe)
  		console.log(caminho+" existe");
  	else
  		console.log(caminho+" não existe");
});
