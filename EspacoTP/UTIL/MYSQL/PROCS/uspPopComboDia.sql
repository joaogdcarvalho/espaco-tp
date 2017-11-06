USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspPopComboDia`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspPopComboDia`(
)

BEGIN
        
	SELECT
        d.dia		as 'descricao'
	FROM 
		dias_agendamento d
	WHERE
		IFNULL( d.ativo, 0 ) = 1
	ORDER BY
		d.id_dia_agendamento;

END $$

DELIMITER ;