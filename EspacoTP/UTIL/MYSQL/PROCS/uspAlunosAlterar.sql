USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspAlunosAlterar`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspAlunosAlterar`(
IN pNumIdAluno INT(11),
IN pStrNome VARCHAR(20),
IN pStrSobrenome VARCHAR(20),
IN pStrCpf VARCHAR(11),
IN pNumIdTipoTelefone INT(1),
IN pStrNumeroTelefone VARCHAR(15),
IN pStrEmail VARCHAR(60),
IN pDtDataInicioContrato DATE,
IN pDtDataTerminoContrato DATE,
IN pNumCep VARCHAR(9),
IN pStrLogradouro VARCHAR(120),
IN pNumNumero INT(6),
IN pStrBairro VARCHAR(30),
IN pStrEstado VARCHAR(2),
IN pStrMunicipio VARCHAR(30),
IN pMoeValorAula DECIMAL(9, 2)
)

BEGIN
DECLARE varDataTerminoContratoAnterior DATE;

	SELECT
		data_termino_contrato
	INTO
		varDataTerminoContratoAnterior
	FROM
		alunos
	WHERE
		id_aluno = pNumIdAluno;        
        
	UPDATE alunos
    SET
		nome = pStrNome,
		sobrenome = pStrSobrenome,
        cpf = pStrCpf,
        id_tipo_telefone = pNumIdTipoTelefone,
        numero_telefone = pStrNumeroTelefone,
        
        email = pStrEmail,
        data_inicio_contrato = pDtDataInicioContrato,
        data_termino_contrato = pDtDataTerminoContrato,
        data_termino_contrato_anterior = varDataTerminoContratoAnterior,
        cep = pNumCep,
        logradouro = pStrLogradouro,
        
        numero_residencial = pNumNumero,
        bairro = pStrBairro,
        estado = pStrEstado,
        municipio = pStrMunicipio,
        valor_aula = pMoeValorAula
	WHERE
		id_aluno = pNumIdAluno;
		
END $$

DELIMITER ;