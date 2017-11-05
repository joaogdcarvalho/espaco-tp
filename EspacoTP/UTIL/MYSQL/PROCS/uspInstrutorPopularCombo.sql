USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspInstrutorPopularCombo`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspInstrutorPopularCombo`(
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