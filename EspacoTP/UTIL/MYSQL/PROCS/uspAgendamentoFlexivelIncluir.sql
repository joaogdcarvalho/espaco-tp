-- proc para agendamento automático, na inclusão de plano de aula de aula
USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspAgendamentoFlexivelIncluir`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspAgendamentoFlexivelIncluir`(
IN pNumIdAluno INT(11),
IN pDtDataInicioContrato DATE,
IN pDtDataTerminoContrato DATE,
IN pNumIdDiaAgendamento INT(1),
IN pNumIdHorarioAgendamento INT(1)
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
        1							as 'ativo'
	FROM
			calendario c
	WHERE	c.data BETWEEN pDtDataInicioContrato AND pDtDataTerminoContrato
	AND		DATE_FORMAT(c.data,'%w') = pNumIdDiaAgendamento
    ;
		
END $$

DELIMITER ;