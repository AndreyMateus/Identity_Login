# Projeto - Utilizando a Identity API

## Oque é o Identity API e como funciona ?

A Identity API é uma API do ASP.NET Core que oferece recursos de autenticação e autorização para aplicativos da web. Ela simplifica a implementação de recursos de identidade, como autenticação de usuários, gerenciamento de contas e autorização baseada em roles. A Identity API é configurada por padrão para utilizar o provedor de armazenamento de dados Entity Framework Core (EF Core), permitindo armazenar informações relacionadas à identidade dos usuários em um banco de dados relacional.

***No entanto***, ela também suporta outros provedores de armazenamento de dados, proporcionando flexibilidade na escolha do provedor mais adequado às necessidades do projeto. Além disso, a Identity API é altamente personalizável, permitindo ajustes e customizações de acordo com os requisitos específicos do aplicativo.

***

## Como é a estrutura do Identity API dentro do projeto/design ?

 Será criado uma pasta chamada **"Areas"** onde ficarão todos os ***"dados/estruturas/pastas"*** gerados pela Identity API, há uma exceção, que são os arquivos padrões compilados do Identity e que estão dentro da pasta BIN.

***

## Pré-requistos para Rodar o Projeto Identity API

 - .NET SDK 6.0
 - Servidor de Banco de Dados SqlServer rodando em sua máquina.

> **Não se preocupe em criar qualquer BANCO ou TABELA**, apenas necessitamos de um *servidor SqlServer*, o resto o Entity Framework Core fará para nós automaticamente.

***

## Como Instalar e Rodar o projeto

 1. Execute um Git Clone do Projeto ou Baixe ele e o abra em sua IDE.
 2. Vá no arquivo **Settings.json** e Configure a sua ***String de Conexão***, ( lá terá um TEMPLATE da connection string esperada pelo **SQLSERVER**, basta apenas que você o preencha corretamente.)

 - Na Connection String haverá o **Database=identityefcoreproject;**, esse Database será criado automaticamente, você não precisa se preocupar, caso queira mudar o nome do Database, fique à vontade.

 3. Abra o Terminal e execute o comando: ***```dotnet restore```***
 4. Novamente abra o Terminal e execute o comando: ***```dotnet build```***
 5. Caso não seja detectado algum erro com o **passo 6**, execute um ***```dotnet run```***.
 6. **Divirta-se**.

***

## Pré-requistos para Modificar os recursos/pages da Identity API

 - Ferramenta (CLI) **ASPNET Code Generator** da plataforma **.NET**, a instalação ocorre mais abaixo nesse mesmo **READ-ME.**

***

## Como Personalizar e Modificar Arquivos/Pages do Identity API ?

- Primeiro temos que gerar esses arquivos, para que possamos modificá-los, ***Pois por padrão, o IDENTITY vem com os arquivos em versão Compilada***.

 1. Abra o Terminal do Projeto e Instale a Ferramenta (CLI) **DOTNET ASPNET CODE GENERATOR** executando o seguinte comando: ***```dotnet tool install -g dotnet-aspnet-codegenerator```***
 2. Abra o Terminal do Projeto e Instale o seguinte **PACOTE/PACKAGE** executando o seguinte comando: ***```dotnet add package Microsoft.VisualStudio.Web.Codegeneration.Design --version 6```***

 **O passo 2** não será necessário se você estiver utilizando o projeto deste repositório, pois esse pacote **já foi adicionado** ***por mim***.

 - Então após termos **INSTALADO** a **FERRAMENTA DE <u>CLI</u>** para geração de códigos/templates e o **PACKAGE/PACOTE**, conseguiremos modificar esses arquivos e **RE-COMPILAR** eles, assim os substituíremos pela nova versão **COMPILADA**, que foi criada após modificarmos os arquivos.

 3. Listaremos todos os ARQUIVOS que PODEM ser GERADOS e ALTERADOS com o seguinte comando: ```dotnet-aspnet-codegenerator identity --listFiles```
 4. Iremos gerar os arquivos com base no **CONTEXTO** escolhido, para que assim possamos modificá-los: ```dotnet aspnet-codegenerator identity -dc Identity_Login.Data.ApplicationDbContext.cs --files Account.Register```
 5. Modifique a página/arquivo desejado e seja feliz!

***

***Uma Curiosidade é que a Ferramenta ```dotnet aspnet-codegenerator``` pode ser usada para gerar <u>DIVERSOS</u> tipos de <u>ESTRUTURAS</u> e <u>ARQUIVOS</u> entre DIFERENTES tipos de PROJETOS.***

***

 **Dica**
 <p>Se quiser utilizar a IDENTIY API com outros Servidores de Banco de dados, como o MySql por exemplo, é necessário que você remova/exclua a MIGRATION padrão que já vem no PROJETO e também RESETE as TABELAS do BANCO de DADOS.</p>

***

Vídeo do Projeto: [Clique aqui para Assistir](https://www.youtube.com.br)
