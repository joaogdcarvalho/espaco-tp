-- proc para bloquear mais de um agendamento ativo para aluno em um mesmo dia
USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspValidarCronogramaDia`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspValidarCronogramaDia`(
IN pNumIdAluno INT(11),
IN pNumDataAgendamento DATE,
IN pNumIdHorarioAgendamento INT(1)
)

BEGIN

	DECLARE varNumCount INT DEFAULT 0;
    DECLARE varBooAlunoInclusoCronogramaDia TINYINT DEFAULT 0;
        
	SELECT
		COUNT(a.id_agendamento)
	INTO
        varNumCount
	FROM 
		agendamentos a
	WHERE	IFNULL(a.ativo,0) = 1
	AND		a.id_aluno = pNumIdAluno
	AND		a.data_agendamento = pNumDataAgendamento
    AND		a.id_horario_agendamento != pNumIdHorarioAgendamento;

	IF (IFNULL( varNumCount, 0 ) > 0 )
	THEN SET varBooAlunoInclusoCronogramaDia = 1;
    END IF;
    
    SELECT varBooAlunoInclusoCronogramaDia AS `aluno_incluso_cronograma_dia`;
	
END $$

DELIMITER ;