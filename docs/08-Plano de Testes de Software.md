# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Os requisitos para realização dos testes de software são:

- Site publicado na Internet
- Navegador da Internet - Chrome, Firefox ou Edge
- Conectividade de Internet para acesso às plataformas (APISs)

Os testes funcionais a serem realizados no aplicativo são descritos a seguir.
 
| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-02 - A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://webbarbearia20230612031154.azurewebsites.net/<br> - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios (e-mail, senha, confirmação de senha) <br> - Aceitar os termos de uso <br> - Clicar em "Registrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-02 – Efetuar login	|
|Requisito Associado | RF-02	- A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://webbarbearia20230612031154.azurewebsites.net/<br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|Critério de Êxito | - O login foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-03 – Realizar reserva	|
|Requisito Associado | RF-01, 03	- A aplicação deve possuir opção de realizar a reserva de um horário na agenda. |
| Objetivo do Teste 	| Verificar se o usuário consegue reservar um horário para ser atendido. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://webbarbearia20230612031154.azurewebsites.net/<br> - Clicar no botão "Reservar horário" <br> - Selecionar a data e horário disponível <br> - Confirmar agendamento|
|Critério de Êxito | - A reserva foi realizada com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-04 – Verificar histórico	|
|Requisito Associado | RF-04	- A aplicação deve possuir opção de verificar todos agendamentos ja realizados. |
| Objetivo do Teste 	| Verificar se o usuário consegue visualizar o histório de agendamentos. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://webbarbearia20230612031154.azurewebsites.net/<br> - Clicar na aba agendamentos <br> - Deste modo a aplicação irá mostrar o histórico de agendamentos|
|Critério de Êxito | - A reserva foi realizada com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-05 – Gerenciar agendamentos	|
|Requisito Associado | RF-05	- A aplicação deve possuir opção de gerenciar uma marcação na agenda. |
| Objetivo do Teste 	| Verificar se o usuário consegue alterar o horário de uma reserva. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://webbarbearia20230612031154.azurewebsites.net/<br> - Selecionar um agendamento já realizado na agenda <br> - Alterar a data e horário dessa reserva <br> - Gravar a alteração, salvando o agendamento novamente|
|Critério de Êxito | - A reserva foi realizada com sucesso. |
