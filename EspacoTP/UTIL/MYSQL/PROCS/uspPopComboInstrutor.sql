USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspPopComboInstrutor`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspPopComboInstrutor`(
)

BEGIN
        
	SELECT
        CONCAT(i.nome," ",i.sobrenome)		as 'descricao'
	FROM 
		instrutores i
	WHERE
		IFNULL( i.ativo, 0 ) = 1
	ORDER BY
		i.id_instrutor;

END $$

DELIMITER ;