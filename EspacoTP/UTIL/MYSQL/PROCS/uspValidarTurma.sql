-- proc para bloquear mais de um agendamento para aluno em uma mesma turma
USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspValidarTurma`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspValidarTurma`(
IN pNumIdAluno INT(11),
IN pNumDataAgendamento DATE,
IN pNumIdHorarioAgendamento INT(1)
)

BEGIN

	DECLARE varNumCount INT DEFAULT 0;
    DECLARE varBooAlunoInclusoTurma TINYINT DEFAULT 0;
        
	SELECT
		COUNT(a.id_agendamento)
	INTO
        varNumCount
	FROM 
		agendamentos a
	WHERE
		a.id_aluno = pNumIdAluno
	AND	a.data_agendamento = pNumDataAgendamento
    AND	a.id_horario_agendamento = pNumIdHorarioAgendamento;

	IF (IFNULL( varNumCount, 0 ) > 0 )
	THEN SET varBooAlunoInclusoTurma = 1;
    END IF;
    
    SELECT varBooAlunoInclusoTurma AS `aluno_incluso_turma`;
	
END $$

DELIMITER ;