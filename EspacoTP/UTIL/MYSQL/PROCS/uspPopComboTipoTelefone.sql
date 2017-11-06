USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspPopComboTipoTelefone`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspPopComboTipoTelefone`(
)

BEGIN
        
	SELECT
        t.descricao		as 'descricao'
	FROM 
		tipos_telefone t
	WHERE
		IFNULL( t.ativo, 0 ) = 1
	ORDER BY
		t.id_tipo_telefone;

END $$

DELIMITER ;