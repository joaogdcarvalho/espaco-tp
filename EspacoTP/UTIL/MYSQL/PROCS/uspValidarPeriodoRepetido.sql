-- proc para bloquear mais de um periodo para aluno com mesmo dia e horário
USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspValidarPeriodoRepetido`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspValidarPeriodoRepetido`(
IN pNumIdAluno INT(11),
IN pNumIdDataAgendamento INT(1),
IN pNumIdHorarioAgendamento INT(1)
)

BEGIN

	DECLARE varNumCount INT DEFAULT 0;
    DECLARE varBooPeriodoRepetido TINYINT DEFAULT 0;
        
	SELECT
		COUNT(a.id_periodo)
	INTO
        varNumCount
	FROM 
		periodos p
	WHERE
		p.id_aluno = pNumIdAluno
	AND	p.id_dia_agendamento = pNumIdDataAgendamento
    AND	p.id_horario_agendamento = pNumIdHorarioAgendamento;

	IF (IFNULL( varNumCount, 0 ) > 0 )
	THEN SET varBooPeriodoRepetido = 1;
    END IF;
    
    SELECT varBooPeriodoRepetido AS `periodo_repetido`;
	
END $$

DELIMITER ;