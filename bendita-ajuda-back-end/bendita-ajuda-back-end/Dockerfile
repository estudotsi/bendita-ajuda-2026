# ========================
# BUILD
# ========================
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copia tudo para o container
COPY . .

# Restaura dependências
RUN dotnet restore

# Publica a aplicação
RUN dotnet publish -c Release -o /app/publish

# ========================
# RUNTIME
# ========================
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Porta da aplicação
EXPOSE 80

# Copia arquivos publicados
COPY --from=build /app/publish .

# ⚠️ TROQUE PELO NOME DA SUA DLL
ENTRYPOINT ["dotnet", "bendita-ajuda-back-end.dll"]