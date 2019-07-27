console.log("Diretório atual de trabalho: "+process.cwd());
try{
	process.chdir("/");
  /* Este comando tentará trocar o diretório atual de trabalho.
  	Caso seja bem-sucedido, o programa, que estará em um diretório, manipulará
    outro diretório, diferente do seu, de início.
  */
}catch(exception){
	console.error("erro no chdir: "+exception.message);
}
console.log("Agora o diretório atual de trabalho é: "+process.cwd());