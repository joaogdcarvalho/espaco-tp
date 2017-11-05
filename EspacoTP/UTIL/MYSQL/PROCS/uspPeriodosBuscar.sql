USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspPeriodosBuscar`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspPeriodosBuscar`(
IN pNumIdAluno INT(11)
)

BEGIN
        
	SELECT
        p.id_dia_agendamento		as 'id_dia_agendamento',
        d.dia						as 'dia',
        p.id_horario_agendamento 	as 'id_horario_agendamento',
        h.hora						as 'hora'
	FROM 
		periodos p
        
        JOIN	alunos a
        ON		a.id_aluno = p.id_aluno
        
        JOIN	dias_agendamento d
        ON		d.id_dia_agendamento = p.id_dia_agendamento
        
        JOIN	horarios_agendamento h
        ON		h.id_horario_agendamento = p.id_horario_agendamento
	WHERE
		p.id_aluno = pNumIdAluno;

END $$

DELIMITER ;