FROM mcr.microsoft.com/dotnet/sdk:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY src/Softplan.sln ./

COPY src/Api.Taxa/*.csproj ./Api.Taxa/
COPY src/Domain/*.csproj ./Domain/
COPY src/Service/*.csproj ./Service/
COPY src/Api.Calculo/*.csproj ./Api.Calculo/
COPY src/Api.Tests/*.csproj ./Api.Tests/


RUN dotnet restore
COPY . .
WORKDIR /src/Service
RUN dotnet build -c Release -o /app

RUN dotnet restore
COPY . .
WORKDIR /src/Domain
RUN dotnet build -c Release -o /app

WORKDIR /src/Api.Calculo
RUN dotnet build -c Release -o /app

WORKDIR /src/Api.Taxa
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app
#RUN dotnet publish src\Api.Calculo -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Api.dll"]