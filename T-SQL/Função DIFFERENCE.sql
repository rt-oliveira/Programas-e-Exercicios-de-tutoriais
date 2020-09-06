-- Função DIFFERENCE
-- Indica o grau de similaridade entre duas expressões.
-- Usa o Soundex das duas expressões para calcular.
--
-- A função retorna um valor entre 0 e 4, onde quanto maior o valor mais similaridade
-- há entre elas.

-- Neste exemplo, será retornado o valor 4, indicando que as expressões são muito similares (ou até mesmo idênticos).
SELECT DIFFERENCE('Smith', 'Smyth');