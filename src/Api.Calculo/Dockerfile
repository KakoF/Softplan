FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
#COPY ./src/Api.Calculo/*.csproj ./
COPY *.csproj ./
#COPY ./src/ ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:3.1
WORKDIR /app
EXPOSE 87
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "ApiCalculo.dll"]