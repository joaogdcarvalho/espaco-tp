USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspValidarLogin`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspValidarLogin`(
IN pStrUsuario VARCHAR(20),
IN pStrSenha	VARCHAR(8)
)

BEGIN

	DECLARE varNumCount INT DEFAULT 0;
    DECLARE varBooPermitirLogin TINYINT DEFAULT 0;
        
	SELECT
		COUNT(id_usuario)
	INTO
        varNumCount
	FROM 
		usuarios u
	WHERE
		IFNULL( u.ativo, 0 ) = 1
	AND	( u.usuario LIKE BINARY pStrUsuario )
	AND	( u.senha LIKE BINARY pStrSenha );

	
	IF (IFNULL( varNumCount, 0 ) > 0 )
	THEN SET varBooPermitirLogin = 1;
    END IF;
    
    SELECT varBooPermitirLogin AS `permitir_login`;
	
END $$

DELIMITER ;