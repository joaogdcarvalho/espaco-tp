USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspAlunosBuscar`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspAlunosBuscar`(
IN pNumIdAluno VARCHAR(11),
IN pStrNome VARCHAR(20),
IN pStrSobrenome VARCHAR(20),
IN pStrCpf VARCHAR(11),
IN pDtDataInicioContrato DATE,
IN pDtDataTerminoContrato DATE
/*ALUNO ATIVO = INICIO CONTRATO COM DATA ANTERIOR OU IGUAL A DATA DE HOJE E TERMINO CONTRATO COM DATA POSTERIOR OU IGUAL A DATA DE HOJE */
)

BEGIN

	DECLARE varStrWhere TEXT DEFAULT "";

	IF (IFNULL( LENGTH(pNumIdAluno), 0 ) > 0 )
    
	THEN SET varStrWhere = CONCAT( varStrWhere, "AND a.id_aluno = ", pNumIdAluno );
    
    ELSE
    
		IF (IFNULL( LENGTH(pStrNome), 0 ) > 0 )
		THEN SET varStrWhere = CONCAT( varStrWhere, "AND a.nome LIKE '%", pStrNome, "%'" );
		END IF;
        
        IF (IFNULL( LENGTH(pStrSobrenome), 0 ) > 0 )
		THEN SET varStrWhere = CONCAT( varStrWhere, "AND a.sobrenome LIKE '%", pStrSobrenome, "%'" );
		END IF;
    
		IF (IFNULL( LENGTH(pStrCpf), 0 ) > 0 )
		THEN SET varStrWhere = CONCAT( varStrWhere, "AND a.cpf = ", pStrCpf );
		END IF;
        
        /*
        IF (IFNULL( LENGTH(pDtDataInicioContrato), 0 ) > 0 )
		THEN SET varStrWhere = CONCAT( varStrWhere, " AND a.data_inicio_contrato >= '",  pDtDataInicioContrato, "'" );
		END IF;
    
		IF (IFNULL( LENGTH(pDtDataTerminoContrato), 0 ) > 0 )
		THEN SET varStrWhere = CONCAT( varStrWhere, " AND a.data_termino_contrato <= '", pDtDataTerminoContrato, "'" );
		END IF;
        */
    END IF;
    
    SET @QUERY = CONCAT("    
	
	SELECT
		a.id_aluno							as 'id',
		a.nome 								as 'nome',
		a.sobrenome 						as 'sobrenome',
        a.cpf 								as 'cpf',
        t.descricao 						as 'tipo_telefone',
        
        a.numero_telefone 					as 'numero_telefone',
        a.email 							as 'email',
        a.data_inicio_contrato 				as 'data_inicio_contrato',
        a.data_termino_contrato 			as 'data_termino_contrato',
        a.cep								as 'cep',
        
        a.logradouro 						as 'logradouro',
        a.numero_residencial				as 'numero_residencial',
        a.bairro 							as 'bairro',
        a.estado 							as 'estado',
        a.municipio 						as 'municipio',
        
        a.valor_aula 						as 'valor_aula'
	FROM 
		alunos a
        
        JOIN	tipos_telefone t
        ON		t.id_tipo_telefone = a.id_tipo_telefone)
        
	WHERE
		1 = 1
		", "" );
        
PREPARE stmt FROM @QUERY;
EXECUTE stmt;
DEALLOCATE PREPARE stmt;
		
END $$

DELIMITER ;