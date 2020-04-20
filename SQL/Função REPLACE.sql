-- Função REPLACE
-- Dadas 3 string, *a*, *b* e *c*, ele trocará todas as ocorrências de *b* em *a* por *c*.
-- As procuras da string *b* na string *a* são case-sensitive, isto é, considera diferentes os caracteres maiúsculos e minúsculos.

-- Neste exemplo, todas as ocorrências de 'w' na string 'www.mysql.com' serão substituídas por 'Ww'.
SELECT REPLACE('www.mysql.com','w','Ww');