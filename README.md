# ESPAÇO TP

## Sobre o Projeto

O “Espaço TP” é um sistema de gestão de espaços para atividades físicas desenvolvido como Trabalho de Conclusão de Curso (TCC) de Análise e Desenvolvimento de Sistemas pela Faculdade Impacta Tecnologia. Visa fornecer uma solução abrangente para a administração de espaços destinados a atividades físicas, como academias e estúdios de pilates, oferecendo funcionalidades para gerenciar alunos, instrutores, agendamentos, períodos de atividades, entre outras.

## Estrutura do Projeto

O projeto está estruturado da seguinte maneira:

```
EspacoTP/
|-- .vs/
|-- EspacoTP/
|   |-- bin/
|   |-- BLL/
|   |-- DAL/
|   |-- MODEL/
|   |-- obj/
|   |-- Properties/
|   |-- UTIL/
|-- packages/
|-- README.md
|-- EspacoTP.sln
```

## Descrição dos Diretórios

- **.vs**: Diretório relacionado ao ambiente de desenvolvimento.
- **EspacoTP**: Diretório principal do projeto.
  - **bin**: Contém os arquivos binários compilados.
  - **BLL**: Camada de negócio, onde estão as classes responsáveis pela lógica de negócio.
  - **DAL**: Camada de acesso a dados, com as classes para interação com o banco de dados.
  - **MODEL**: Classes que representam o modelo de dados do sistema.
  - **UTIL**: Diretório de utilidades.
  	- **MYSQL**: Diretório específico para scripts e procedimentos relacionados ao MySQL.
  		- **PROCS**: Diretório que contém os procedimentos armazenados do banco de dados.
  		- **SCRIPTS**: Diretório que contém os scripts SQL para criação e manipulação do banco de dados.
- **packages**: Pasta que armazena os pacotes de terceiros utilizados no projeto.
- **EspacoTP.sln**: Arquivo de solução do Visual Studio para o projeto.

Outros arquivos relacionados à interface do usuário e configurações do projeto.

## Recursos e Funcionalidades

- **Gestão de Alunos e Instrutores**: Cadastro, consulta e atualização de informações de alunos e instrutores.
- **Agendamento de Atividades**: Agendamento de horários para atividades físicas, permitindo a reserva de espaços e a definição de instrutores.
- **Controle de Pagamentos e Contratos**: Gerenciamento de pagamentos de mensalidades e contratos dos alunos.
- **Recursos Avançados de Banco de Dados**: Utilização de scripts SQL para criação e manipulação de tabelas, procedimentos e eventos no banco de dados.

## Tecnologias Utilizadas

- **Linguagem**: C#
- **Banco de Dados**: MySQL
- **Frameworks e Bibliotecas**: Correios-Api, MySql.Data

## Estrutura do Banco de Dados

O banco de dados `espaco_tp` é criado e manipulado por meio de scripts SQL disponibilizados na pasta `UTIL/MYSQL/SCRIPTS`.

### Entidades

- `tipos_telefone`: Tipos de telefone disponíveis.
- `dias_agendamento`: Dias disponíveis para agendamento.
- `horarios_agendamento`: Horários disponíveis para agendamento.
- `tipos_usuario`: Tipos de usuários do sistema.
- `usuarios`: Usuários do sistema, incluindo administradores.
- `instrutores`: Cadastro de instrutores.
- `alunos`: Cadastro de alunos.
- `periodos`: Períodos de atividades dos alunos.
- `agendamentos`: Agendamentos realizados.
- `eventos`: Registros de eventos relacionados às alterações nos agendamentos.

### Procedures

#### Agendamentos
- `uspAgendamentoFlexivelAlterar.sql`
- `uspAgendamentoFlexivelContrato.sql`
- `uspAgendamentoFlexivelIncluir.sql`
- `uspAgendamentosAlterar.sql`
- `uspAgendamentosBuscar.sql`
- `uspAgendamentosIncluir.sql`

#### Alunos
- `uspAlunosAlterar.sql`
- `uspAlunosBuscar.sql`
- `uspAlunosDetalhar.sql`
- `uspAlunosIncluir.sql`

#### Contagem
- `uspContarAgendamentos.sql`
- `uspContarAlunos.sql`
- `uspContarAlunosTurma.sql`
- `uspContarInstrutores.sql`
- `uspContarPeriodos.sql`
- `uspContarUsuarios.sql`

#### Instrutores
- `uspInstrutoresAlterar.sql`
- `uspInstrutoresBuscar.sql`
- `uspInstrutoresIncluir.sql`

#### Períodos
- `uspPeriodosAlterar.sql`
- `uspPeriodosBuscar.sql`
- `uspPeriodosExcluir.sql`
- `uspPeriodosIncluir.sql`

#### Preenchimento de combobox
- `uspPopComboDia.sql`
- `uspPopComboHorario.sql`
- `uspPopComboInstrutor.sql`
- `uspPopComboSituacoesCredito.sql`
- `uspPopComboTipoTelefone.sql`

#### Usuários
- `uspUsuariosAlterar.sql`
- `uspUsuariosBuscar.sql`
- `uspUsuariosIncluir.sql`

#### Validação
- `uspValidarCronogramaDia.sql`
- `uspValidarDiaRepetido.sql`
- `uspValidarLogin.sql`
- `uspValidarPeriodoRepetido.sql`
- `uspValidarTurma.sql`
- `uspValidarUsuarioAdministrador.sql`
- `uspValidarUsuarioExistente.sql`

### Scripts

- `bd.sql`
- `script_calendario.sql`
- `script_versao.sql`

## Arquitetura Aplicada

O Espaço TP adota uma arquitetura em camadas, proporcionando uma separação clara das responsabilidades e facilita a manutenção e escalabilidade do sistema. A arquitetura é composta por:

- **Camada de Apresentação**: Responsável pela interação com o usuário, apresentando a interface gráfica do sistema.
- **Camada de Negócio (BLL)**: Contém a lógica de negócio do sistema, onde são realizadas as operações e validações necessárias para o funcionamento correto das funcionalidades.
- **Camada de Acesso a Dados (DAL)**: Responsável pela interação com o banco de dados, incluindo operações de leitura, escrita e manipulação dos dados.
- **Modelo (MODEL)**: Define as classes que representam o modelo de dados do sistema, incluindo entidades e objetos de transferência de dados (DTOs).

## Instruções para Executar o Projeto

### 1. Configuração do Banco de Dados

- Certifique-se de ter o MySQL instalado em seu sistema.
- Utilize o script SQL fornecido em `UTIL/MYSQL/SCRIPTS` para criar o banco de dados `espaco_tp`.
- Edite o arquivo `ConexaoBD.cs` em `UTIL` para ajustar os parâmetros de conexão com o banco de dados, conforme necessário. Por exemplo, a string de conexão `strBanco` deve ser configurada com as informações do seu servidor MySQL, incluindo o nome do servidor, porta, nome do banco de dados, usuário e senha.

### 2. Compilação e Execução

- Certifique-se de ter o ambiente de desenvolvimento C# configurado, utilizando preferencialmente o Visual Studio.
- Abra o arquivo de solução `EspacoTP.sln` no Visual Studio.
- Compile o projeto para garantir que não haja erros de compilação.
- Defina o projeto `FrmLogin.cs` como ponto de entrada da aplicação. Você pode fazer isso clicando com o botão direito no projeto no Solution Explorer, selecionando “Definir como Projeto de Inicialização”.
- Execute o projeto pressionando F5 ou selecionando “Iniciar” no Visual Studio.
- O formulário de login será exibido. Você pode usar as credenciais fornecidas ou as que foram configuradas no banco de dados.

### 3. Uso do Sistema

- Após fazer login com sucesso, você será redirecionado para o painel principal do sistema, onde poderá acessar e gerenciar as diferentes funcionalidades disponíveis.
- Explore as diferentes opções do sistema, como agendamento de atividades, gerenciamento de alunos e instrutores, controle de pagamentos e contratos, entre outros.
- Em caso de dúvidas ou problemas, consulte a documentação fornecida ou entre em contato com o suporte técnico.

Com estas instruções, você estará pronto para executar e utilizar o projeto “Espaço TP” em seu ambiente local.

## Diretrizes de Contribuição

Contribuições para este projeto são bem-vindas. Sinta-se à vontade para abrir pull requests, relatar bugs ou sugerir novos recursos.
