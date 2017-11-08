USE `espaco_tp`;
DROP PROCEDURE IF EXISTS `uspAgendamentosBuscar`;

USE `espaco_tp`;
DELIMITER $$

CREATE PROCEDURE `uspAgendamentosBuscar`(
IN pDtDataAgendamento DATE,
IN pNumIdHorarioAgendamento INT(11)
)

BEGIN
        
	SELECT
		ag.id_agendamento	as	'id_agendamento',
		a.id_aluno			as	'id_aluno',
        a.nome				as	'nome_aluno',
        a.sobrenome			as	'sobrenome_aluno',
		i.id_instrutor		as	'id_instrutor',
		i.nome				as 	'nome_instrutor',
        ag.ativo            as 	'aula_agendada'
	FROM 
		agendamentos ag
        
        JOIN	alunos a
        ON		a.id_aluno = ag.id_aluno
        
        LEFT JOIN	instrutores i
        ON		i.id_instrutor = ag.id_instrutor
        
        JOIN	horarios_agendamento h
        ON		h.id_horario_agendamento = ag.id_horario_agendamento
	WHERE
		ag.data_agendamento = pDtDataAgendamento
	AND	ag.id_horario_agendamento = pNumIdHorarioAgendamento;

END $$

DELIMITER ;