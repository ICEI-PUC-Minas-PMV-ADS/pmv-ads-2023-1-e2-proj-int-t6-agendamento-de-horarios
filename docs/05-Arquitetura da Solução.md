# Arquitetura da Solução

Nesta seção serão apresentados os detalhes técnicos da solução criada pela equipe de projeto, tratando dos componentes que fazem parte da solução e do ambiente de hospedagem da solução de software.

O projeto será desenvolvido utilizando o padrão de arquitetura em camadas por meio de uma aplicação ASP.NET Core MVC. No front-end serão utilizados razor pages (.Net), html, css e javaScript. No back-end utilizaremos C# e a construção de API Rest para comunicação com banco de dados SQL Server.
## Diagrama de Classes

A arquitetura da solução consiste em uma aplicação web, uma API Rest e um banco de dados SQL Server hospedados em um servidor web na AZURE. O sistema pode ser acessado através de interfaces web instaladas em desktops, notebooks, dispositivos móveis e painéis televisores.

Na figura a seguir são apresentados as classes do sistema:






![Class Diagram0](https://user-images.githubusercontent.com/112700596/232232020-1c0d08ee-fd0d-4083-b7ad-127b123997a8.png)










## Modelo ER (Projeto Conceitual)

Para modelar um sistema de agendamento de horários usando a abordagem de modelagem de dados Entidade-Relacionamento (ER), identificamos as entidades e seus relacionamentos no sistema. Aqui está uma proposta de modelo ER para um sistema de agendamento de horários:

Entidades:

Empresa: organização que oferece o serviço.

Profissional: pessoa que presta o serviço agendado.

Agendamento: reserva de um horário para um serviço com um profissional.

Cliente: pessoa que agenda o horário.

Serviço: tipo de serviço a ser prestado.



![aa10](https://user-images.githubusercontent.com/112700596/232231306-163678ae-b822-43f0-97a8-70365a7ebf04.png)











## Projeto da Base de Dados

O sistema de agendamento de horários deve permitir que clientes agendem serviços com funcionários em horários disponíveis. Os clientes devem ser capazes de visualizar os horários disponíveis para os serviços que desejam agendar, selecionar um horário disponível e confirmar o agendamento. Os funcionários devem ser capazes de visualizar sua agenda diária com os serviços agendados e os horários disponíveis.



![fg25](https://user-images.githubusercontent.com/112700596/232231181-09372b13-0881-42d1-8752-279c0eccebd0.png)









## Tecnologias Utilizadas

Identity Microsoft: Gerenciamento de usuários,
Framework: ASP.NET 7,
Linguagem de programação: C#,
Banco de dados SQL Server,
Todas as telas do sistema serão desenvolvidas com o Css e Type Script tentando o máximo não utilizar plugins de terceiros.

## Hospedagem

Será utilizado os serviços de nuvem da AZURE para a hospedagem do sistema. Serão criados dois serviços Elastic Beanstalk para hospedar a aplicação web e a API Rest. O serviço RDS (Relational Database Service) será criado para hospedar o banco de dados SQL Server.

> **Links Úteis**:
>
> - [Website com GitHub Pages](https://pages.github.com/)
> - [Programação colaborativa com Repl.it](https://repl.it/)
> - [Getting Started with Heroku](https://devcenter.heroku.com/start)
> - [Publicando Seu Site No Heroku](http://pythonclub.com.br/publicando-seu-hello-world-no-heroku.html)
