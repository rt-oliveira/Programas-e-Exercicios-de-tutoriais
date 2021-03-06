-- Função HEX
-- Pode:
--	- Caso passe um número como argumento, converte o número
--		para a base hexadecimal
--	- Caso passe uma string, converte ela para uma string hexadecimal

-- Nesse primeiro exemplo, está convertendo o número 255 para a sua
-- representação hexadecimal.
SELECT HEX(255);

-- Neste outro exemplo, passa-se uma string hexadecimal. Neste caso, não
-- é preciso invocar a função; ao usá-la no SELECT, o comando converte
-- a string para sua representação string ASCII.
SELECT 0x616263;
-- Observação: string hexadecimais, neste caso, poderão estar em 2 formas:
--		- 0x..., ou
--		- X'...'