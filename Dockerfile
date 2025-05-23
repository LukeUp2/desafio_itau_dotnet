FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY *.sln ./
COPY src/Desafio_Itau.Api/*.csproj ./src/Desafio_Itau.Api/
RUN dotnet restore ./src/Desafio_Itau.Api/Desafio_Itau.Api.csproj

COPY . .
WORKDIR /src/Desafio_Itau.Api
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

EXPOSE 80
ENTRYPOINT [ "dotnet", "Desafio_Itau.Api.dll" ]