-- 1. Selecione todas as colunas.

SELECT id,
	nome AS 'Nome', 
	codigo AS 'Cód.', 
	categoria AS 'Categoria', 
	descricao AS 'Descrição', 
	altura AS 'Altura', 
	peso AS 'Peso', 
	hp AS 'HP', 
	ataque AS 'Ataque', 
	defesa AS 'Defesa', 
	especial_ataque AS 'Atq. Especial', 
	especial_defesa AS 'Def. Especial', 
	velocidade AS 'Velocidade'
	FROM pokemons;


-- 2. Selecione o ataque, ataque especial, defesa e defesa especial.

SELECT nome, ataque, especial_ataque, defesa, especial_defesa FROM pokemons;

-- 3. Selecione nome, categoria e ataque ordenado pelo ataque em ordem crescente.

SELECT nome, categoria, ataque 
	FROM pokemons 
	ORDER BY ataque, nome ASC;

-- 4. Selecione altura, peso, com o cálculo do imc.

SELECT nome, altura, peso, imc = (peso / (altura * altura)) 
	FROM pokemons;

-- 5. Selecione altura, peso, com o cálculo do imc ordenando o imc em ordem decrescente.

SELECT nome, altura, peso, imc = (peso / (altura * altura)) 
	FROM pokemons 
	ORDER BY imc DESC;

-- 6. Selecione nome e o tamanho do nome em ordem decrescente pelo nome.

SELECT nome, tamanho_nome = LEN(nome) 
	FROM pokemons
	ORDER BY tamanho_nome DESC;

-- 7. Selecione nome, descrição, quando o nome contiver mais que 10 caracteres.

SELECT nome, descricao FROM pokemons WHERE LEN(nome) > 10;

-- 8. Selecione nome, categoria, e ataque do pokemon que contém o menor valor de ataque.

SELECT nome, categoria, ataque 
	FROM pokemons 
	WHERE ataque = (SELECT MIN(p.ataque) FROM pokemons p)
	ORDER BY nome ASC;

-- 9. Selecione o ataque, ataque especial, nome, defesa e defesa especial ordenando pelo ataque.

SELECT nome, ataque, especial_ataque, defesa, especial_defesa 
	FROM pokemons
	ORDER BY ataque ASC;

-- 10. Selecione a média dos ataques.

SELECT AVG(ataque) FROM pokemons;

-- 11. Selecione a somatória dos ataques.

SELECT SUM(ataque) FROM pokemons;

-- 12. Selecione a média dos ataques especiais quando o nome do pokemon começar com ‘P’.

SELECT AVG(especial_ataque)
	FROM pokemons
	WHERE nome LIKE 'P%';