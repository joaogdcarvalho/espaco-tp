USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspAgendamentosAlterar`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspAgendamentosAlterar`(
IN pNumIdInstrutor INT(11),
IN pNumIdAluno INT(11),
IN pNumDataAgendamento DATE,
IN pNumIdHorarioAgendamento INT(1),
IN pBooAtivo TINYINT(1),
IN pNumIdAgendamento INT(11)
)

BEGIN
        
	UPDATE	agendamentos
    SET
		id_instrutor = pNumIdInstrutor,
		id_aluno = pNumIdAluno,
		data_agendamento = pNumDataAgendamento,
		id_horario_agendamento = pNumIdHorarioAgendamento,
        ativo = pBooAtivo
    WHERE
		id_agendamento = pNumIdAgendamento;

END $$

DELIMITER ;