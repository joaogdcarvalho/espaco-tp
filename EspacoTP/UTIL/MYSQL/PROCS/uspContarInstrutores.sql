USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspContarInstrutores`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspContarInstrutores`(
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
	AND 	TABLE_NAME = 'instrutores';
        
	   
    SELECT varNumCount AS `indice_instrutores`;
	
END $$

DELIMITER ;