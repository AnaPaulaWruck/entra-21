﻿CREATE TABLE pecas(
	id INTEGER PRIMARY KEY IDENTITY(1,1), -- PK
	nome VARCHAR(50),
	tipo INTEGER,
	preco_unitario DECIMAL(6,2)
);

CREATE TABLE clientes(
	id INTEGER PRIMARY KEY IDENTITY(1,1), -- PK
	nome VARCHAR(40),
	cpf VARCHAR(14)
);

CREATE TABLE enderecos(
	id INTEGER PRIMARY KEY IDENTITY(1,1), -- PK
	id_cliente INTEGER NOT NULL, -- FK
	cep VARCHAR(9) NOT NULL,
	estado VARCHAR(2) NOT NULL,
	cidade VARCHAR(30) NOT NULL,
	bairro VARCHAR(30) NOT NULL,
	logradouro VARCHAR(40) NOT NULL,
	numero VARCHAR(10) NOT NULL, -- NOT NULL => significa que o dado é obrigatório
	descricao TEXT,
	-- FOREIGN KEY nome_coluna_tabela_atual REFERENCES nome_tabela_pai(nome_coluna_pai_pk)
	FOREIGN KEY (id_cliente) REFERENCES clientes(id)
);

CREATE TABLE pedidos(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	id_cliente INTEGER NOT NULL,
	status TINYINT NOT NULL, -- 0, ... 255,
	data_criacao DATETIME2 NOT NULL,
	data_efetivacao_compra DATETIME2
);

CREATE TABLE pedidos_pecas(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	id_peca INTEGER, -- FK tabela peças
	id_pedido INTEGER, -- FK tabela pedidos

	quantidade SMALLINT,

	FOREIGN KEY(id_pedido) REFERENCES pedidos(id),
	FOREIGN KEY(id_peca) REFERENCES pecas(id),
);

-- TIPOS DE PEÇAS:
-- 1 SSD
-- 2 Placa de video
-- 3 Placa mãe
-- 4 Fonte
-- 5 Memória RAM

INSERT INTO pecas(nome, tipo, preco_unitario) 
	VALUES
	('SSD 240 GB', 1, 200),
	('SSD 240 M2', 1, 429.39),
	('RTX 3090 TI', 2, 9999.90),
	('GTX 1060', 2, 1500),
	('16GB DDR5 4800GHz', 5, 800),
	('16GB DDR4 3200ghZ', 5, 350);

INSERT INTO clientes(nome, cpf) 
	VALUES
	('Claúdio', '070.355.489-73'),
	('Cry', '032.599.384-69'),
	('Júliannã', '123.495.392-02');

INSERT INTO enderecos(id_cliente, estado, cidade, bairro, cep, logradouro, numero)
	VALUES
	(1, 'SC', 'Blumenau', 'Velha', '89070-301', 'Rua Divinópolis', 777),
	(2, 'SC', 'Blumenau', 'Velha Grande', '89070-472', 'Morro da Edith', 36),
	(3, 'SC', 'Blumenau', 'Judity', 'Sem cep', 'Rua da Kellen', 23);

SELECT * FROM pecas;
SELECT * FROM clientes;
SELECT * FROM enderecos;

-- Consultar para listar o nome, cpf, os clientes apresentando o endereço completo 
SELECT 
	c.nome AS 'Nome',
	c.cpf AS 'CPF',
	CONCAT(
		e.estado, ' - ',
		e.cidade, ' - ',
		e.bairro, ' - ',
		e.logradouro, ' ',
		e.numero) AS 'Endereço Completo'
	FROM clientes AS c
	INNER JOIN enderecos AS e ON (e.id_cliente = c.id);
	
-- VER SQL JOINS (TEORIA DOS CONJUNTOS EM MATEMÁTICA)

-- Consultar os endereços apresentando seu cliente filtrando por bairros com nome 'Velha'
-- Consulta partindo da tabela de endereços com outra consulta na tabela de clientes
SELECT
	c.nome,
	e.bairro,
	e.logradouro,
	e.numero
	FROM enderecos AS e
	INNER JOIN clientes AS c ON (c.id = e.id_cliente)
	WHERE e.bairro LIKE '%Velha%';

-- Status do pedido:
-- 0 = carrinho
-- 1 = Aguardando pagamento
-- 2 = Pagamento efetivado
-- Entrega realizada
INSERT INTO pedidos (id_cliente, status, data_criacao) VALUES
	(1, 0, GETDATE()), -- Pedido para o Claúdio
	((SELECT id FROM clientes WHERE nome = 'Cry'), 0, GETDATE()); -- Pedido para o Cry

-- Consultar pedidos listando data da criação formato PT-BR, status com texto e nome do cliente
-- Consulta partindo da tabela de pedidos com JOIN em clientes
SELECT 
	FORMAT (p.data_criacao, 'dd/MM/yyyy'),
	CASE
		WHEN [status] = 0 THEN 'Carrinho'
		WHEN [status] = 1 THEN 'Aguardando Pagamento'
		WHEN [status] = 2 THEN 'Pagamento Efetivado'
		ELSE 'Entrega Realizada'
	END AS 'Status pedido',
	c.nome
	FROM pedidos AS p
	INNER JOIN clientes AS c ON (p.id_cliente = c.id);

UPDATE pedidos SET status = 1 WHERE id = 2;

-- Adicionar as peças ao pedido
SELECT * FROM pecas;

INSERT INTO pedidos_pecas (id_pedido, id_peca, quantidade) VALUES
(1, 2, 2), -- 2 SSDs M2 para o pedido 1
(1, 4, 1), -- 1 GTX 1060 para o pedido 1
(1, 6, 1); -- 1 módulo 16Gb RAM DOS

-- Alterar cliente do pedido 1 para o cliente Cry
UPDATE pedidos SET id_cliente = 2 WHERE id = 1;

-- Consultar apresentando nome cliente, nome peça, quantidade, valor unitário, valor total das peças
SELECT 
	pd.id AS 'Código Pedido',
	c.nome AS 'Cliente',
	p.nome AS 'Peça',
	pp.quantidade AS 'Quantidade',
	CONCAT('R$ ', p.preco_unitario) AS 'Preço Unitário',
	CONCAT('R$ ', p.preco_unitario * pp.quantidade) AS 'Total das Peças'
	FROM pedidos_pecas AS pp
	INNER JOIN pecas AS p ON (pp.id_peca = p.id)
	INNER JOIN pedidos AS pd ON (pp.id_pedido = pd.id)
	INNER JOIN clientes AS c ON (pd.id_cliente = c.id);

INSERT INTO pedidos (id_cliente, data_criacao, status) VALUES
	(1, GETDATE(), 0);

-- Criado pedido para o Claúdio
INSERT INTO pedidos_pecas (id_pedido, id_peca, quantidade) VALUES
(3, 2, 2), -- id_pedido = 3, id_peca = 2, (SSD 240M2), quantidade = 2
(3, 3, 2), -- id_pedido = 3, id_peca = 3, (RTX3090 TI), quantidade = 2
(3, 5, 4); -- id_pedido = 3, id_peca = 5, (16Gb RAM DDR5), quantidade = 4

-- Apresentar informações do pedido do cliente Claúdio
SELECT
	p.id AS 'Código Pedido',
	p.status AS 'Status Pedido',
	c.nome AS 'Cliente',
	CONCAT(
		e.estado, ' ',
		e.cidade, ' ',
		e.bairro, ' ',
		e.logradouro, ' ',
		e.numero) AS 'Endereço Completo'
	FROM pedidos AS p
	INNER JOIN clientes AS c ON (p.id_cliente = c.id)
	INNER JOIN enderecos AS e ON (c.id = e.id_cliente)
	WHERE p.id_cliente = (SELECT id FROM clientes WHERE cpf = '070.355.489-73');

-- Efetivar a compra do Claúdio (alterar o status do pedido)
UPDATE pedidos
	SET
		status = 2,
		data_efetivacao_compra = '2022-07-12 17:30:00'
	WHERE
		id = 3;

SELECT * FROM clientes;

-- Consultar peças do pedido do Claúdio
SELECT
	p.id AS 'Código Pedido',
	p.status AS 'Status Pedido',
	c.nome AS 'Cliente',
	pec.nome AS 'Peça'	
	FROM pedidos AS p
	INNER JOIN clientes AS c ON (p.id_cliente = c.id)
	INNER JOIN pedidos_pecas AS pp ON (p.id = pp.id_peca)
	INNER JOIN pecas AS pec ON (pp.id_peca = pec.id)
	WHERE p.id_cliente = (SELECT id FROM clientes WHERE cpf = '070.355.489-73');
