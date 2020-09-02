-- Função STR
-- Ela converte dados numéricos em cadeias de caracteres (strings).
-- São passados 3 parâmetros:
--  - (Obrigatório) um número N, que é o número a ser formatado;
--  - (Opcional) um número T, que é o tamanho da string resultante;
--  - (Opcional) um número D, que indica a quantidade de casas decimais que deve arredonda N.
--
-- O que fará a função?
--  1. Arredondará N para D casas decimais
--	2. Gerará uma string de T caracteres em branco
--	3. Colocará N arredondado na string, formatado à direita.
--
-- Caso o tamanho de N arredondado seja maior que o tamanho da string, a função retorna uma string
-- de D caracteres *.

-- Neste exemplo, formatará o número 187,369 para 2 casas decimais, e colocará ele em uma string de 6
-- caracteres.
SELECT STR(187.369, 6, 2);