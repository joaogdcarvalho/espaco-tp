USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspValidarUsuarioExistente`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspValidarUsuarioExistente`(
IN pStrUsuario VARCHAR(20)
)

BEGIN

	DECLARE varNumCount INT DEFAULT 0;
    DECLARE varBooUsuarioExistente TINYINT DEFAULT 0;
        
	SELECT
		COUNT(u.usuario)
	INTO
        varNumCount
	FROM 
		usuarios u
	WHERE ( u.usuario LIKE BINARY pStrUsuario );

	IF (IFNULL( varNumCount, 0 ) > 0 )
	THEN SET varBooUsuarioExistente = 1;
    END IF;
    
    SELECT varBooUsuarioExistente AS `usuario_existente`;
	
END $$

DELIMITER ;