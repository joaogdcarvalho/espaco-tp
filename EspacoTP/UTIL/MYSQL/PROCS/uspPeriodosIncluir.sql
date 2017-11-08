USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspPeriodosIncluir`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspPeriodosIncluir`(
IN pNumIdAluno INT(11),
IN pNumIdDiaAgendamento INT(11),
IN pNumIdHorarioAgendamento INT(2),
IN pBooAtivo TINYINT(1)
)

BEGIN
        
	INSERT INTO	periodos
    (
		id_aluno,
		id_dia_agendamento,
		id_horario_agendamento,
		ativo
    )
    VALUES
    (
		pNumIdAluno,
		pNumIdDiaAgendamento,
		pNumIdHorarioAgendamento,
        pBooAtivo
    );

END $$

DELIMITER ;