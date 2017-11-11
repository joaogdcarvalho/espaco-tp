USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspAlunosDetalhar`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspAlunosDetalhar`(
IN pNumIdAluno INT(11)
)

BEGIN
        
	SELECT
        a.nome								as 'nome',
        a.sobrenome							as 'sobrenome',
        a.cpf								as 'cpf',
        a.id_tipo_telefone					as 'id_tipo_telefone',
		a.numero_telefone					as 'numero_telefone',
        a.email								as 'email',
        a.data_inicio_contrato 				as 'data_inicio_contrato',
        a.data_termino_contrato 			as 'data_termino_contrato',
        a.data_termino_contrato_anterior	as 'data_termino_anterior',
        a.cep								as 'cep',
        a.logradouro						as 'logradouro',
        a.numero_residencial				as 'numero_residencial',
        a.bairro							as 'bairro',
        a.municipio							as 'municipio'
	FROM 
		alunos a
	WHERE
		a.id_aluno = pNumIdAluno;

END $$

DELIMITER ;