# Programação de Funcionalidades

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="4-Metodologia.md"> Metodologia</a>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="5-Arquitetura da Solução.md"> Arquitetura da Solução</a>

Implementação do sistema descrita por meio dos requisitos funcionais e/ou não funcionais. Deve relacionar os requisitos atendidos com os artefatos criados (código fonte), deverão apresentadas as instruções para acesso e verificação da implementação que deve estar funcional no ambiente de hospedagem.

Por exemplo: a tabela a seguir deverá ser preenchida considerando os artefatos desenvolvidos.

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-01| Permitir que o usuário visualize as marcações ja realizadas e posso realizar uma nova marcação | AgendamentosController.cs / Agendamentos.cs / Create.cshtml / Details.cshtml / Index.cshtml |
|RF-02| Permitir que o usuário realize seu cadastro e login | usuario.cs / LoginController.cs / CadastroController.cs / index.cshtml do login / index.cshtml do cadastro |
|RF-03| Permitir que o usuário realize uma reserva na agenda selecionando o horário e serviço necessário | AgendamentosController.cs / Agendamentos.cs / Create.cshtml / Details.cshtml / Index.cshtml |
|RF-04| Permitir que ao usuário pesquisar e visualizar o histório de marcações na agenda | AgendamentosController.cs / Agendamentos.cs / Details.cshtml / Index.cshtml |
|RF-05| Permitir que o usuário possa gerenciar uma marcação ja realizada, excluindo ou editando as informações ja registradas nela| AgendamentosController.cs / Agendamentos.cs / Create.cshtml / Delete.cshtml / Details.cshtml / Edit.cshtml / Index.cshtml |


# Instruções de acesso

O aplicação ja está acessível através do seguinte link: https://projetobarbearia.azurewebsites.net/

Assim que acessado o sistema, pode ser feito o cadastro, login e em seguida realizar a sua reserva e visualiza-la salva.

