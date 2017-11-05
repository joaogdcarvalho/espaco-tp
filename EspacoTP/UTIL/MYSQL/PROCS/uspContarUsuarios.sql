USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspContarUsuarios`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspContarUsuarios`(
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
	AND 	TABLE_NAME = 'usuarios';
        
	   
    SELECT varNumCount AS `indice_usuarios`;
	
END $$

DELIMITER ;