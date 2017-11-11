-- proc para alteração de agendamentos automático, após alteração de plano de aula de aula
USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspAgendamentoFlexivelAlterar`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspAgendamentoFlexivelAlterar`(
IN pNumIdAluno INT(11),
IN pDtDataTerminoContrato DATE,
IN pNumIdDiaAgendamento INT(1),
IN pNumIdHorarioAgendamento INT(1),
IN pBooAtivo TINYINT(1)
)

BEGIN       
    
    UPDATE
		agendamentos 
	SET
		ativo = pBooAtivo
	WHERE
		id_aluno = pNumIdAluno
	AND	data_agendamento IN	(	
								SELECT	c.data
								FROM	calendario c
								WHERE	c.data BETWEEN DATE_FORMAT(now(), '%Y-%m-%d') AND DATE_FORMAT(pDtDataTerminoContrato, '%Y-%m-%d')
								AND		DATE_FORMAT(c.data,'%w') = pNumIdDiaAgendamento	
							)
	AND id_horario_agendamento = pNumIdHorarioAgendamento;
    
END $$

DELIMITER ;