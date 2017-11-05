USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspPeriodosIncluir`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspPeriodosIncluir`(
IN pNumIdAluno INT(11),
IN pNumIdDiaAgendamento INT(11),
IN pNumIdHorarioAgendamento INT(2)
)

BEGIN
        
	INSERT INTO	periodos
    (
		id_aluno,
		id_dia_agendamento,
		id_horario_agendamento
    )
    VALUES
    (
		pNumIdAluno,
		pNumIdDiaAgendamento,
		pNumIdHorarioAgendamento
    );

END $$

DELIMITER ;