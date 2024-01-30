# Verwendenung der offiziellen Microsoft SDK-Images zum Erstellen des Codes
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["techdemo-heigl-kaitoua.csproj", "./"]
RUN dotnet restore "techdemo-heigl-kaitoua.csproj"
COPY . .
RUN dotnet build "techdemo-heigl-kaitoua.csproj" -c Release -o /app/build

# Veröffentlichung des Projekts
FROM build AS publish
RUN dotnet publish "techdemo-heigl-kaitoua.csproj" -c Release -o /app/publish

# Verwendung der Nginx-Webserver, um die statischen Dateien zu bedienen
FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html

# Entfernung der Standard-Nginx-Website
RUN rm -rf ./*
COPY --from=publish /app/publish/wwwroot .

ENTRYPOINT ["nginx", "-g", "daemon off;"]
