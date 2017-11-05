USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspContarAlunos`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspContarAlunos`(
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
	AND   TABLE_NAME   = 'alunos';
    
    SELECT varNumCount AS `indice_alunos`;
	
END $$

DELIMITER ;