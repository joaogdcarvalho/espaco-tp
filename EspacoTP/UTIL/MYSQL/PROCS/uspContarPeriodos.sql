USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspContarPeriodos`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspContarPeriodos`(
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
	AND   TABLE_NAME   = 'periodos';
        
	   
    SELECT varNumCount AS `indice_periodos`;
	
END $$

DELIMITER ;