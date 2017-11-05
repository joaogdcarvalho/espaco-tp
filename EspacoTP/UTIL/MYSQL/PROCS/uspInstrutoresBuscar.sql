USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspInstrutoresBuscar`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspInstrutoresBuscar`(
)

BEGIN
        
	SELECT
		i.id_instrutor	as 'id',
        i.nome			as 'nome',
        i.sobrenome		as 'sobrenome',
        i.cpf			as 'cpf',
		i.ativo			as 'ativo'
	FROM 
		instrutores i;

END $$

DELIMITER ;