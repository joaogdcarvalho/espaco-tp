-- criar script de versão, sem tela: CELULAR / FIXO / OUTRO
START TRANSACTION;
INSERT INTO tipos_telefone ( descricao, ativo )
			SELECT 'CELULAR' AS descricao,	1 AS ativo
UNION ALL 	SELECT 'FIXO', 					1
UNION ALL 	SELECT 'OUTRO',					1;
COMMIT;
SELECT * FROM tipos_telefone;

-- criar script de versão, sem tela: DOMINGO / SEGUNDA-FEIRA / TERÇA-FEIRA / QUARTA-FEIRA / QUINTA-FEIRA / SEXTA-FEIRA / SÁBADO
START TRANSACTION;
INSERT INTO dias_agendamento ( dia, ativo )
			SELECT 'DOMINGO' AS dia,	1 AS ativo
UNION ALL 	SELECT 'SEGUNDA', 			1
UNION ALL 	SELECT 'TERÇA-FEIRA', 		1
UNION ALL 	SELECT 'QUARTA-FEIRA', 		1
UNION ALL 	SELECT 'QUINTA-FEIRA', 		1
UNION ALL 	SELECT 'SEXTA-FEIRA', 		1
UNION ALL 	SELECT 'SÁBADO', 			1;
COMMIT;
SELECT * FROM dias_agendamento;

-- criar script de versão, sem tela: 07:00 até 20:00
START TRANSACTION;
INSERT INTO horarios_agendamento ( hora, ativo )
			SELECT '07:00' AS hora,	1 AS ativo
UNION ALL 	SELECT '08:00', 		1
UNION ALL 	SELECT '09:00', 		1
UNION ALL 	SELECT '10:00', 		1
UNION ALL 	SELECT '11:00', 		1
UNION ALL 	SELECT '12:00', 		1
UNION ALL 	SELECT '13:00', 		1
UNION ALL 	SELECT '14:00', 		1
UNION ALL 	SELECT '15:00', 		1
UNION ALL 	SELECT '16:00', 		1
UNION ALL 	SELECT '17:00', 		1
UNION ALL 	SELECT '18:00', 		1
UNION ALL 	SELECT '19:00', 		1
UNION ALL 	SELECT '20:00', 		1;
COMMIT;
SELECT * FROM horarios_agendamento;

-- criar script de versão, sem tela: ADMINISTRADOR / PADRÃO
START TRANSACTION;
INSERT INTO tipos_usuario ( descricao, administrador )
			SELECT 'ADMINISTRADOR' AS descricao,	1 AS administrador
UNION ALL 	SELECT 'PADRÃO', 						0;
COMMIT;
SELECT * FROM tipos_usuario;

-- criar script de versão, com tela: USUÁRIO ADMIN
START TRANSACTION;
INSERT INTO usuarios ( nome, usuario, senha, id_tipo_usuario, ativo )
			SELECT 'ESPAÇO TP', 'ADMIN',	'ADMIN', 1, 1;
COMMIT;
SELECT * FROM usuarios;