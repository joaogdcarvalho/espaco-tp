-- proc para bloquear mais de um periodo ativo para aluno no mesmo dia
USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspValidarDiaRepetido`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspValidarDiaRepetido`(
IN pNumIdAluno INT(11),
IN pNumIdDataAgendamento INT(1),
IN pNumIdHorarioAgendamento INT(1)
)

BEGIN

	DECLARE varNumCount INT DEFAULT 0;
    DECLARE varBooDiaRepetido TINYINT DEFAULT 0;
        
	SELECT
		COUNT(a.id_periodo)
	INTO
        varNumCount
	FROM 
		periodos p
    WHERE	IFNULL(p.ativo,0) = 1
	AND		p.id_aluno = pNumIdAluno
	AND		p.id_dia_agendamento = pNumIdDataAgendamento
    AND		p.id_horario_agendamento != pNumIdHorarioAgendamento;

	IF (IFNULL( varNumCount, 0 ) > 0 )
	THEN SET varBooDiaRepetido = 1;
    END IF;
    
    SELECT varBooDiaRepetido AS `dia_repetido`;
	
END $$

DELIMITER ;