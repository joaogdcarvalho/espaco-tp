USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspInstrutoresAlterar`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspInstrutoresAlterar`(
IN pNumIdInstrutor INT(11),
IN pStrNome VARCHAR(20),
IN pStrSobrenome VARCHAR(20),
IN pStrCpf VARCHAR(11),
IN pBooAtivo TINYINT(1)
)

BEGIN
        
	UPDATE	instrutores
    SET
		nome = pStrNome,
		sobrenome = pStrSobrenome,
		cpf = pStrCpf,
		ativo = pBooAtivo
    WHERE
		id_instrutor = pNumIdInstrutor;

END $$

DELIMITER ;