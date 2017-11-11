-- proc para inclusão de agendamentos automático, após adição de plano de aula de aula
USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspAgendamentoFlexivelContrato`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspAgendamentoFlexivelContrato`(
IN pNumIdAluno INT(11),
/*IN pDtDataInicioContrato DATE,*/
IN pDtDataTerminoContrato DATE,
IN pDtDataTerminoContratoAnterior DATE
/*IN pNumIdDiaAgendamento INT(1),
IN pNumIdHorarioAgendamento INT(1),
IN pBooAtivo TINYINT(1)*/
)

BEGIN
DECLARE varQuantidadeDiasDif INT;
DECLARE varContador INT;
DECLARE varIdDiaAgendamento INT;
DECLARE varIdHorarioAgendamento INT;

	SELECT DATEDIFF(pDtDataTerminoContrato, pDtDataTerminoContratoAnterior) INTO varQuantidadeDiasDif;
    
    IF ( varQuantidadeDiasDif > 0)
    THEN
    
		-- CRIA TABELA TEMPORÁRIA COM OS PLANOS VÁLIDOS
		DROP TEMPORARY TABLE IF EXISTS `periodos_validos`;
		CREATE TEMPORARY TABLE `periodos_validos` (
		`id_periodos_validos` INT(11) NOT NULL AUTO_INCREMENT,
		`id_dia_agendamento` INT(1) NOT NULL,
		`id_horario_agendamento` INT(2) NOT NULL,
		PRIMARY KEY (`id_periodos_validos`)
		)  AUTO_INCREMENT=1;
		
		-- VERIFICAR PLANOS ATIVOS DO ALUNO E INSERE NA TABELA TEMPORÁRIA
		INSERT INTO periodos_validos
		(
			id_dia_agendamento,
			id_horario_agendamento
		)
		SELECT
			p.id_dia_agendamento,
			p.id_horario_agendamento
		FROM
			periodos p
		WHERE
			p.id_aluno = pNumIdAluno
		AND p.ativo = 1;
		
		-- INSERIR REGISTROS DE AGENDAMENTO COM BASE NOS INDICES DOS DIAS DESTES PLANOS E SEU HORÁRIO ENTRE A DATA TERMINO ANTERIOR E ATUAL
		SET varContador = 1;
		WHILE EXISTS(SELECT 1 FROM periodos_validos pv WHERE pv.id_periodos_validos = varContador) DO
		
			SELECT
				pv.id_dia_agendamento,
				pv.id_horario_agendamento
			INTO
				varIdDiaAgendamento,
				varIdHorarioAgendamento
			FROM
				periodos_validos pv
			WHERE
				pv.id_periodos_validos = varContador;
				
			INSERT INTO	agendamentos
			(
				id_aluno,
				data_agendamento,
				id_horario_agendamento,
				ativo
			)
			SELECT
				pNumIdAluno					as 'id_aluno',
				c.data						as 'data',
				varIdHorarioAgendamento		as 'id_horario',
				1							as 'ativo'
			FROM
					calendario c
			WHERE	c.data BETWEEN DATE_FORMAT(pDtDataTerminoContratoAnterior, '%Y-%m-%d') AND DATE_FORMAT(pDtDataTerminoContrato, '%Y-%m-%d')
			AND		DATE_FORMAT(c.data,'%w') = varIdDiaAgendamento;
			
			
			DELETE FROM periodos_validos
			WHERE id_periodos_validos = varContador;
			
			SET varContador = varContador + 1;
		
		END WHILE;
    
    END IF;
    
    IF ( varQuantidadeDiasDif <= 0)
    THEN
    
		-- CRIA TABELA TEMPORÁRIA COM OS PLANOS VÁLIDOS
		DROP TEMPORARY TABLE IF EXISTS `periodos_validos`;
		CREATE TEMPORARY TABLE `periodos_validos` (
		`id_periodos_validos` INT(11) NOT NULL AUTO_INCREMENT,
		`id_dia_agendamento` INT(1) NOT NULL,
		`id_horario_agendamento` INT(2) NOT NULL,
		PRIMARY KEY (`id_periodos_validos`)
		)  AUTO_INCREMENT=1;
        
        -- VERIFICAR PLANOS ATIVOS DO ALUNO E INSERE NA TABELA TEMPORÁRIA
		INSERT INTO periodos_validos
		(
			id_dia_agendamento,
			id_horario_agendamento
		)
		SELECT
			p.id_dia_agendamento,
			p.id_horario_agendamento
		FROM
			periodos p
		WHERE
			p.id_aluno = pNumIdAluno;
		-- AND p.ativo = 1;
        
        
        -- INSERIR REGISTROS DE AGENDAMENTO COM BASE NOS INDICES DOS DIAS DESTES PLANOS E SEU HORÁRIO ENTRE A DATA TERMINO ANTERIOR E ATUAL
		SET varContador = 1;
		WHILE EXISTS(SELECT 1 FROM periodos_validos pv WHERE pv.id_periodos_validos = varContador) DO
        
			SELECT
				pv.id_dia_agendamento,
				pv.id_horario_agendamento
			INTO
				varIdDiaAgendamento,
				varIdHorarioAgendamento
			FROM
				periodos_validos pv
			WHERE
				pv.id_periodos_validos = varContador;
				
			UPDATE
				agendamentos 
			SET
				ativo = 0
			WHERE
				id_aluno = pNumIdAluno
			AND	data_agendamento IN	(	
									SELECT	c.data
									FROM	calendario c
									WHERE	c.data BETWEEN DATE_FORMAT(pDtDataTerminoContrato, '%Y-%m-%d') AND DATE_FORMAT(pDtDataTerminoContratoAnterior, '%Y-%m-%d')
									AND		DATE_FORMAT(c.data,'%w') = varIdDiaAgendamento	
									)
			AND id_horario_agendamento = varIdDiaAgendamento;
    
			DELETE FROM periodos_validos
			WHERE id_periodos_validos = varContador;
			
			SET varContador = varContador + 1;
    
		END WHILE;
    
    END IF;
    
END $$

DELIMITER ;