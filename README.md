# Projeto - Utilizando a Identity API

## Oque é o Identity API e como funciona ?

>A Identity API é uma API do ASP.NET Core que oferece recursos de autenticação e autorização para aplicativos da web. Ela simplifica a implementação de recursos de identidade, como autenticação de usuários, gerenciamento de contas e autorização baseada em roles. A Identity API é configurada por padrão para utilizar o provedor de armazenamento de dados Entity Framework Core (EF Core), permitindo armazenar informações relacionadas à identidade dos usuários em um banco de dados relacional.

>***No entanto***, ela também suporta outros provedores de armazenamento de dados, proporcionando flexibilidade na escolha do provedor mais adequado às necessidades do projeto. Além disso, a Identity API é altamente personalizável, permitindo ajustes e customizações de acordo com os requisitos específicos do aplicativo.

***

## Como utilizar a Identity API ?

> Utilizando as ferramentas de CLI disponibilizadas pela ***Plataforma DOTNET***.
> Sendo elas: O ***Code Generator*** e o ***Code Generator <u>Design</u>***.
***

## Como é a estrutura do Identity API dentro do projeto/design ?

> Será criado uma pasta chamada **"Areas"** onde ficarão todos os ***"dados/estruturas/pastas"*** gerados pela Identity API, há uma exceção, que são os arquivos padrões compilados do Identity e que estão dentro da pasta BIN.

***

## Pré-requistos para utilizar a Identity API

> - .NET SDK 6.0
> - Ferramenta (CLI) Code Generator Aspnet do .Net, a instalação ocorre mais abaixo nesse mesmo **READ-ME.**
> - Servidor de Banco de Dados SqlServer rodando em sua máquina.
> **Não se preocupe em criar qualquer TABELA**, apenas necessitamos de um *servidor SqlServer*, o resto o Entity Framework Core fará para nós automaticamente.

***

## Como Instalar e Rodar o projeto

> 1. Execute um Git Clone do Projeto e o abra em sua IDE.
> 2. Abra o Terminal do Projeto e Instale a Ferramenta (CLI) **DOTNET ASPNET CODE GENERATOR <u>DESIGN</u>** executando o seguinte comando: ***```dotnet```***
> 3. Vá no arquivo **Settings.json** e Configure a sua ***String de Conexão***, ( lá terá um TEMPLATE da connection string esperada pelo **SQLSERVER**, basta apenas que você o preencha corretamente.)
> 4. Abra o Terminal e execute o comando: ***```dotnet restore```***
> 5. Novamente abra o Terminal e execute o comando: ***```dotnet build```***
> 6. Caso não seja detectado algum erro com o **passo 6**, execute um ***```dotnet run```***.
> 7. **Divirta-se**.

***

## Como Personalizar e Modificar Arquivos/Pages do Identity API ?

> 1. Primeiro temos que gerar esses arquivos, para que possamos modificá-los.

- ***Pois por padrão, o IDENTITY vem com os arquivos em versão Compilada***

> 2. Abra o Terminal do Projeto e Instale a Ferramenta (CLI) **DOTNET ASPNET CODE GENERATOR** executando o seguinte comando: ***```dotnet tool install -g dotnet-aspnet-codegenerator```***
> 3. Abra o Terminal do Projeto e Instale o seguinte **PACOTE/PACKAGE** executando o seguinte comando: ***```dotnet add package Microsoft.VisualStudio.Web.Codegeneration.Design --version 6```***
> 4. Então após termos **INSTALADO** as **FERRAMENTAS DE <u>CLI</u>** para geração de códigos/templates, conseguiremos modificar esses arquivos e **RE-COMPILAR** eles, assim os substituindo pela nova versão **COMPILADA**, que foi criada por nós.
> 5. Listaremos todos os ARQUIVOS que PODEM ser GERADOS e ALTERÁDOS com o seguinte comando: ```dotnet-aspnet-codegenerator identity --listFiles```
> 6. Iremos gerar o arquivo com base no **CONTEXTO** escolhido, para que assim possamos modificá-lo: ```dotnet aspnet-codegenerator identity -dc Identity_Login.Data.ApplicationDbContext.cs --files Account.Register```

>***Uma Curiosidade é que a Ferramenta ```dotnet aspnet-codegenerator``` pode ser usada para gerar <u>DIVERSOS</u> tipos de <u>ESTRUTURAS</u> e <u>ARQUIVOS</u>.***

***
Vídeo do Projeto: [Clique aqui para Assistir](https://www.youtube.com.br)
