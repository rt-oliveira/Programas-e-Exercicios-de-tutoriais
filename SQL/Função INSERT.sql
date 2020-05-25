-- Função INSERT
-- São passados 4 argumentos:
-- 1- A string original (S);
-- 2- Uma posição inicial (P);
-- 3- A quantidade de caracteres (Q), e;
-- 4- Uma outra string, que será usada para substituição (T).
-- A função retornará S, mas com uma modificação: na posição P, e pelos próximos Q caracteres, será substituída por T.

-- Uma observação: caso S, P, Q ou T seja NULL, a função retorna NULL.

-- Nesse exemplo, os caracteres entre as posições 3 e 6 
-- da string 'Quadrattic' serão substituídos pela string 'What'.
SELECT INSERT('Quadrattic', 3, 4, 'What');
