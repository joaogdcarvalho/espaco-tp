USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspInstrutoresIncluir`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspInstrutoresIncluir`(
IN pStrNome VARCHAR(20),
IN pStrSobrenome VARCHAR(20),
IN pStrCpf VARCHAR(11),
IN pBooAtivo TINYINT(1)
)

BEGIN
        
	INSERT INTO	instrutores
    (
		nome,
		sobrenome,
		cpf,
		ativo
    )
    VALUES
    (
		pStrNome,
		pStrSobrenome,
		pStrCpf,
		pBooAtivo
    );

END $$

DELIMITER ;