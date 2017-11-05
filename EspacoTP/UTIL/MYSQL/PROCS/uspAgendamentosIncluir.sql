USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspAgendamentosIncluir`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspAgendamentosIncluir`(
IN pNumIdInstrutor INT(11),
IN pNumIdAluno INT(11),
IN pNumDataAgendamento DATE,
IN pNumIdHorarioAgendamento INT(1),
IN pBooAtivo TINYINT(1)
)

BEGIN
        
	INSERT INTO	agendamentos
    (
		id_instrutor,
		id_aluno,
		data_agendamento,
		id_horario_agendamento,
        ativo
    )
    VALUES
    (
		pNumIdInstrutor,
		pNumIdAluno,
		pNumDataAgendamento,
		pNumIdHorarioAgendamento,
        pBooAtivo
    );

END $$

DELIMITER ;