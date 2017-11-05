USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspSituacoesCreditoPopularCombo`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspSituacoesCreditoPopularCombo`(
)

BEGIN
        
	SELECT
        s.descricao		as 'descricao'
	FROM 
		situacoes_credito s
	WHERE
		IFNULL( s.ativo, 0 ) = 1
	ORDER BY
		s.id_situacao_credito;

END $$

DELIMITER ;