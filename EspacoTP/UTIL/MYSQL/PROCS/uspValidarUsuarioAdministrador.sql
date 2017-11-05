USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspValidarUsuarioAdministrador`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspValidarUsuarioAdministrador`(
IN pStrUsuario VARCHAR(20),
IN pStrSenha	VARCHAR(8)
)

BEGIN

	DECLARE varNumCount INT DEFAULT 0;
    DECLARE varBooUsuarioAdministrador TINYINT DEFAULT 0;
        
	SELECT
		COUNT(t.id_tipo_usuario)
	INTO
        varNumCount
	FROM 
		usuarios u
        JOIN	tipos_usuario t
		ON		t.id_tipo_usuario = u.id_tipo_usuario
	WHERE
		IFNULL( u.ativo, 0 ) = 1
	AND	( u.usuario LIKE BINARY pStrUsuario )
	AND	( u.senha LIKE BINARY pStrSenha )
    AND IFNULL( t.administrador, 0 ) = 1;

	
	IF (IFNULL( varNumCount, 0 ) > 0 )
	THEN SET varBooUsuarioAdministrador = 1;
    END IF;
    
    SELECT varBooUsuarioAdministrador AS `usuario_administrador`;
	
END $$

DELIMITER ;