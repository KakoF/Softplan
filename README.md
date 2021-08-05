# Projeto em .Net Core 3.1

Contemplando:

- Api para Taxa(2 endpoints, para recuperar a taxa e url do git -> Consultar Swagger)
- Api para Calculo(2 endpoints, para recuperar a taxa e url do git -> Consultar swagger)
- Classlib para Domain
- Classlib para Serviços
- Teste Unitarios(Ressalto que teste é algo que eu não tenho tanta experência, sei que é necessário e estou me organizando pra estudar isso melhor)

## Instalar dependências para executar o projeto

Na pasta src

```bash
dotnet restore

...

dotnet build
```

## APIS

Apis são independentes, rodar em cada diretório(Api.Calculo e Api.Taxa)

```bash
dotnet watch run
```
