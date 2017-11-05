USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspContarAlunosTurma`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspContarAlunosTurma`(
IN pDtDataAgendamento DATE,
IN pNumIdHorarioAgendamento INT(11)
)

BEGIN

	DECLARE varNumCount INT DEFAULT 0;
        
	SELECT
		COUNT(a.ativo)
	INTO
        varNumCount
	FROM 
		agendamentos a
	WHERE
		IFNULL( a.ativo, 0 ) = 1
	AND a.data_agendamento = pDtDataAgendamento
	AND	a.id_horario_agendamento = pNumIdHorarioAgendamento;
	   
    SELECT varNumCount AS `quantidade_alunos_turma`;
	
END $$

DELIMITER ;