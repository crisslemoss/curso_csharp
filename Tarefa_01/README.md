# Tarefa 1 - O chamado da aventura 🧭

- Crie um repositório no Github com a sua conta pessoal
- Adicione um arquivo .gitignore para projetos em .NET
- Adicione um projeto .NET 5 do tipo webapi
- Execute o projeto e tente encontrar a página da sua documentação
URL padrão: https://localhost:5001/swagger/index.html
- Modifique o método do Controller para ver a diferença que isso causa na API
- Envie o link do seu repositório no grupo ou para o professor

### 🛠 Pré-requisitos

Antes de começar, você vai precisar ter instalado em sua máquina as seguintes ferramentas:
[Git](https://git-scm.com), [.NET](https://dotnet.microsoft.com/download) e [GitHubDesktop](https://desktop.github.com/). 
Além disto é bom ter um editor para trabalhar com o código como [VSCode](https://code.visualstudio.com/)

### Resolução :black_nib:

- Após a criação do repositorio no Github e clonar o repositorio no Github Desktop, abrir o diretorio da tarefa e executar os seguintes comandos no terminal..
- :boom: Criar o projeto webapi
> dotnet new webapi
- :runner: Executar o projeto
> dotnet run    
- :pray: Seguinte resposta foi obtida e seguindo o link foi sugerido
```
 info: Microsoft.Hosting.Lifetime[0]
       Now listening on: https://localhost:[porta]
 info: Microsoft.Hosting.Lifetime[0]
       Now listening on: http://localhost:[porta]
 info: Microsoft.Hosting.Lifetime[0]
       Application started. Press Ctrl+C to shut down.
```
- Abrir o link acima (ele retornara 404 pois nao há pagina html e sim uma API) Entao complete o link com /swagger
- URL completa será: https://localhost:[porta]/swagger/index.html
