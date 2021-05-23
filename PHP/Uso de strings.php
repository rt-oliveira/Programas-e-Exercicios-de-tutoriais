<?php
	$nome = 'TutorialsPoint';
    $string1 = 'bem-vindo $nome';
    $string2 = "bem-vindo $nome"; // Forma de construção de string, que não precisa de concatenação
    echo $string1 . '<br>';
    echo $string2 . "<br>";
    echo "Bem-vindo ao \"Tutorial PHP\" <br>";  // Escape de caracteres
    print "preço = \$25<br>"; // Escape de caracteres
    print 'Olá<br>Como vai você?';
    // Forma alternativa de construção de caracteres, que permite construir string de múltiplas linhas
    // É usado uma espécie de 'token' no início da frase, gera-se a string.
    $var=<<<WELCOME
    Olá<br>
    Bem-vindo ao "$nome".<br>
    Esse é um tutorial em vídeo de PHP
WELCOME;
// E no final usa esse mesmo token, para delimitar o fim da string.
	echo $var;
?>