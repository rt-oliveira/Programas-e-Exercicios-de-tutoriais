-- Função FORMAT
-- Formata um determinado dado para um padrão fornecido.
--
-- Para entender melhor as formatações que podem ser feitas, além de mais dados sobre a função:
-- https://docs.microsoft.com/pt-br/sql/t-sql/functions/format-transact-sql?view=sql-server-ver15

-- Nesse exemplo será mostrada a data atual por extenso e com dia da semana atual.
SELECT FORMAT(getdate(), 'D');