# Build-Stage: Erstellen des Codes
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["techdemo-heigl-kaitoua.csproj", "./"]
RUN dotnet restore "techdemo-heigl-kaitoua.csproj"
COPY . .
RUN dotnet build "techdemo-heigl-kaitoua.csproj" -c Release -o /app/build

# Publish-Stage: Veröffentlichen des Projekts
FROM build AS publish
RUN dotnet publish "techdemo-heigl-kaitoua.csproj" -c Release -o /app/publish

# Test-Stage: Ausführen der Tests
FROM build AS test
RUN dotnet test "techdemo-heigl-kaitoua.csproj" --no-build -c Release

# Final-Stage: Verwenden eines Nginx-Webservers für statische Dateien
FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
RUN rm -rf ./*
COPY --from=publish /app/publish/wwwroot .
ENTRYPOINT ["nginx", "-g", "daemon off;"]
