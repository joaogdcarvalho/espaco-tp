USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspHorarioPopularCombo`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspHorarioPopularCombo`(
)

BEGIN
        
	SELECT
        DATE_FORMAT(h.hora, '%H:%i')		as 'descricao'
	FROM 
		horarios_agendamento h
	WHERE
		IFNULL( h.ativo, 0 ) = 1
	ORDER BY
		h.id_horario_agendamento;

END $$

DELIMITER ;