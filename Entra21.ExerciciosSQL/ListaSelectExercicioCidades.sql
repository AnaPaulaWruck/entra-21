
-- 1. Selecione o estado e cidade.

SELECT estado AS 'UF', 
	cidade AS 'Cidade'
	FROM cidades;

-- 2. Selecione as cidades que começam com a letra A.

SELECT cidade 
	FROM cidades 
	WHERE cidade LIKE 'A%';

-- 3. Selecione as cidades que contenham no ‘apar’ em qualquer parte do nome

SELECT cidade
	FROM cidades
	WHERE cidade LIKE '%apar%';

-- 4. Selecione as cidades que começam com a letra W.

SELECT cidade	
	FROM cidades
	WHERE cidade LIKE 'W%';

-- 5. Selecione o estado e a cidade que a cidade termina com ‘tuba’ ordenando pelo estado em ordem decrescente.

SELECT estado, cidade
	FROM cidades
	WHERE cidade LIKE '%tuba'
	ORDER BY estado DESC;

-- 6. Selecione a cidade que o nome da cidade contenha mais que 15 caracteres, ordenando pelo quantidade de caracteres.

SELECT cidade, quantidade_caracteres = LEN(cidade)
	FROM cidades
	WHERE LEN(cidade) > 15
	ORDER BY LEN(cidade) ASC;

-- 7. Contabilize a quantidade de cidades do estado de SC.

SELECT cidades_SC = COUNT(cidade)
	FROM cidades
	WHERE estado = 'SC';

-- 8. Contabilize a quantidade de cidades do estado de SP.

SELECT cidade_SP = COUNT(cidade)
	FROM cidades
	WHERE estado = 'SP';

-- 9. Selecione o nome da cidade com a quantidade de caracteres, quando o nome da cidade conter 10 caracteres.

SELECT cidade, quantidade_caracteres = LEN(cidade), estado
	FROM cidades
	WHERE LEN(cidade) = 10
	ORDER BY cidade ASC;