USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspPeriodosAlterar`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspPeriodosAlterar`(
IN pNumIdAluno INT(11),
IN pNumIdDiaAgendamento INT(11),
IN pNumIdHorarioAgendamento INT(2),
IN pBooAtivo TINYINT(1),
IN pNumIdPeriodo INT(11)
)

BEGIN
        
	UPDATE	periodos
    SET
		id_aluno = pNumIdAluno,
		id_dia_agendamento = pNumIdDiaAgendamento,
		id_horario_agendamento = pNumIdHorarioAgendamento,
        ativo = pBooAtivo
    WHERE
		id_periodo = pNumIdPeriodo;

END $$

DELIMITER ;