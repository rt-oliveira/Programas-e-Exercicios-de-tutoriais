var fs=require("fs");
var caminho="test.txt";

fs.exists(caminho,function(existe){
	if(existe)
  	console.log(caminho+" existe");
  else
  	console.log(caminho+" não existe");
});