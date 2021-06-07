# Tarefa 1 - O chamado da aventura 🧭

- Crie um repositório no Github com a sua conta pessoal
- Adicione um arquivo .gitignore para projetos em .NET
- Adicione um projeto .NET 5 do tipo webapi
- Execute o projeto e tente encontrar a página da sua documentação
URL padrão: https://localhost:5001/swagger/index.html
- Modifique o método do Controller para ver a diferença que isso causa na API
- Envie o link do seu repositório no grupo ou para o professor


<p align="center">
  <img alt="GitHub language count" src="https://img.shields.io/github/languages/count/gabrielbruschi/curso-csharp?color=%2304D361">

  <img alt="Repository size" src="https://img.shields.io/github/repo-size/gabrielbruschi/curso-csharp">
  
  <a href="https://github.com/gabrielbruschi/curso-csharp/commits/master">
    <img alt="GitHub last commit" src="https://img.shields.io/github/last-commit/gabrielbruschi/curso-csharp">
  </a>
    
   <img alt="License" src="https://img.shields.io/badge/license-MIT-brightgreen">
   <a href="https://github.com/gabrielbruschi/curso-csharp/stargazers">
    <img alt="Stargazers" src="https://img.shields.io/github/stars/gabrielbruschi/curso-csharp?style=social">
  </a>
 
</p>


### 🛠 Pré-requisitos

Antes de começar, você vai precisar ter instalado em sua máquina as seguintes ferramentas:
[Git](https://git-scm.com), [.NET](https://dotnet.microsoft.com/download/).
Além disto é bom ter um editor para trabalhar com o código como [VSCode](https://code.visualstudio.com/)

#### 🎲 Rodando o Backend (servidor)


```bash

# Clone este repositório
$ git clone git@github.com:gabrielbruschi/curso-csharp.git

# Acesse a pasta do projeto no seu terminal/cmd
$ cd curso-csharp

# Criar o projeto webapi
$ dotnet new webapi

# Execute a aplicação em modo de desenvolvimento
$ dotnet run

# A aplicação será aberta na porta:5000 - acesse http://localhost:5000/swagger/v1/swagger.json

```
---

### Como contribuir no projeto

1. Faça um **fork** do projeto.
2. Crie uma nova branch com as suas alterações: `git checkout -b my-feature`
3. Salve as alterações e crie uma mensagem de commit contando o que você fez: `git commit -m "feature: My new feature"`
4. Envie as suas alterações: `git push origin my-feature`
   > Caso tenha alguma dúvida confira este [guia de como contribuir no GitHub](./CONTRIBUTING.md)
