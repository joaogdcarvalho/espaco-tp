USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspUsuariosIncluir`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspUsuariosIncluir`(
IN pStrNome VARCHAR(40),
IN pStrUsuario VARCHAR(20),
IN pStrSenha VARCHAR(8),
IN pNumTipoUsuario INT(1),
IN pBooAtivo TINYINT(1)
)

BEGIN
        
	INSERT INTO	usuarios
    (
		nome,
		usuario,
		senha,
		id_tipo_usuario,
		ativo
    )
    VALUES
    (
		pStrNome,
		pStrUsuario,
		pStrSenha,
		pNumTipoUsuario,
		pBooAtivo
    );

END $$

DELIMITER ;