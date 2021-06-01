# Tarefa 1 - O chamado da aventura 🧭

- Crie um repositório no Github com a sua conta pessoal
- Adicione um arquivo .gitignore para projetos em .NET
- Adicione um projeto .NET 5 do tipo webapi
- Execute o projeto e tente encontrar a página da sua documentação
URL padrão: https://localhost:5001/swagger/index.html
- Modifique o método do Controller para ver a diferença que isso causa na API
- Envie o link do seu repositório no grupo ou para o professor

# Resolução

- Após a criação do repositorio no Github e clonar o repositorio no Github Desktop, abri o diretorio da tarefa e rodei os seguintes comandos no terminal
- Criar o projeto webapi
> dotnet new webapi
- Executar o projeto
> dotnet run    
- Seguinte resposta foi obtida e seguindo o link foi sugerido
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
