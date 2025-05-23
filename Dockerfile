FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY *.sln ./
COPY Desafio_Itau.Api/*.csproj ./Desafio_Itau.Api/
RUN dotnet restore

COPY . .
WORKDIR /src/Desafio_Itau.Api
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

EXPOSE 80
ENTRYPOINT [ "dotnet", "Desafio_Itau.Api.dll" ]