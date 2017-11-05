USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspUsuariosAlterar`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspUsuariosAlterar`(
IN pNumIdUsuario INT(11),
IN pStrNome VARCHAR(40),
IN pStrUsuario VARCHAR(20),
IN pStrSenha VARCHAR(8),
IN pNumTipoUsuario INT(1),
IN pBooAtivo TINYINT(1)
)

BEGIN
        
	UPDATE	usuarios
    SET
		nome = pStrNome,
		usuario = pStrUsuario,
		senha = pStrSenha,
		id_tipo_usuario = pNumTipoUsuario,
		ativo = pBooAtivo
    WHERE
		id_usuario = pNumIdUsuario;

END $$

DELIMITER ;