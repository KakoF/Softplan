# Projeto em .Net Core 3.1

Contemplando:

- Api para Taxa(2 endpoints, para recuperar a taxa e url do git -> Consultar Swagger)
- Api para Calculo(2 endpoints, para recuperar a taxa e url do git -> Consultar Swagger)
- Classlib para Domain
- Classlib para Services
- Teste Unitarios(Ressalto que teste é algo que eu não tenho tanta experência, sei que é necessário e estou me organizando pra estudar isso melhor)

## Instalar dependências para executar o projeto

Na pasta src rodar

```bash
dotnet restore

...

dotnet build
```

## APIS

Apis são independentes, rodar em cada diretório(Api.Calculo e Api.Taxa):

```bash
dotnet watch run
```

## Observação

Testes é um fator que eu quero estudar para implementação concisa, então:

- Contempla teste unitário, mas reconheço minha falta de experiência nisso
- Não contempla teste de integração
- Preciso melhorar subir os containers com a aplicação, devido as classlibs eu tive muita dúvida. Docker no meu dia a dia apenas para subir alguma dependência(redis, algum banco, etc...)

## 08/08/2021
Imagem com as 2 aplicação foram adicionadas
