USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspUsuariosBuscar`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspUsuariosBuscar`(
)

BEGIN
        
	SELECT
		u.id_usuario	as 'id',
        u.nome			as 'nome',
		u.usuario		as 'usuario',
        u.senha			as 'senha',
        t.administrador	as 'admin',
        u.ativo			as 'ativo'
	FROM 
		usuarios u        
		JOIN	tipos_usuario t
		ON		t.id_tipo_usuario = u.id_tipo_usuario
	ORDER BY
		u.id_usuario;

END $$

DELIMITER ;