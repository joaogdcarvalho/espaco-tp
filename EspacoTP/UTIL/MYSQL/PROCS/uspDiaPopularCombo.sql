USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspDiaPopularCombo`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspDiaPopularCombo`(
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