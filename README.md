# homeTasks
Aplicação web para criação e listagem de tarefas, feita em .Net versão 4.8 com arquitetura mvc. A solução possui 3 projetos (Dominio, Repositório e UI) e possui comunicação com banco de dados relacional sqlServer através de um framework ORM (mapeamento de objeto Relacional) NHinerbate.

Essas instruções permitirão que você obtenha uma cópia do projeto em operação na sua máquina local para fins de desenvolvimento e teste.


📋 Pré Requisitos

Visual Studio 2022
Sql Server 2018 ou Superior
.Net framework 4.8
Sistema Operacional Windows 10 ou Superior

Instalação

-Baixe os arquivos .Rar do projeto e descompacte em uma pasta com nome HomeTasks e dentro irá conter 3 pastas(HomeTasks , HomeTasks.Dominio, HomeTasks.Repostorio). /p
- Dentro da pasta HomeTasks crie uma pasta chamada packages e descompacte os arquivos rar. (packages, packages1 e packages2) 
-Baixe o arquivo HomeTasksBD.bak /p
-Crie um banco de dados no sqlserver chamado HomeTasksBD /p
-restaure o banco de dados HomeTasksBD através do arquivo HomeTasksBD.bak /p
-abra a solução através do visual studio e vá no projeto HomeTasksWebIU e abra o arquivo hibernate.cfg.xml /p
-localize a linha de comando no arquivo property name="connection.connection_string e altere os parametros de Server,Data Source,Database e Pwd de acordo com as informações do servidor sql onde está hospedado o banco de dados da aplicação. /p
-execute a aplicação pelo visual studio e aguarde a tela ser exibida no seu navegador. /p

Testes

-via interface da aplicação é possível testar a ferramenta fazendo inserção, edição e exclusão dos dados do formulário.


Versão

- A aplicação se encontra na versão 1.0. Para versões disponíveis, observe a tags neste repositório.


autor

- David Dantas





