USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspPeriodosExcluir`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspPeriodosExcluir`(
IN pNumIdPeriodo INT(11)
)

BEGIN
        
	DELETE FROM
		periodos
    WHERE
		id_periodo = pNumIdPeriodo;

END $$

DELIMITER ;