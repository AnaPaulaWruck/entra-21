CREATE TABLE trabalhos(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	titulo VARCHAR(100),
	subtitulo VARCHAR(50),
	descricao TEXT, -- textos grandes
	data_publicacao	DATETIME2, -- data e hora
	tipo VARCHAR(15)
);

INSERT INTO trabalhos 
	(titulo, subtitulo, descricao, data_publicacao, tipo)
	VALUES ('A melhor pizza do mundo', 
	'Como degustar uma pizza de calabresa', 
	'Grande descrição aqui', 
	'1994-06-04', 
	'Receita');

INSERT INTO trabalhos 
	(titulo, subtitulo, descricao, data_publicacao, tipo)
	VALUES ('Clean code', 
	'Como trabalhar melhor no seu dia a dia', 
	'Utilizar var no lugar de tipo primitivo, Identar seu código, Utilizar constantes', 
	'2000-03-20', 
	'Leitura técina');

INSERT INTO trabalhos 
	(titulo, subtitulo, descricao, data_publicacao, tipo)
	VALUES ('Pudim com ovo', 
	'Aprenda o que não fazer em sua vida', 
	'Jogue o pudim no lixo e faça um ovo', 
	'2022-07-06', 
	'Receita');

INSERT INTO trabalhos 
	(titulo, subtitulo, descricao, data_publicacao, tipo)
	VALUES ('Estrutura de dados', 
	'Como sofrer sem saber, mas é necessário', 'Importante para aprender fifo, fefo e lifo, listas encadeadas', 
	'1980-05-11', 
	'Leitura técnica');

INSERT INTO trabalhos 
	(titulo, subtitulo, descricao, data_publicacao, tipo)
	VALUES ('Estrogonofe de frango com batata palha', 
	'A vitória da batata palha', 
	'Compre frango e batata palha, jogue na panela, acenda o fogão, espera 5 minutinhos e tá pronto', 
	'2000-09-10', 
	'Receita');

SELECT id, titulo, subtitulo, descricao, data_publicacao, tipo
	FROM trabalhos;

-- Concatenar informação de duas colunas
SELECT 
	CONCAT(titulo, ' - ', subtitulo) AS 'Título completo' 
	FROM trabalhos;

-- Consultar a descrição limitando a quantidade de caracteres
SELECT 
	titulo AS 'Título',
	CONCAT(SUBSTRING(descricao, 0, 20), '...') AS 'Descrição'
	FROM trabalhos;

-- Consultar os trabalhos filtrando por ano da publicação entre 1990 e 2010
SELECT id, titulo, data_publicacao
	FROM trabalhos
	WHERE
		YEAR(data_publicacao) >= 1990 AND
		YEAR(data_publicacao) <= 2010;

-- Consultar data publicação formato BR
-- BR: dia/mes/ano
SELECT id, titulo, 
	CONCAT(DAY(data_publicacao), '/',
	MONTH(data_publicacao), '/',
	YEAR(data_publicacao)) AS 'Data de publicação'
	FROM trabalhos;

-- Consultar a data da publicação formatando no padrão BR, utilizando função para isso
SELECT id, titulo, FORMAT(data_publicacao, 'dd/MM/yyyy')
	FROM trabalhos;

SELECT id, titulo FROM trabalhos;

-- Limitar a consulta para 2 registros
SELECT TOP(2) id, titulo FROM trabalhos;

-- Apresentar o código, nome, preço, se está favoritado, filtrando por Placa Mãe ou Placa de Vídeo do maior preço para o menor
-- SELECT TOP(20) id, nome, preco, favoritado
-- FROM produtos
-- WHERE categoria = 'Placa mãe' OR categoria = 'Placa de vpideo'
-- ORDER BY preco DESC;

	-- Para fazer paginação (recomendado fazer pelo banco do que pelo front)
	-- Offset: usa o índice do registro da consulta
	-- Fetch next: usa a quantidade que quer apresentar por página
	-- (numero pagina - 1) * quantidade de elementos

-- Consulta com paginação apresentando 2 registros da página 1
SELECT id, titulo 
	FROM trabalhos
	ORDER BY id
	OFFSET 0 ROWS FETCH NEXT 2 ROWS ONLY;

-- Consulta com paginação apresentando 2 registros da página 2
SELECT id, titulo 
	FROM trabalhos
	ORDER BY id
	OFFSET 2 ROWS FETCH NEXT 2 ROWS ONLY;

-- Consulta com paginação apresentando 2 registros da página 3
SELECT id, titulo 
	FROM trabalhos
	ORDER BY id
	OFFSET 4 ROWS FETCH NEXT 2 ROWS ONLY;