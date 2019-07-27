console.log("Diret�rio atual de trabalho: "+process.cwd());
try{
	process.chdir("/");
  /* Este comando tentar� trocar o diret�rio atual de trabalho.
  	Caso seja bem-sucedido, o programa, que estar� em um diret�rio, manipular�
    outro diret�rio, diferente do seu, de in�cio.
  */
}catch(exception){
	console.error("erro no chdir: "+exception.message);
}
console.log("Agora o diret�rio atual de trabalho �: "+process.cwd());