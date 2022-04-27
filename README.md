# homeTasks
Aplicação web para criação e listagem de tarefas, feita em .Net versão 4.8 com arquitetura mvc. A solução possui 3 projetos (Dominio, Repositório e UI) e possui comunicação com banco de dados relacional sqlServer através de um framework ORM (mapeamento de objeto Relacional) NHinerbate.

Essas instruções permitirão que você obtenha uma cópia do projeto em operação na sua máquina local para fins de desenvolvimento e teste.


📋 Pré Requisitos

Visual Studio 2022
Sql Server 2018 ou Superior
.Net framework 4.8
Sistema Operacional Windows 10 ou Superior

Instalação

-Baixe o arquivo HomeTasks.Rar do projeto e descompacte em qualquer local do computador.
-Baixe o arquivo HomeTasksBD.bak 
-Crie um banco de dados no sqlserver chamado HomeTasksBD
-restaure o banco de dados HomeTasksBD através do arquivo HomeTasksBD.bak
-abra a solução através do visual studio e vá no projeto HomeTasksWebIU e abra o arquivo hibernate.cfg.xml
-localize a linha de comando no arquivo property name="connection.connection_string e altere os parametros de Server,Data Source,Database e Pwd de acordo com as informações do servidor sql onde está hospedado o banco de dados da aplicação.
-execute a aplicação pelo visual studio e aguarde a tela ser exibida no seu navegador.

Testes

-via interface da aplicação é possível testar a ferramenta fazendo inserção, edição e exclusão dos dados do formulário.


Versão

- A aplicação se encontra na versão 1.0. Para versões disponíveis, observe a tags neste repositório.


autor

- David Dantas





