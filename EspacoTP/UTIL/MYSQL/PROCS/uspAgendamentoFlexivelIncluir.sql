-- proc para inclusão de agendamentos automático, após adição de plano de aula de aula
USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspAgendamentoFlexivelIncluir`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspAgendamentoFlexivelIncluir`(
IN pNumIdAluno INT(11),
/*IN pDtDataInicioContrato DATE,*/
IN pDtDataTerminoContrato DATE,
IN pNumIdDiaAgendamento INT(1),
IN pNumIdHorarioAgendamento INT(1),
IN pBooAtivo TINYINT(1)
)

BEGIN
        
	INSERT INTO	agendamentos
    (
		id_aluno,
		data_agendamento,
		id_horario_agendamento,
        ativo
    )
    SELECT
		pNumIdAluno					as 'id_aluno',
		c.data						as 'data',
		pNumIdHorarioAgendamento	as 'id_horario',
        pBooAtivo					as 'ativo'
	FROM
			calendario c
	WHERE	c.data BETWEEN DATE_FORMAT(now(), '%Y-%m-%d') AND DATE_FORMAT(pDtDataTerminoContrato, '%Y-%m-%d')
	AND		DATE_FORMAT(c.data,'%w') = pNumIdDiaAgendamento;
    
    /*
    INSERT INTO	agendamentos
    (
		id_aluno,
		data_agendamento,
		id_horario_agendamento,
        ativo
    )
    SELECT
		pNumIdAluno					as 'id_aluno',
		c.data						as 'data',
		pNumIdHorarioAgendamento	as 'id_horario',
        pBooAtivo					as 'ativo'
	FROM
			calendario c
	WHERE	c.data BETWEEN pDtDataInicioContrato AND pDtDataTerminoContrato
	AND		DATE_FORMAT(c.data,'%w') = pNumIdDiaAgendamento;
		*/
        
END $$

DELIMITER ;