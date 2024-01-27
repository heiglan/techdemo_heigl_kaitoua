FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["techdemo-heigl-kaitoua/techdemo-heigl-kaitoua.csproj", "./"]
RUN dotnet restore "techdemo-heigl-kaitoua.csproj"
COPY techdemo-heigl-kaitoua/ ./
RUN dotnet build "techdemo-heigl-kaitoua.csproj" -c Release -o /app/build


FROM build AS test
RUN dotnet test "techdemo-heigl-kaitoua.csproj" --no-build -c Release

FROM build AS publish
RUN dotnet publish "techdemo-heigl-kaitoua.csproj" -c Release -o /app/publish

# Verwenden Sie einen Nginx-Webserver, um die statischen Dateien zu bedienen
FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
# Entfernen Sie die Standard-Nginx-Website
RUN rm -rf ./*
COPY --from=publish /app/publish/wwwroot .
# Kopieren Sie Ihre Nginx-Konfiguration (falls vorhanden) oder verwenden Sie die Standardkonfiguration
# COPY path/to/your/nginx.conf /etc/nginx/nginx.conf
ENTRYPOINT ["nginx", "-g", "daemon off;"]
