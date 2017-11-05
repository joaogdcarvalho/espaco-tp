USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspAlunosIncluir`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspAlunosIncluir`(
IN pStrNome VARCHAR(20),
IN pStrSobrenome VARCHAR(20),
IN pStrCpf VARCHAR(11),
IN pNumIdTipoTelefone INT(1),
IN pStrNumeroTelefone VARCHAR(15),
IN pStrEmail VARCHAR(60),
IN pDtDataInicioContrato DATE,
IN pDtDataTerminoContrato DATE,
IN pNumCep INT(8),
IN pStrLogradouro VARCHAR(120),
IN pNumNumero INT(6),
IN pStrBairro VARCHAR(30),
IN pStrEstado VARCHAR(2),
IN pStrMunicipio VARCHAR(30),
IN pMoeValorAula DECIMAL(9, 2)
)

BEGIN
        
	INSERT INTO alunos
    (
		nome,
		sobrenome,
        cpf,
        id_tipo_telefone,
        numero_telefone,
        
        email,
        data_inicio_contrato,
        data_termino_contrato,
        cep,
        logradouro,
        
        numero_residencial,
        bairro,
        estado,
        municipio,
        valor_aula
	)
    VALUES
    (
		pStrNome,
		pStrSobrenome,
        pStrCpf,
        pNumIdTipoTelefone,
        pStrNumeroTelefone,
        
        pStrEmail,
        pDtDataInicioContrato,
        pDtDataTerminoContrato,
        pNumCep,
        pStrLogradouro,
        
        pNumNumero,
        pStrBairro,
        pStrEstado,
        pStrMunicipio,
        pMoeValorAula
    );
		
END $$

DELIMITER ;