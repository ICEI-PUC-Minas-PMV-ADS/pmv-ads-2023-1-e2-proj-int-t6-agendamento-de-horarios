# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

Para cada caso de teste definido no Plano de Testes de Software, realize o registro das evidências dos testes feitos na aplicação pela equipe, que comprovem que o critério de êxito foi alcançado (ou não!!!). Para isso, utilize uma ferramenta de captura de tela que mostre cada um dos casos de teste definidos (obs.: cada caso de teste deverá possuir um vídeo do tipo _screencast_ para caracterizar uma evidência do referido caso).

Todos os testes foram feitos a partir da aplicação online na Azure: https://webbarbearia20230612031154.azurewebsites.net/

## CT-01 – Cadastrar perfil
A imagem a seguir demonstra o resultado do teste deste requisito, sendo que o usuário inseriu os seus dados no formulário de registro e o sistema não retornou nenhum alerta de erro:

![register](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t6-agendamento-de-horarios/assets/82223068/68f1d109-0001-41cc-9f76-d0f70b8d1835)

O usuário foi encaminhado até a página de confirmação de cadastro, o usuário deve clicar em confirmar sua conta:

![register confirmation](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t6-agendamento-de-horarios/assets/82223068/5f7ea3f9-e18d-4d64-9ad0-1324148eb4f4)

Retornando a mensagem de registro confirmado:

![register confirmed](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t6-agendamento-de-horarios/assets/82223068/d6f3070f-cdcb-4fac-90a6-2a89bed07bb3)

## Conclusão CT-01

Após o usuário cadastrar suas informações ele será liberado para fazer login na aplicação.

## CT-02 – Efetuar Login

Assim que o usuário se registar poderá realizar login, a imagem a seguir demonstra o resultado do teste, sendo que o usuário inseriu os seus dados no formulário de Login e o sistema não retornou nenhum alerta de erro:

![login](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t6-agendamento-de-horarios/assets/82223068/e951264b-5651-459d-85d5-5fbd2b07b757)

Caso o usuário forneça alguma informação de login errada o sistema retornará um erro de Login:

![senha errada](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t6-agendamento-de-horarios/assets/82223068/bcfea3fa-0c9b-464a-b048-6c21f6a12c9a)

Após fornecer as informações corretas, o usuário será redirecionado a página Home alterando o cabeçalho com uma mensagem de "Hello" e seu email cadastrado:

![login correto](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t6-agendamento-de-horarios/assets/82223068/4c8f23ec-c0ec-4599-819b-d02ed4156e6e)

## Conclusão CT-02

Após o usuário fornecer suas informações corretas de login ele será redirecionado a página home, podendo realizar suas atividades.

## CT-03 - Realizar reserva

Após o usuário realizar o login poderá ir até a aba "Agendamentos" para realizar sua reserva:

![agendamentos](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t6-agendamento-de-horarios/assets/82223068/e24a2e57-623d-455d-8fcd-e9eaefe50c9e)

Logo após indo até a opção "Agendar":

![agendamento](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t6-agendamento-de-horarios/assets/82223068/165aa8de-ee4a-4664-b559-ebd1c3810e8c)

O usuário passará suas informações e poderá escolher a data, hora e o profissional desejado para a sua reserva:

![create agendamento](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t6-agendamento-de-horarios/assets/82223068/6dd7d7c3-68ab-4071-8632-ab8b149670d1)
![data agendamento](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t6-agendamento-de-horarios/assets/82223068/c44667cf-e4db-4e08-97f8-e276520054cf)
![profissional agendamento](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t6-agendamento-de-horarios/assets/82223068/a60fb55d-65be-4169-a99b-91c4b8d9a8c2)

Após fornecer as informações desejadas o agendamento será criado e exibido na aba agendamentos, podendo ser editado ou deletado:

![agendamento criado](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t6-agendamento-de-horarios/assets/82223068/9bb03fe8-136f-4756-8a5d-3187a3c444c0)

## Conclusão CT-03

A funcionalidade funcionou corretamente sem nenhum erro durante os testes, atendendo o requisito.

## CT-04 - Verificar histórico

O sistema irá mostrar o histórico de agendamentos na aba agendamentos:

![historico](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t6-agendamento-de-horarios/assets/82223068/3714d47d-8d20-436d-a5bf-41c4052f2412)

## Conclusão CT-04

O sistema mostrou o histórico corretamente, porém na primeira versão o usuário conseguia visualizar os agendamentos de outros usuários o que não deveria ser permitido. 

Após a correção o sistema exibe somente os agendamentos criados pelo usuário.

## CT-05 - Gerenciar agendamentos

Para o usuário editar seu agendamento basta localizalo na aba agendamentos e ir até a opção "Edit":

![edit agendamento](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t6-agendamento-de-horarios/assets/82223068/e2ec8803-fce3-47b3-8f00-33e409606e6f)

Podendo alterar todas as informações, como por exemplo alterando o horário das 14 para as 15, e salvando logo em seguida:

![agendamento editado](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t6-agendamento-de-horarios/assets/82223068/9f3e6069-3aa2-4349-8bb4-025b12f96ba1)
![agendamento editado index](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t6-agendamento-de-horarios/assets/82223068/bb731e57-d921-485b-95f5-dd0b5276e7a2)

## Conclusão CT-05

O sistema está gerenciando o agendamento sem nenhum problema, porém na primeira versão o usuário conseguia editar os agendamentos de outros usuários o que não deveria ser permitido.

Após a correção o sistema não permite o usuário editar agendamento de outros usuários, somente os que foi criado por ele.
