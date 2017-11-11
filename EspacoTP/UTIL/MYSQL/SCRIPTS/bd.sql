-- criacao de novo banco de dados - espaco tp
CREATE DATABASE IF NOT EXISTS `espaco_tp` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;

-- utilizacao do banco de dados - espaco tp
USE `espaco_tp`;

-- criar script de versão, sem tela: CELULAR / FIXO / OUTRO   
DROP TABLE IF EXISTS `tipos_telefone`;
CREATE TABLE `tipos_telefone` (
    `id_tipo_telefone` INT(1) NOT NULL AUTO_INCREMENT,
    `descricao` VARCHAR(10) NOT NULL,
    `ativo` TINYINT(1) NOT NULL,
    PRIMARY KEY (`id_tipo_telefone`)
)  AUTO_INCREMENT=1 ENGINE=INNODB
	;
    
-- criar script de versão, sem tela: DOMINGO / SEGUNDA-FEIRA / TERÇA-FEIRA / QUARTA-FEIRA / QUINTA-FEIRA / SEXTA-FEIRA / SÁBADO    
DROP TABLE IF EXISTS `dias_agendamento`;
CREATE TABLE `dias_agendamento` (
    `id_dia_agendamento` INT(1) NOT NULL AUTO_INCREMENT,
    `dia` VARCHAR(13) NOT NULL,
    `ativo` TINYINT(1) NOT NULL,
    PRIMARY KEY (`id_dia_agendamento`)
)  AUTO_INCREMENT=1 ENGINE=INNODB
	;
    
-- criar script de versão, sem tela: 07:00 até 20:00    
DROP TABLE IF EXISTS `horarios_agendamento`;
CREATE TABLE `horarios_agendamento` (
    `id_horario_agendamento` INT(2) NOT NULL AUTO_INCREMENT,
    `hora` TIME NOT NULL,
    `ativo` TINYINT(1) NOT NULL,
    PRIMARY KEY (`id_horario_agendamento`)
)  AUTO_INCREMENT=1 ENGINE=INNODB
	;

-- criar script de versão, sem tela: ADMINISTRADOR / PADRÃO
DROP TABLE IF EXISTS `tipos_usuario`;
CREATE TABLE `tipos_usuario` (
    `id_tipo_usuario` INT(1) NOT NULL AUTO_INCREMENT,
    `descricao` VARCHAR(30) NOT NULL,
    `administrador` TINYINT(1) NOT NULL,
    PRIMARY KEY (`id_tipo_usuario`)
)  AUTO_INCREMENT=1 ENGINE=INNODB
	;
	
-- criar script de versão, com tela: USUÁRIO ADMIN
DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE `usuarios` (
    `id_usuario` INT(11) NOT NULL AUTO_INCREMENT,
    `nome` VARCHAR(40) NOT NULL,
    `usuario` VARCHAR(20) NOT NULL,
    `senha` VARCHAR(8) NOT NULL,
    `id_tipo_usuario` INT(1) NOT NULL,
    `ativo` TINYINT(1) NOT NULL,
    PRIMARY KEY (`id_usuario`)
)  AUTO_INCREMENT=1 ENGINE=INNODB
	;
	
ALTER TABLE `usuarios`
ADD CONSTRAINT `usuarios_tiposusuario_FK` FOREIGN KEY (`id_tipo_usuario`) REFERENCES `tipos_usuario` (`id_tipo_usuario`);

DROP TABLE IF EXISTS `instrutores`;
CREATE TABLE `instrutores` (
    `id_instrutor` INT(11) NOT NULL AUTO_INCREMENT,
    `nome` VARCHAR(20) NOT NULL,
    `sobrenome` VARCHAR(20) NOT NULL,
    `cpf` VARCHAR(11) NOT NULL,
    `ativo` TINYINT(1) NOT NULL,
    PRIMARY KEY (`id_instrutor`)
)  AUTO_INCREMENT=1 ENGINE=INNODB
	;        
  
DROP TABLE IF EXISTS `alunos`;
CREATE TABLE `alunos` (
    `id_aluno` INT(11) NOT NULL AUTO_INCREMENT,
    `nome` VARCHAR(20) NOT NULL,
    `sobrenome` VARCHAR(20) NOT NULL,
    `cpf` VARCHAR(11) NOT NULL,
    `id_tipo_telefone` INT(1) NOT NULL,
    `numero_telefone` VARCHAR(15) NULL,
    `email` VARCHAR(60) NULL,
    `data_inicio_contrato` DATE NOT NULL,
    `data_termino_contrato` DATE NOT NULL,
    `data_termino_contrato_anterior` DATE NULL,
    `cep` VARCHAR(9) NULL,
    `logradouro` VARCHAR(120) NULL,
    `numero_residencial` INT(6) NULL,
    `bairro` VARCHAR(30) NULL,
    `estado` VARCHAR(2) NULL,
    `municipio` VARCHAR(30) NULL,
    `valor_aula` DECIMAL(9 , 2 ) NOT NULL,
    PRIMARY KEY (`id_aluno`)
)  AUTO_INCREMENT=1 ENGINE=INNODB
	;
	
ALTER TABLE `alunos`
ADD CONSTRAINT `alunos_tipostelefone_FK` FOREIGN KEY (`id_tipo_telefone`) REFERENCES `tipos_telefone` (`id_tipo_telefone`);	

DROP TABLE IF EXISTS `periodos`;
CREATE TABLE `periodos` (
	`id_periodo` INT(11) NOT NULL AUTO_INCREMENT,
    `id_aluno` INT(11) NOT NULL,
    `id_dia_agendamento` INT(1) NOT NULL,
    `id_horario_agendamento` INT(2) NOT NULL,
    `ativo` TINYINT(1) NOT NULL,
    PRIMARY KEY (`id_periodo`)
)  AUTO_INCREMENT=1 ENGINE=INNODB
	;
    
ALTER TABLE `periodos`
ADD CONSTRAINT `periodos_alunos_FK` FOREIGN KEY (`id_aluno`) REFERENCES `alunos` (`id_aluno`),
ADD CONSTRAINT `periodos_diasagendamento_FK` FOREIGN KEY (`id_dia_agendamento`) REFERENCES `dias_agendamento` (`id_dia_agendamento`),
ADD CONSTRAINT `periodos_horariosagendamento_FK` FOREIGN KEY (`id_horario_agendamento`) REFERENCES `horarios_agendamento` (`id_horario_agendamento`);

DROP TABLE IF EXISTS `agendamentos`;
CREATE TABLE `agendamentos` (
    `id_agendamento` INT(11) NOT NULL AUTO_INCREMENT,
    `id_instrutor` INT(11) NULL,
    `id_aluno` INT(11) NOT NULL,    
    `data_agendamento` DATE NOT NULL,
    `id_horario_agendamento` INT(2) NOT NULL,
    `ativo` TINYINT(1) NOT NULL,
    PRIMARY KEY (`id_agendamento`)
)  AUTO_INCREMENT=1 ENGINE=INNODB
	;

/*
ALTER TABLE `agendamentos`
ADD CONSTRAINT `agendamentos_instrutores_FK` FOREIGN KEY (`id_instrutor`) REFERENCES `instrutores` (`id_instrutor`),
ADD CONSTRAINT `agendamentos_alunos_FK` FOREIGN KEY (`id_aluno`) REFERENCES `alunos` (`id_aluno`),
ADD CONSTRAINT `agendamentos_horaagendamento_FK` FOREIGN KEY (`id_horario_agendamento`) REFERENCES `hora_agendamento` (`id_horario_agendamento`);
*/

/*
tabela que armazenará manipulação de dados na agenda, no processo de inclusão ou alteração de dados nas tabelas de 'agendamento' ou 'restricoes',
será disparada uma trigger que realizará um inserção na tabela de eventos, desta maneira será possível rastrear todas as modificações de informações
em uma célula (dia/horário) da tela, sabendo que foi o instrutor que alterou e quando ele realizou esta ação.
será necessário fazer 'left join' com as tabelas de 'agendamento' ou 'restrição' para busca do que foi alterado
*/

DROP TABLE IF EXISTS `eventos`;
CREATE TABLE `eventos` (
    `id_evento` INT(11) NOT NULL AUTO_INCREMENT,
    `id_agendamento` INT(11) NULL,
    `valor_anterior` TINYINT(1) NULL,
    `valor_atual` TINYINT(1) NULL,
	`id_usuario` INT(11) NOT NULL,
    `log_geracao` TIMESTAMP NOT NULL,
    PRIMARY KEY (`id_evento`)
)  AUTO_INCREMENT=1 ENGINE=INNODB
	;

ALTER TABLE `eventos`
ADD CONSTRAINT `eventos_agendamentos_FK` FOREIGN KEY (`id_agendamento`) REFERENCES `agendamentos` (`id_agendamento`),
ADD CONSTRAINT `eventos_usuarios_FK` FOREIGN KEY (`id_usuario`) REFERENCES `usuarios` (`id_usuario`);


DROP TABLE IF EXISTS `calendario`;
CREATE TABLE `calendario` (
    `data` DATE NOT NULL,
    PRIMARY KEY (`data`)
)  ENGINE=INNODB
	;