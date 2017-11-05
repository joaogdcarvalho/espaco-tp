USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspContarAgendamentos`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspContarAgendamentos`(
)

BEGIN

	DECLARE varNumCount INT DEFAULT 0;
    
    SELECT 
		`AUTO_INCREMENT`
	INTO
        varNumCount
	FROM
		INFORMATION_SCHEMA.TABLES
	WHERE
		TABLE_SCHEMA = DATABASE()
	AND   TABLE_NAME   = 'agendamentos';
        
	   
    SELECT varNumCount AS `indice_agendamentos`;
	
END $$

DELIMITER ;