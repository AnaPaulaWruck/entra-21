-- 1. Selecione todas as colunas da tabela.

SELECT id,
	nome AS 'Nome',
	cpf AS 'CPF',
	nick AS 'Nickname',
	signo AS 'Signo',
	numero_favorito AS 'Num Favorito',
	cor_preferida AS 'Cor Preferida',
	nota_1 AS 'Nota 1',
	nota_2 AS 'Nota 2',
	nota_3 AS 'Nota 3',
	nota_4 AS 'Nota 4',
	FORMAT(data_nascimento, 'dd/MM/yyyy') AS 'Data Nascimento'
	FROM alunos;

-- 2. Selecione o nome dos alunos que a nota 1 é maior que 9.0.

SELECT nome, nota_1
	FROM alunos
	WHERE nota_1 > 9;

-- 3. Selecione o nome do aluno, nota 1, nota 2, nota 3, nota 4, e a média.

SELECT nome, nota_1, nota_2, nota_3, nota_4, 
	media = ((nota_1 + nota_2 + nota_3 + nota_4) / 4)
	FROM alunos;

-- 4. Contabilize a quantidade de alunos com o signo de Peixes

SELECT quantidade_peixes = COUNT(nome)
	FROM alunos
	WHERE signo = 'Peixes';

-- 5. Selecione a soma da nota 1

SELECT SUM(nota_1) AS 'Média Nota 1'
	FROM alunos;

-- 6. Selecione a média da nota 2

SELECT AVG(nota_2) AS 'Média Nota 2'
	FROM alunos;

-- 7. Selecione o nome, menor nota 1.

SELECT nome, nota_1
	FROM alunos
	WHERE nota_1 = (SELECT MIN(p.nota_1) FROM alunos p);

-- 8. Selecione o nome, nota 1, nota 2, nota 3, nota 4 com o maior nome.

SELECT nome, nota_1, nota_2, nota_3, nota_4, LEN(nome)
	FROM alunos
	WHERE LEN(nome) = (SELECT MAX(LEN(p.nome)) FROM alunos p);

-- 9. Selecione a cor e quantidade com a cor Gelo.

SELECT quantidade_cor_gelo = COUNT(cor_preferida)
	FROM alunos
	WHERE cor_preferida = 'Gelo';

-- 10. Selecione a quantidade de alunos que o nome contém Francisco no começo.

SELECT nome_comeca_com_francisco = COUNT(nome)
	FROM alunos
	WHERE nome LIKE 'Francisco%';

-- 11. Selecione a quantidade de alunos que o nome contém Luc.

SELECT nome_contem_luc = COUNT(nome)
	FROM alunos
	WHERE nome LIKE '%luc%';

-- 12. Selecione o nome, signo e data de nascimento quando o signo Áries

SELECT nome, signo, FORMAT(data_nascimento, 'dd/MM/yyyy') AS 'Data Nascimento'
	FROM alunos
	WHERE signo = 'Áries'
	ORDER BY data_nascimento ASC;

-- 13. Selecione o nome, nota 1, nota 2, nota 3, nota 4 com o maior média.

SELECT TOP(1) nome, nota_1, nota_2, nota_3, nota_4, media = ((nota_1 + nota_2 + nota_3 + nota_4) / 4)
	FROM alunos
	ORDER BY media DESC;

-- 14. Selecione o nome, média e caso a média for menor que 5 apresentar reprovado, caso for menor que 7 apresentar em exame senão apresentar aprovado.
	-- Dica: buscar como fazer IF em sql.
		-- IF(condition, value_if_true, value_if_false)

SELECT nome, 



-- 15. Selecione o nome, nota 1, nota 2, nota 3, nota 4 com o menor média.

SELECT TOP(1) nome, nota_1, nota_2, nota_3, nota_4, media = ((nota_1 + nota_2 + nota_3 + nota_4) / 4)
	FROM alunos
	ORDER BY media ASC;

-- 16. Selecione a quantidade de alunos em que a média foi maior que 7
-- 17. Selecione o nome, nick do aluno que o nick contém 5 caracteres.
-- 18. Selecione o nome do aluno quando a cor for ouro ou amarelo-torrado e a média for maior que seis e meio.
-- 19. Selecione o nome e o ano da data de nascimento.
-- 20. Selecione o nick e o mês de nascimento quando o mês de nascimento for maior que 6.
-- 21. Selecione a quantidade de pessoas que nasceram no ano de 1996
-- 22. Selecione a quantidade de pessoas de pessoas que nasceram no dia dois do mês de fevereiro do ano 1964 ou 1994.
-- 23. Selecione o nick e a nota 4 do aluno que a nota 2 está entre 5.0 e 5.99.
-- 24. Apresentar a média da aluna Josefina.

SELECT nome, media = ((nota_1 + nota_2 + nota_3 + nota_4) / 4)
	FROM alunos
	WHERE nome LIKE '%Josefina%';

-- 25. Apresentar nome, nick, nota 1, nota 2, nota 3, nota 4, quando o nome conter Justino e o signo começar com ‘A’.
-- 26. Apresentar a média das médias.

